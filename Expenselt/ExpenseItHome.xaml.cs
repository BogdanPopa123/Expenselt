using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        private List<PersonModel> people;
        public ExpenseItHome()
        {
            InitializeComponent();

            //populez lista de pers cu baza de date

            people = DataAccess.GetPeople();

            peopleListBox.ItemsSource = people;

            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //View expense roport
            this.DataContext = this.peopleListBox.SelectedItem;
            ExpenseReportPage expenseReportPage = new ExpenseReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(expenseReportPage);
            
        }
       

        private void Print(object sender, SelectionChangedEventArgs args)
        {
      //      this.NamePreview.Content =((System.Xml.XmlNode)this.peopleListBox.SelectedItem).Attributes["Name"].Value;
        }
    }



}