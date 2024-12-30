using EClinicMaui.SQLServer.Database;
using EClinicMaui.GeneralServices;
using EClinicMaui.SQLServer.Models;
using System.Collections.ObjectModel;

namespace EClinicMaui.SQLServer.Pages.ExpensesPages
{

    public partial class ExpensesPage : ContentPage
    {
        bool NeedToShowMenu = true;
        int PageOffset = 0;

        int DoctorsCount = 0;
        //bool InFilling = false;
        bool IsAppeared = false;
        bool ScrollReachEnd = false;
        private readonly List<long> DoctorsId = new List<long>();
        ObservableCollection<ExpensesModel> GridItems = new ObservableCollection<ExpensesModel>();
        public ExpensesPage()
        {
            InitializeComponent();
       

        }

        protected override async void OnAppearing()
        {
      

        }

        private async void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            NeedToShowMenu = false;

        }

      

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            FillGrid(0);
        }

        private void TableShowOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromDateFrame.IsVisible = ToDateFrame.IsVisible = (TableShowOptions.SelectedIndex == 1 || TableShowOptions.SelectedIndex == 3);
            FillGrid(0);
        }

        private void ExpensesGrid_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            try
            {
                var totalItems = ExpensesGrid.ItemsSource.Cast<object>().Count();
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