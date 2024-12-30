using EClinicMaui.SQLServer.Database;
using EClinicMaui.SQLServer.Models;
using EClinicMaui.GeneralServices;


namespace EClinicMaui.SQLServer.Pages.ExpensesPages
{
    public partial class ExpenseDetials : ContentPage
    {
        private readonly long ExpenseId;
        private double TotalExpenses;

        public ExpenseDetials(long ExpenseId)
        {
            InitializeComponent();
          


        }


        bool IsAppeared = false;
        protected override async void OnAppearing()
        {
           

            base.OnAppearing();
        }


        private async void AddExpenseBtn_Click(object sender, EventArgs e)
        {
          
        }


        public async void FillGrid()
        {

        
        }


        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           
            
        }
    }
}