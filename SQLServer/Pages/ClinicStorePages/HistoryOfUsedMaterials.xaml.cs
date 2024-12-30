using EClinicMaui.SQLServer.Database;
using EClinicMaui.SQLServer.Models;
using EClinicMaui.GeneralServices;
using System.Collections.ObjectModel;


namespace EClinicMaui.SQLServer.Pages.ClinicStorePages
{

    public partial class HistoryOfUsedMaterials : ContentPage
    {

        private int PageOffset = 0;
        private readonly long MaterialId;

        private string Unit;
        private readonly List<long> DoctorsId = new List<long>();
        private bool ShowDoctorName;
        private string MaterialName;
        ObservableCollection<HistoryOfUsedMaterialsModel> GridItems = new ObservableCollection<HistoryOfUsedMaterialsModel>();
        bool InFilling = false;
        bool ScrollReachEnd = false;
        public HistoryOfUsedMaterials(long MaterialId)
        {
            InitializeComponent();
          

        }

        bool isAppeared = false;
        protected override async void OnAppearing()
        {
          
            base.OnAppearing();
        }

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            FillGrid(0);
        }

        private void WhichItemsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecificDateFrame.IsVisible = TableShowOptions.SelectedIndex >= 1;
            FillGrid(0);
        }
        private void Date_DateSelected(object sender, DateChangedEventArgs e)
        {
            FillGrid(0);
        }
        private void UsedMaterialsGrid_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            try
            {
                var totalItems = UsedMaterialsGrid.ItemsSource.Cast<object>().Count();
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
        private async void FillGrid(int Offset)
        {


        }


        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
        }



    }
}