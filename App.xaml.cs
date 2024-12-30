
using EClinicMaui.SQLServer.Pages;

namespace EClinicMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Sidebar()
            {
                FlowDirection = FlowDirection.LeftToRight
            };

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
