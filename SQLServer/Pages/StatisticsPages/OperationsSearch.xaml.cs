using EClinicMaui.SQLServer.Database;
using EClinicMaui.SQLServer.Models;
using EClinicMaui.GeneralServices;
using System.Collections.ObjectModel;


namespace EClinicMaui.SQLServer.Pages.StatisticsPages
{
    public partial class OperationsSearch : ContentPage
    {

        string[] MaritalStatusArray = { "", "Single", "Married", "Divorced", "Widower" };
        string[] MaritalStatusArrayForFemale = { "", "Single", "Married", "Divorced", "Widow" };
        string[] OpPlaces = { "My Clinic", "Private Hospital", "General Hospital", "Other place" };
        private List<long> DoctorsId = new List<long>();
        int PageOffset = 0;
        bool NeedToShowMenu = true;
        bool ScrollReachEnd = false;
        bool InFilling = false;

        ObservableCollection<GetOperationsModel> GridItems = new ObservableCollection<GetOperationsModel>();

        public OperationsSearch()
        {
            InitializeComponent();
           
        }



        bool isAppeared = false;
     
       

        private async void DetectDates_LinkClicked(object sender, EventArgs args)
        {
        
        }

        private void GetOperationsBtn_Clicked(object sender, EventArgs e)
        {
            FillGridView(0);
        }

        private async void FillGridView(int Offset)
        {

          

        }

        private async void Operations_Tab(object sender, EventArgs e)
        {
            

        }

        private void OperationsGridView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            try
            {
                var totalItems = OperationsGridView.ItemsSource.Cast<object>().Count();
                if (e.LastVisibleItemIndex >= totalItems - 1 && !ScrollReachEnd)
                {
                    ScrollReachEnd = true;
                    LoadingImg.IsVisible = true;
                    FillGridView(PageOffset + 1);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}