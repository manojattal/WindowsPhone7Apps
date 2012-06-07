using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ICICIPruLifeApp
{
    public class ViewModelPlanDetails
    {
        public Grid GetDetailsGrid()
        {
            Grid grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            TextBlock txtAgePrompt = new TextBlock() { Text = "Min. / Max Age at entry" };
            TextBlock txtMinPolicyTermPrompt = new TextBlock() { Text = "Min. Policy term" };
            TextBlock txtAgeValue = new TextBlock() { Text = "18 / 65 yrs" };
            TextBlock txtMinPolicyTermValue = new TextBlock() { Text = "5 yrs" };
            grid.Children.Add(txtAgePrompt);
            grid.Children.Add(txtMinPolicyTermPrompt);
            grid.Children.Add(txtAgeValue);
            grid.Children.Add(txtMinPolicyTermValue);
            Grid.SetColumn(txtAgeValue, 1);
            Grid.SetRow(txtMinPolicyTermPrompt, 1);
            Grid.SetRow(txtMinPolicyTermValue, 1);
            Grid.SetColumn(txtMinPolicyTermValue, 1);
            return grid;
        }
        public string PlanName { get; set; }
    }
}
