using DAL.Models;

namespace GestionEvenementASP.Tools
{
   public static class Mappers
   {
      public static EventCreate ToCreate(this Event e)
      {
         return new EventCreate
         {
            Name = e.Name,
            StartDate = e.StartDate,
            EndDate = e.EndDate,
            Adress = e.Adress,
            Location = e.Location
         };
      }

      public static EventTypeDayCreate ToCreate(this EventTypeDay e)
      {
         return new EventTypeDayCreate
         {
            EventId = e.EventId,
            TypeId = e.Type.Id,
            Date = e.Date
         };
      }
   }
}
