using EClinicMaui.SQLServer.Database;
using EClinicMaui.GeneralServices;
using EClinicMaui.SQLServer.Services;

namespace EClinicMaui.SQLServer.Pages.ExpensesPages
{
    
    public partial class AddExpense : ContentPage
    {
        private readonly long ExpenseId=0;
        private double TotalPaidCost = 0;
        public AddExpense()
        {
            InitializeComponent();
        
        }

        public AddExpense(long ExpenseId)
        {
            InitializeComponent();
 
        }


        bool isAppeared = false;
        protected override async void OnAppearing()
        {
            
            base.OnAppearing();
        }

        public async void AddExpenseBtn_Click(object sender, EventArgs e)
        {

          
        }

        public async void SaveExpenseBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExpensesTB_Completed(object sender, EventArgs e)
        {
            CostTB.Focus();
        }

        private void CostTB_Completed(object sender, EventArgs e)
        {
            PaidCostTB.Focus();
        }

        private void PaidCostTB_Completed(object sender, EventArgs e)
        {
            NotesTB.Focus();
        }
    }
}
