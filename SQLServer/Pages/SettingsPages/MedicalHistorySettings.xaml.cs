using EClinicMaui.SQLServer.Database;


namespace EClinicMaui.SQLServer.Pages.SettingsPages
{
    public partial class MedicalHistorySettings : ContentPage
    {
        public MedicalHistorySettings()
        {
            InitializeComponent();

    
        }

       
        public async void SaveMedicalHistorySettings_Click(object sender, EventArgs e)
        {
            
        }

        private void SetField(object sender, EventArgs args)
        {
            var CB = ((sender as Label).Parent as StackLayout).Children[1] as CheckBox;
            CB.IsChecked = !CB.IsChecked;
        }

    }
}