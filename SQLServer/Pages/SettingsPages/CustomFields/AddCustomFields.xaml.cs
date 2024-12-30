using EClinicMaui.SQLServer.Database;
using EClinicMaui.GeneralServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;


namespace EClinicMaui.SQLServer.Pages.SettingsPages.CustomFields
{

    public partial class AddCustomFields : ContentPage
    {
        private string FieldNameToBePassed = null;
        public AddCustomFields()
        {
            InitializeComponent();

        }


        public AddCustomFields(string FieldName)
        {
            InitializeComponent();



        }


        bool isAppeared = false;
        private async void CancelBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void NoResultsCB_SelectedIndexChanged(object sender, EventArgs e)
       {}

        private void ResultTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuItemsFrame.IsVisible = ResultTypeCB.SelectedIndex == 4;
        }

        private void SubFieldType_Changed(object sender, EventArgs e)
        {
            var picker = (sender as Picker);
            ((picker.Parent.Parent as StackLayout).Children[2] as View).IsVisible = picker.SelectedIndex == 3;
        }


        private async void SaveCutomField_Click(object sender, EventArgs e)
       {}

        private async void SaveMultiCutomField()
        {}

    }
}