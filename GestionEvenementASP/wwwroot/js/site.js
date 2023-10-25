//// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
//// for details on configuring this project to bundle and minify static web assets.

//// Write your JavaScript code.
//$(document).ready(function () {
//   $('.datepicker').datepicker({
//      format: 'yyyy-mm-dd',
//      clearBtn: true,
//      todayHighlight: true,
//      autoclose: true,
//      toggleActive: true,
//      // Limitez l'écart à 5 jours
//      endDate: '+5d'
//   });

//   // Activer le range picker
//   $('input[name="StartDate"]').on('changeDate', function (selected) {
//      var minDate = new Date(selected.date);
//      minDate.setDate(minDate.getDate() + 1); // Ajoute 1 jour
//      var maxDate = new Date(selected.date);
//      maxDate.setDate(maxDate.getDate() + 5); // Ajoute 5 jours
//      $('input[name="EndDate"]').datepicker('setStartDate', minDate);
//      $('input[name="EndDate"]').datepicker('setEndDate', maxDate);
//   });
//   $('input[name="EndDate"]').on('changeDate', function (selected) {
//      var maxDate = new Date(selected.date);
//      maxDate.setDate(maxDate.getDate() - 1); // Soustrait 1 jour
//      var minDate = new Date(selected.date);
//      minDate.setDate(minDate.getDate() - 5); // Soustrait 5 jours
//      $('input[name="StartDate"]').datepicker('setStartDate', minDate);
//      $('input[name="StartDate"]').datepicker('setEndDate', maxDate);
//   });
//});
$(document).ready(function () {
   $('input[name="StartDate"], input[name="EndDate"]').daterangepicker({
      singleDatePicker: true,
      showDropdowns: true,
      autoApply: true,
      minDate: moment().add(1, 'days'),
      maxDate: moment().add(5, 'days'),
      locale: {
         format: 'YYYY-MM-DD',
      },
   });

   // Validation pour limiter la sélection à 5 jours
   $('input[name="StartDate"], input[name="EndDate"]').on('apply.daterangepicker', function (ev, picker) {
      var startDate = picker.startDate;
      var endDate = picker.endDate;
      var daysDifference = endDate.diff(startDate, 'days');

      if (daysDifference > 5) {
         // Annuler la sélection
         $(this).val('');
         alert('La période sélectionnée ne peut pas dépasser 5 jours.');
      }
   });
});