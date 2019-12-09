using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Expenselt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Page
    {
        List<PersonModel> people;
        public ExpenseItHome()
        {
            InitializeComponent();

            //Populez lista de persone cu datele din baza de date.

            people = DataAccess.GetPeople();

            //Setez sursa de data pentru peopleListBox

            peopleListBox.ItemsSource = people;

            //Definesc membrul afisast (FirstName,LastName... )

            peopleListBox.DisplayMemberPath = "FirstName";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //View expense roport
            ExpenseReportPage expenseReportPage = new ExpenseReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(expenseReportPage);
            
        }
        
        private void Print(object sender, SelectionChangedEventArgs args) 
        {
            this.NamePreview.Content = "Selected: " + ((System.Xml.XmlNode)this.peopleListBox.SelectedItem).Attributes["Name"].Value;
        }
    }

        
    
}
