using DAL.Interfaces;
using DAL.Models;
using DAL.Services;
using GestionEvenementASP.Models.Forms;
using GestionEvenementASP.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;

namespace GestionEvenementASP.Controllers
{
   public class EventController : Controller
   {
      private readonly IEventService _eventService;
      private readonly SessionManager _sessionManager;
      public EventController(IEventService eventService, SessionManager sessionManager)
      {
         _eventService = eventService;
         _sessionManager = sessionManager;
      }
      public IActionResult List()
      {
         return View(_eventService.GetEvents());
      }

      [AdminRequired]
      public IActionResult Create()
      {
         return View();
      }

      [HttpPost]
      public IActionResult CreateEvent(Event e)
      {
         int nbrDays = (e.EndDate - e.StartDate).Days + 1;
         e.TypeByDays = new List<EventTypeDay>();
         for (int i = 0; i < nbrDays; i++)
         {
            e.TypeByDays.Add(new EventTypeDay { Date = (e.StartDate.AddDays(i)) });
         }
         TempData["i"] = 1;
         return View(e);
      }
      [HttpPost]
      public IActionResult AddType(Event e)
      {

         _eventService.Create(e.ToCreate(), _sessionManager.Token);
         Event lastEvent = _eventService.GetEvents().OrderBy(x => x.Id).Last();
         int i = 0;
         foreach (EventTypeDay day in e.TypeByDays)
         {
            day.EventId = lastEvent.Id;
            day.Date = lastEvent.StartDate.AddDays(i);
            _eventService.AddTypeByDays(day.ToCreate());
            i++;
         }

         return RedirectToAction("List");
      }
   }
}
