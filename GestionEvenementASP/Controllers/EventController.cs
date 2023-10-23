using DAL.Interfaces;
using DAL.Models;
using DAL.Services;
using GestionEvenementASP.Tools;
using Microsoft.AspNetCore.Mvc;

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
      //public IActionResult Create(Event e) 
      //{

      //   int nbrDays = (e.EndDate - e.StartDate).Days;
      //   e.TypeByDays = new List<EventTypeDay>();
      //   for (int i = 0; i<nbrDays;i++)
      //   {
      //      e.TypeByDays.Add(new EventTypeDay());
      //   }
      //   return RedirectToAction("AddTypeGet", new { e = e});
      //}
      [AdminRequired]
      public IActionResult AddTypeGet(Event e)
      {
         int nbrDays = (e.EndDate - e.StartDate).Days +1;
         e.TypeByDays = new List<EventTypeDay>();
         for (int i = 0; i < nbrDays; i++)
         {
            e.TypeByDays.Add(new EventTypeDay());
         }
         return View(e);
      }
      [HttpPost]
      public IActionResult AddType(Event e)
      {
         _eventService.Create(e, _sessionManager.Token);
         return RedirectToAction("List");
      }
   }
}
