using EClinicMaui.SQLServer.Database;


namespace EClinicMaui.SQLServer.Pages.SettingsPages
{
    public partial class VisitsSettings : ContentPage
    {
        public VisitsSettings()
        {
            InitializeComponent();

           
        }



        private void SetField(object sender, EventArgs args)
        {
            var CB = ((sender as Label).Parent as StackLayout).Children[1] as Microsoft.Maui.Controls.CheckBox;
            CB.IsChecked = !CB.IsChecked;
        }


        public async void SaveVisitsSettings_Click(object sender, EventArgs e)
        {
            
        }

        private void VisitCostCB_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //CommonVisitCostTB.IsVisible = VisitCostCB.IsChecked;
        }
    }
}