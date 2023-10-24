using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class EventTypeDayCreate
   {
      public int EventId { get; set; }
      public int TypeId { get; set; }
      public DateTime Date { get; set; }
   }
}
