using GestionEvenementASP.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Models
{
   [Serializable]
   public class Event
   {
      [ScaffoldColumn(false)]
      public int Id { get; set; }
      public string Name { get; set; }
      [DataType(DataType.Date)]
      [Display(Name = "Date de début")]
      [Required(ErrorMessage = "La date de début est obligatoire.")]
      public DateTime StartDate { get; set; }
      [DataType(DataType.Date)]
      [Display(Name = "Date de fin")]
      [Required(ErrorMessage = "La date de fin est obligatoire.")]
      [DateRange(5, ErrorMessage = "La période sélectionnée ne peut pas dépasser 5 jours.")]
      public DateTime EndDate { get; set; }
      public string Location { get; set; }
      public string Adress { get; set; }
      [ScaffoldColumn(false)]
      public string? Status { get; set; }
      public List<EventTypeDay>? TypeByDays { get; set; }

   }
}
