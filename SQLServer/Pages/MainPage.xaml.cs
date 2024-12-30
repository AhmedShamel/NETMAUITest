using EClinicMaui.SQLServer.Models;
using EClinicMaui.GeneralServices;
using System.Collections.Specialized;
using System.Net;
using EClinicMaui.SQLServer.Services;
using EClinicMaui.SQLServer.Database;
using System.Collections.ObjectModel;

namespace EClinicMaui.SQLServer.Pages
{
    public partial class MainPage : ContentPage
    {

        int PageOffset = 0;
        MainPage CurrentPage;
        bool RunFirstTime = true;
        public Models.TypeOfUser typeOfUser;
        private readonly List<long> DoctorsIds = new List<long>();

       
        public class CheckUserModel
        {
            public int DoctorsCount { get; set; }
            public int UserInfo { get; set; }
        }
        public MainPage()
        {

            InitializeComponent();
        }

        private void SearchNameTB_Completed(object sender, EventArgs e)
        {
           
        }

        private void ShowMenuBtn_Clicked(object sender, EventArgs e)
        {
            (Application.Current.MainPage as Sidebar).ShowFlyout();
        }



        public async void AddPatientBtn_Click(object sender, EventArgs e)
        {

        }

        public void SearchForPatient_TextChanged(object sender, TextChangedEventArgs e)
        {
        
        }




        public ObservableCollection<PatientsMainGridModel> PatientsGridItems = new ObservableCollection<PatientsMainGridModel>();
        public ObservableCollection<DoctorVisitsMainGridModel> DoctorsVisitsGridItems = new ObservableCollection<DoctorVisitsMainGridModel>();
        public ObservableCollection<VisitsMainGridForSecretaryModel> SecretaryVisitsGridItems = new ObservableCollection<VisitsMainGridForSecretaryModel>();
        public ObservableCollection<WaitingPatientsMainGridVisitsModel> WaitingPatientGridItems = new ObservableCollection<WaitingPatientsMainGridVisitsModel>();
        public async void FillGridView(int Offset)
        {
             }

        #region All Patients Grid

        bool ScrollReachEnd = false;
        private void PatientsGridView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {

            
        }
        private async void PatientsGridView_PatientOption(object sender, TappedEventArgs e)
        {
           
        }

        #endregion

        #region Doctor Visits

        private void DoctorVisitsGridView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
        }

        private async void DoctorVisitsGridView_PatientOption(object sender, EventArgs e)
        {
         
        }

        #endregion

        #region Waitings patients

        private void WaitingsGridView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
          
        }
        private async void WaitingsGridView_PatientOption(object sender, EventArgs e)
        {
        
        }

        #endregion

        #region Secretary Visits
        private void SecretaryVisitsGridView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
           
        }

        private async void SecretaryVisitsGridView_Tapped(object sender, EventArgs e)
        {
            
        }

        #endregion

        private void TableShowOptionsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void ShowWhichDateDP_DateSelected(object sender, DateChangedEventArgs e)
        {
           
        }

        private void EnteredStatus_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
           
        }

        public void FillWaitingPatients()
        {
            
        }
        public async Task<string> DeletePredictiveText(string text)
        {
            var temp = await DisplayActionSheet("Are you sure you want to delete " + text, "Cancel", null, "Yes");

            return temp;

        }

        public async void ShowDatabaseErrorMessage(string ErrorMessage)
        {
        }

        public async void ShowFTPErrorMessage(string ErrorMessage)
        {
        }

        private void WaitingsGridView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {

        }

        private void SecretaryVisitsGridView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {

        }


    }
}
