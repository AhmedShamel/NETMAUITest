using EClinicMaui.SQLServer.Database;
using EClinicMaui.GeneralServices;
using EClinicMaui.SQLServer.Services;


namespace EClinicMaui.SQLServer.Pages.ClinicStorePages
{
    public partial class AddEditMaterial : ContentPage
    {
        private readonly long MaterialId = 0;

        public AddEditMaterial()
        {
            InitializeComponent();
        
        }

        public AddEditMaterial(long MaterialId)
        {
            InitializeComponent();
   
        }

        bool isAppeared = false;
        protected override async void OnAppearing()
        {
            

            base.OnAppearing();
        }

        private void HasExpiryDateCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExpiryDateFrame.IsVisible = HasExpiryDateCB.SelectedIndex == 1;
        }


        public async void AddMaterialBtn_Click(object sender, EventArgs e)
        {


        }

        public async void SaveMaterialBtn_Click(object sender, EventArgs e)
        {

          
        }


        private void MaterialTB_Completed(object sender, EventArgs e)
        {
            QuantityTB.Focus();
        }

        private void QuantityTB_Completed(object sender, EventArgs e)
        {
            UnitTB.Focus();
        }

        private void UnitTB_Completed(object sender, EventArgs e)
        {
            SingleItemCostTB.Focus();
        }

        private void SingleItemCostTB_Completed(object sender, EventArgs e)
        {
            HasExpiryDateCB.Focus();
        }


    }
}
