using EClinicMaui.SQLServer.Database;
using EClinicMaui.SQLServer.Models;
using EClinicMaui.GeneralServices;
using System.Collections.ObjectModel;

namespace EClinicMaui.SQLServer.Pages.StatisticsPages
{

    public partial class VisitsSearch : ContentPage
    {

        bool NeedToShowMenu = true;
        private List<long> DoctorsId = new List<long>();
        int PageOffset = 0;
        ObservableCollection<GetVisitsModel> GridItems = new ObservableCollection<GetVisitsModel>();
        bool InFilling = false;
        bool ScrollReachEnd = false;
        public VisitsSearch()
        {
            InitializeComponent();
           
        }

        bool isAppeared = false;
        private async void DetectDates_LinkClicked(object sender, EventArgs args)
        {
           
        }

        private void GetVisitsBtn_Clicked(object sender, EventArgs e)
        {
            FillGridView(0);
        }

        private async void FillGridView(int Offset)
        {

        }

        private async void Visits_Tab(object sender, EventArgs e)
        {


        }

        private void VisitsGridView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            try
            {
                var totalItems = VisitsGridView.ItemsSource.Cast<object>().Count();
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