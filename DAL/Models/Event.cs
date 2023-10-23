using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class Event
   {
      [ScaffoldColumn(false)]
      public int Id { get; set; }
      public string Name { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public string Location { get; set; }
      public string Adress { get; set; }
      [ScaffoldColumn(false)]
      public int StatusId { get; set; }
      public List<EventTypeDay> TypeByDays { get; set; }

   }
}
