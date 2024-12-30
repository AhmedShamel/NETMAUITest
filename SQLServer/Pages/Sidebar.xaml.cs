namespace EClinicMaui.SQLServer.Pages;

public partial class Sidebar : FlyoutPage
{
    public MyDevice myDevice;
    public Sidebar()
    {
        InitializeComponent();
        Detail = new NavigationPage(new MainPage());
    }


    public void ShowFlyout()
    {
        IsPresented = true;
    }

    public void HideFlyout()
    {
        IsPresented = false;
    }
    public void SetPermssions()
    {
        
    }

    private async void GoToApplicationSettingsPage(object sender, TappedEventArgs e)
    {
       
        await Detail.Navigation.PushAsync(new SQLServer.Pages.SettingsPages.ApplicationSetting());
        IsPresented = false;
    }

    private async void GoToHxSettingsPage(object sender, TappedEventArgs e)
    {
        await Detail.Navigation.PushAsync(new SQLServer.Pages.SettingsPages.MedicalHistorySettings(), true);
        IsPresented = false;
    }

    private async void GoToVisitsSettingsPage(object sender, TappedEventArgs e)
    {
        await Detail.Navigation.PushAsync(new SQLServer.Pages.SettingsPages.VisitsSettings(), true);
        IsPresented = false;
    }

    private async void GoToOperationsSettingsPage(object sender, TappedEventArgs e)
    {
        await Detail.Navigation.PushAsync(new SQLServer.Pages.SettingsPages.OperationsSettings(), true);
        IsPresented = false;
    }

    private async void GoToVisitsSerachPage(object sender, TappedEventArgs e)
    {
        await Detail.Navigation.PushAsync(new SQLServer.Pages.StatisticsPages.VisitsSearch(), true);
        IsPresented = false;
    }

    private async void GoToOperationsSearchPage(object sender, TappedEventArgs e)
    {
        await Detail.Navigation.PushAsync(new SQLServer.Pages.StatisticsPages.OperationsSearch(), true);
        IsPresented = false;
    }

    private async void GoToExpenses(object sender, TappedEventArgs e)
    {
        await Detail.Navigation.PushAsync(new SQLServer.Pages.ExpensesPages.ExpensesPage(), true);
        IsPresented = false;

    }

    private async void GoToMaterialsStorePage(object sender, TappedEventArgs e)
    {
        await Detail.Navigation.PushAsync(new SQLServer.Pages.ClinicStorePages.MaterialsStorePage(), true);
        IsPresented = false;
    }

    private async void GoToSearchInPatientsDebts(object sender, TappedEventArgs e)
    {
        await Detail.Navigation.PushAsync(new SQLServer.Pages.StatisticsPages.PatientsDebts(), true);
        IsPresented = false;
    }

    private async void GoToAppoinments(object sender, TappedEventArgs e)
    {
        await Detail.Navigation.PushAsync(new SQLServer.Pages.Appointments.AppoinmentsPage(), true);
        IsPresented = false;
    }

    private async void GoToStatisticsPage(object sender, TappedEventArgs e)
    {
        await Detail.Navigation.PushAsync(new SQLServer.Pages.StatisticsPages.Statistics(), true);
        IsPresented = false;
    }

    private async void GoToStatisticscostsOfFavoritesSearches(object sender, TappedEventArgs e)
    {
        await Detail.Navigation.PushAsync(new SQLServer.Pages.StatisticsPages.ShowCostsOfAllFavoriteSearches(), true);
        IsPresented = false;
    }

    private async void GoToCustomFieldsPage(object sender, TappedEventArgs e)
    {
        await Detail.Navigation.PushAsync(new SQLServer.Pages.SettingsPages.CustomFields.DisplayCustomFields(), true);
        IsPresented = false;
    }

    private async void GoToAboutPage(object sender, TappedEventArgs e)
    {
        
    }

    private void GoToLoginPage(object sender, TappedEventArgs e)
    {
        if (Detail is NavigationPage navigationPage && navigationPage.CurrentPage is MainPage mainPage)
        {
          //  navigationPage.Navigation.NavigationStack.OfType<MainPage>().First().Logout();           
        }
    }

}