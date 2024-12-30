using EClinicMaui.SQLServer.Database;
using EClinicMaui.SQLServer.Models;
using EClinicMaui.GeneralServices;


namespace EClinicMaui.SQLServer.Pages.StatisticsPages
{
   
    public partial class PatientsDebts : ContentPage
    {
        int PageOffset = 0;
        bool NeedToShowMenu = true;

        public PatientsDebts()
        {
            InitializeComponent();

        
        }

        protected override void OnAppearing()
        {
            NeedToShowMenu = true;
        }

        protected override void OnDisappearing()
        {
          
            base.OnDisappearing();
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

        private void Grid_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
           
        }
    }
}