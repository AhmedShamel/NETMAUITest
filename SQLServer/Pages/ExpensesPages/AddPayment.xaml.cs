using EClinicMaui.SQLServer.Database;
using EClinicMaui.GeneralServices;
using EClinicMaui.SQLServer.Services;


namespace EClinicMaui.SQLServer.Pages.ExpensesPages
{
    
    public partial class AddPayment : ContentPage
    {
        private long ExpenseId;
        private long EditExpenseId;
        private double TotalExpenses;
        private readonly bool Edit = false;
        public AddPayment(long ExpenseId)
        {
            InitializeComponent();
         
        
        }

        public AddPayment(long ExpenseId, bool Edit)
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
