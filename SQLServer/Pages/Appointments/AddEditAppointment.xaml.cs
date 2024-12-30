
using EClinicMaui.GeneralServices;

namespace EClinicMaui.SQLServer.Pages.Appointments
{
    
    public partial class AddEditAppointment : ContentPage
    {
        private readonly long AppointmentId = 0;
        private readonly long PatientId = 0;
        private readonly System.Collections.Generic.List<long> DoctorsId = new System.Collections.Generic.List<long>();
        private long? SecretaryForDoctorId;
        private long OldAppointmentDoctorId = 0;
        public AddEditAppointment(long AppointmentId, bool IsEdit)
        {
            InitializeComponent();
           

            this.AppointmentId = AppointmentId;

           

        }

        public AddEditAppointment(long PatientId)
        {
            InitializeComponent();
           

            this.PatientId = PatientId;

            Btn.Text = "Add";
            Btn.BackgroundColor = Color.FromArgb("#8BBF61");
            Btn.Clicked += AddAppointmentBtn_Click;

        }


        bool isAppeared = false;
        protected override async void OnAppearing()
        {
            if (isAppeared)
                return;

            isAppeared = true;

        
            base.OnAppearing();
        }

        private void WhichDoctorCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (WhichUserFrame.IsVisible && WhichDoctorCB.SelectedIndex == -1)
                return;

            OldAppointmentDoctorId = DoctorsId[WhichDoctorCB.SelectedIndex];
            FillOldAppointmentsGrid(AppointmentDate.Date);
        }

        private void AppointmentDate_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (WhichUserFrame.IsVisible && WhichDoctorCB.SelectedIndex == -1)
                return;
            FillOldAppointmentsGrid(AppointmentDate.Date);
        }

        public async void SaveAppointmentBtn_Click(object sender, EventArgs e)
        {
            
        }


        public async void AddAppointmentBtn_Click(object sender, EventArgs e)
        {
          
        }


        private async void FillOldAppointmentsGrid(DateTime OldAppointment)
        {


        }

    }
}
