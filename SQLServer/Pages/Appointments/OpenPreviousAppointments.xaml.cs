using EClinicMaui.SQLServer.Database;

namespace EClinicMaui.SQLServer.Pages.Appointments
{
    public partial class OpenPreviousAppointments : ContentPage
    {

        private readonly long PatientId;
        public OpenPreviousAppointments(long PatientId)
        {
            InitializeComponent();
       
            this.PatientId = PatientId;
        }

        bool isAppeared = false;
        protected override async void OnAppearing()
        {
           

            base.OnAppearing();
        }


        private async void FillGrid()
        {
            
        }

    }
}
