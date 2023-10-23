using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IEventService
   {
      void Create(Event e, string token);
      IEnumerable<Event> GetEvents();
      IEnumerable<EventType> GetTypes();
   }
}
