﻿namespace DAL.Models
{
   public class EventCreate
   {
      public string Name { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public string Location { get; set; }
      public string Adress { get; set; }

   }
}
