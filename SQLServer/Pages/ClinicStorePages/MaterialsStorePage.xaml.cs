using EClinicMaui.SQLServer.Database;
using EClinicMaui.SQLServer.Models;
using EClinicMaui.GeneralServices;
using System.Collections.ObjectModel;


namespace EClinicMaui.SQLServer.Pages.ClinicStorePages
{

    public partial class MaterialsStorePage : ContentPage
    {
        bool NeedToShowMenu = true;
        int PageOffset = 0;
        //bool InFilling = false;
        bool ScrollReachEnd = false;
        ObservableCollection<MaterialsStoreModel> GridItems = new ObservableCollection<MaterialsStoreModel>();
        public MaterialsStorePage()
        {
            InitializeComponent();
         

        }


        bool isAppeared = false;
        protected override void OnAppearing()
        {
           

            base.OnAppearing();
        }

        private async void AddExpenseBtn_Click(object sender, EventArgs e)
        {
          
        }


      
        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            FillGrid(0);
        }

        private void WhichItemsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExpiredInSpecificDateFrame.IsVisible = WhichItemsCB.SelectedIndex == 7;
            FillGrid(0);
        }

        private void StoreGrid_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            try
            {
                var totalItems = StoreGrid.ItemsSource.Cast<object>().Count();
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

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           
        }

        private void Date_DateSelected(object sender, DateChangedEventArgs e)
        {
            FillGrid(0);
        }

    }
}