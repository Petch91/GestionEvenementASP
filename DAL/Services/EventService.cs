using DAL.Interfaces;
using DAL.Models;
using DAL.Tools;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
   public class EventService : GenericApiRequester, IEventService
   {
      private readonly string _url;
      public EventService(IConfiguration config)
      {
         _url = config.GetConnectionString("api");
      }
      public void Create(Event e, string token)
      {
         Post(e, _url + "Event/", token);
      }

      public IEnumerable<Event> GetEvents()
      {
         return Get<IEnumerable<Event>>(_url + "Event/");
      }

      public IEnumerable<EventType> GetTypes()
      {
         return Get<IEnumerable<EventType>>(_url + "Event/GetTypes/");
      }
   }
}
