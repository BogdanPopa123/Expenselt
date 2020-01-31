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
        public List<PersonModel> people;

        public ExpenseItHome()
        {
            InitializeComponent();

            //  people = DataAccess.GetPeople();

            
            People = DataAccess.GetPeople();
            peopleListBox.ItemsSource = People;
            //var MyProperties = new { People = People };

            //this.DataContext = MyProperties;


        }
        private void PeopleListBox_GetIndex(object sender, RoutedEventArgs e)
        {
            this.DataContext = this.peopleListBox.SelectedItem;
            PersonModel.IndexListBox = peopleListBox.SelectedIndex;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //View expense report
            
            ExpenseReportPage expenseReportPage = new ExpenseReportPage(this.DataContext);
            this.NavigationService.Navigate(expenseReportPage);

        }


        private void Print(object sender, SelectionChangedEventArgs args)
        {
            //this.NamePreview.Content =((System.Xml.XmlNode)this.peopleListBox.SelectedItem).Attributes["Name"].Value;


         //   int index = this.peopleListBox.SelectedIndex;
         //   PersonModel SelectedPerson = People[index];
         //   this.NamePreview.Content = SelectedPerson.FirstName;


            //Variable.indexListBox = peopleListBox.SelectedIndex;
            
            
           
        }
        private List<PersonModel> People;

/*
        private List<PersonModel> _people;

        private List<PersonModel> People;
        {
            get { return _people; }
            set { _people = value; }
        }*/

    }
}