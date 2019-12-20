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

            //  people = DataAccess.GetPeople();

            //  peopleListBox.ItemsSource = people;
            People = DataAccess.GetPeople();

            var MyProperties = new { People = People };

            this.DataContext = MyProperties;


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //View expense report
            this.DataContext = this.peopleListBox.SelectedItem;
            ExpenseReportPage expenseReportPage = new ExpenseReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(expenseReportPage);

        }


        private void Print(object sender, SelectionChangedEventArgs args)
        {
            //this.NamePreview.Content =((System.Xml.XmlNode)this.peopleListBox.SelectedItem).Attributes["Name"].Value;


            int index = this.peopleListBox.SelectedIndex;
            PersonModel SelectedPerson = People[index];
            this.NamePreview.Content = SelectedPerson.FirstName;


            //Variable.indexListBox = peopleListBox.SelectedIndex;
            
            
           
        }


        private List<PersonModel> _people;

        public List<PersonModel> People
        {
            get { return _people; }
            set { _people = value; }
        }
        public static class Variable
        {
            public static int indexListBox;
        }


    }
}