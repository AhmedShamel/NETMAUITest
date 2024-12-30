using EClinicMaui.SQLServer.Database;
using EClinicMaui.SQLServer.Models;
using EClinicMaui.GeneralServices;
using EClinicMaui.SQLServer.Services;


namespace EClinicMaui.SQLServer.Pages.StatisticsPages
{
    
    public partial class ShowCostsOfAllFavoriteSearches : ContentPage
    {
        private List<CostsModel> ListOfCosts = new List<CostsModel>();
        public ShowCostsOfAllFavoriteSearches()
        {
            InitializeComponent();

       
        }

        protected override void OnDisappearing()
        {
          
            base.OnDisappearing();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private async void FillGrid()
        {


        }

        private double CheckScaller(double Number, double? ScalerNumber, string ScalerOperater)
        {
            if (ScalerNumber != null && !StringServices.IsStringEmpty(ScalerOperater))
            {
                switch (ScalerOperater)
                {
                    case "+":
                        Number += ScalerNumber.Value;
                        break;

                    case "-":
                        Number -= ScalerNumber.Value;
                        break;

                    case "*":
                        Number *= ScalerNumber.Value;
                        break;

                    case "/":
                        Number /= ScalerNumber.Value;
                        break;
                }
            }

            return Number;

        }

    }
}