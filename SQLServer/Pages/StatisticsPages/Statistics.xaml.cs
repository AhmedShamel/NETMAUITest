using EClinicMaui.SQLServer.Database;
using EClinicMaui.GeneralServices;

namespace EClinicMaui.SQLServer.Pages.StatisticsPages
{
    
    public partial class Statistics : ContentPage
    {
        private List<long> DoctorsId = new List<long>();

        public Statistics()
        {
            InitializeComponent();
            DaysOffCount.SelectedIndex = 0;

            VisitCostStack.IsVisible = Settings.Default.NeedVisitCost;
            OperationCostStack.IsVisible = Settings.Default.NeedOperations & Settings.Default.NeedOperationCost;
            TotalCostStack.IsVisible = VisitCostStack.IsVisible & OperationCostStack.IsVisible;


            DiscountCostStack.IsVisible =
            TotalCostOfVisitsWithDiscountsStack.IsVisible = Settings.Default.NeedDiscountCost;

            TotalPaidCostStack.IsVisible = TotalRemainingCostStack.IsVisible = Settings.Default.NeedPaidCost;


           
        }
        bool IsAppeared = false;

        private void DaysOffCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<View> stacks = new List<View> { FirstDayStack, SecondDayStack, ThirdDayStack };
            stacks.All(x => x.IsVisible = false);
            for (int i = 0; i < DaysOffCount.SelectedIndex; i++)
                stacks[i].IsVisible = true;
        }

        private async void DetectDates_LinkClicked(object sender, EventArgs args)
        {
     
        }

        private async void CalculateBtn_Click(object sender, EventArgs e)
        {
            if ((FirstDayStack.IsVisible && FirstDayCombo.SelectedIndex == -1) || (SecondDayStack.IsVisible && SecondDayCombo.SelectedIndex == -1) || (ThirdDayStack.IsVisible && ThirdDayCombo.SelectedIndex == -1))
            {
                await DisplayAlert("Error", "Please specify which days off you take in the week.", "Ok");
                return;
            }

            if (DaysOffCount.SelectedIndex == 2)
            {
                if (FirstDayCombo.SelectedIndex == SecondDayCombo.SelectedIndex)
                {
                    await DisplayAlert("Error", "You selected duplicated days. Please specify unique days.", "Ok");
                    return;
                }
            }
            else if (DaysOffCount.SelectedIndex == 3)
            {
                if (FirstDayCombo.SelectedIndex == SecondDayCombo.SelectedIndex || FirstDayCombo.SelectedIndex == ThirdDayCombo.SelectedIndex || SecondDayCombo.SelectedIndex == ThirdDayCombo.SelectedIndex)
                {
                    await DisplayAlert("Error", "You selected duplicated days. Please specify unique days.", "Ok");
                    return;
                }
            }

            CalculateBtn.Text = "Please wait ..";
            CalculateBtn.IsEnabled = false;
            LoadingImg.IsVisible = true;

            CalculateStatistics();

        }

        private async void CalculateStatistics()
        {

        }

    }
}