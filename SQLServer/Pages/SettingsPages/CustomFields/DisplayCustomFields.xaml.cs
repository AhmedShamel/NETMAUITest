using EClinicMaui.SQLServer.Database;
using EClinicMaui.GeneralServices;
using System.Xml.Linq;

namespace EClinicMaui.SQLServer.Pages.SettingsPages.CustomFields
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayCustomFields : ContentPage
    {
        bool NeedToShowMenu = true;
        public DisplayCustomFields()
        {
            InitializeComponent();
        }


        private async void AddCustomField_Clicked(object sender, EventArgs e)
        {

            await Application.Current.MainPage.Navigation.PushAsync(new AddCustomFields());

        }




        private async void FillCustomFieldsTable()
        {
            LoadingImg.IsVisible = true;

            CustomFieldsStack.Children.Clear();

            string CustomFields = string.Empty;


         

            ResetAllCustomFields.IsVisible = !StringServices.IsStringEmpty(CustomFields) && CustomFields != "<C></C>";


            if (!string.IsNullOrEmpty(CustomFields) && !string.IsNullOrWhiteSpace(CustomFields))
            {
                XElement XCustomFields = XElement.Parse(CustomFields);

                if (XCustomFields.Elements().Count() == 0)
                {
                    LoadingImg.IsVisible = LoadingImg2.IsVisible = false;
                    return;
                }

                int RowCount = 2;
                var ImgClickGestureRecognizer = new TapGestureRecognizer();
                ImgClickGestureRecognizer.Tapped += MoveFieldUp;


                foreach (var Field in XCustomFields.Elements())
                {
                    Label FieldName = new Label { Text = Field.Attribute("Name").Value, HorizontalOptions = LayoutOptions.StartAndExpand };

                    Button EditButton = new Button
                    {
                        BindingContext = Field.Name.LocalName,
                        FontSize = 10,
                        Text = "Edit",
                        BackgroundColor = Color.FromArgb("#D5D5D5"),
                        TextColor = Colors.Black,
                        Scale = 0.9
                    };
                    EditButton.Clicked += EditButton_Clicked;

                    Button DeleteFeildBtn = new Button
                    {
                        BindingContext = Field.Name.LocalName,
                        FontSize = 10,
                        Text = "Delete",
                        TextColor = Colors.White,
                        BackgroundColor = Colors.DarkRed,
                        Scale = 0.9
                    };
                    DeleteFeildBtn.Clicked += new EventHandler(DeleteCutomField_Click);

                    Image UpImage = new Image
                    {
                        BindingContext = Field.Name.LocalName,
                        Source = ImageSource.FromFile("uparrow.png"),
                        WidthRequest = 38,
                        HeightRequest = 38,
                        Scale = 0.9
                    };

                    UpImage.GestureRecognizers.Add(ImgClickGestureRecognizer);

                    var grid = new Grid { Padding = new Thickness(0, 0, 0, 0) };

                    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(50, GridUnitType.Absolute) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) });

                    grid.Add(FieldName, 0, 0);
                    grid.Add(EditButton, 2, 0);
                    grid.Add(DeleteFeildBtn, 3, 0);

                    if (CustomFieldsStack.Children.Count != 0)
                        grid.Add(UpImage, 1, 0);



                    Frame ContainerFram = new Frame { Content = grid, Padding = new Thickness(2, 2, 2, 2) };
                    CustomFieldsStack.Children.Add(ContainerFram);


                    //CutomFieldsTable.Controls.Add(new MetroLabel() { Name = Field.Name.LocalName + "FI", Text = Field.Attribute("Name").Value, AutoSize = true }, 0, RowCount);
                    //CutomFieldsTable.Controls.Add(Container, 1, RowCount);

                    //CutomFieldsTable.Controls.Add(EditeFeildBtn, 2, RowCount);
                    //  CutomFieldsTable.Controls.Add(DeleteFeildBtn, 3, RowCount);
                    ++RowCount;
                }

            }

            LoadingImg.IsVisible = LoadingImg2.IsVisible = false;
        }

        private async void EditButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void MoveFieldUp(object sender, EventArgs e)
        {}

        private async void DeleteCutomField_Click(object sender, EventArgs e)
        { }
        private async void RestAllCustomFields_Click(object sender, EventArgs e)
        {}

        private async void GetCustomFieldsFromOtherDoctorBtn_Clicked(object sender, EventArgs e)
        {}
    }
}