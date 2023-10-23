using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class EventTypeDay
   {
      public int Id { get; set; }
      public EventType Type { get; set; }
      public DateTime Date { get; set; }
      public int EventId { get; set; }
   }
}
