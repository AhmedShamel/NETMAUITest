
using EClinicMaui.SQLServer.Database;


namespace EClinicMaui.SQLServer.Pages.SettingsPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OperationsSettings : ContentPage
    {

        public OperationsSettings()
        {
            InitializeComponent();
        }

       
        private void SetField(object sender, EventArgs args)
        {
            var CB = ((sender as Label).Parent as StackLayout).Children[1] as CheckBox;
            CB.IsChecked = !CB.IsChecked;
        }


        public async void SaveSettings_Click(object sender, EventArgs e)
        {
            
        }

    }
}