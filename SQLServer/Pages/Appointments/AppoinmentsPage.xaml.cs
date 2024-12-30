using EClinicMaui.SQLServer.Models;
using EClinicMaui.GeneralServices;
using System.Collections.ObjectModel;

namespace EClinicMaui.SQLServer.Pages.Appointments
{

    public partial class AppoinmentsPage : ContentPage
    {
        bool NeedToShowMenu = true;
        int PageOffset = 0;
        private List<long> DoctorsId = new List<long>();
        private long? SecretaryForDoctorId;
        ObservableCollection<SearchInAppointmentsModel> GridItems = new ObservableCollection<SearchInAppointmentsModel>();

        bool ScrollReachEnd = false;
        public AppoinmentsPage()
        {
            InitializeComponent();
        }

        private void SearchByCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            FillGrid(0);
        }



        private void Date_DateSelected(object sender, DateChangedEventArgs e)
        {
            FillGrid(0);
        }

        private void TableShowOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid(0);
        }


        private void AppointmentsGrid_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            try
            {
                var totalItems = AppointmentsGrid.ItemsSource.Cast<object>().Count();
                if (e.LastVisibleItemIndex >= totalItems - 1 && !ScrollReachEnd)
                {
                    ScrollReachEnd = true;
                    LoadingFooterImg.IsVisible = true;
                    FillGrid(PageOffset + 1);
                }
            }
            catch (Exception ex)
            {

            }

        }

        public async void FillGrid(int Offset)
        {



        }


        private async void OnTap(object sender, EventArgs e)
        {
        
        }

    }
}