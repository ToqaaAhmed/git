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

namespace Faculity
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();
        }
    }
}

  //private readonly FacultyContext _context;

  //  public AdminPage(FacultyContext context)
  //  {
  //      InitializeComponent();
  //      _context = context;
  //      LoadData();
  //  }

  //  private void LoadData()
  //  {
  //      StudentsDataGrid.ItemsSource = _context.Students
  //          .Select(s => new { s.ID, s.Name, s.Address, Department = s.Department.Name })
  //          .ToList();
  //  }

  //  private void SearchButton_Click(object sender, RoutedEventArgs e)
  //  {
  //      string search = SearchTextBox.Text;
  //      StudentsDataGrid.ItemsSource = _context.Students
  //          .Where(s => s.Name.Contains(search) || s.Department.Name.Contains(search))
  //          .Select(s => new { s.ID, s.Name, s.Address, Department = s.Department.Name })
  //          .ToList();
  //  }

  //  private void DeleteButton_Click(object sender, RoutedEventArgs e)
  //  {
  //      // Implement delete logic here
  //  }

  //  private void UpdateButton_Click(object sender, RoutedEventArgs e)
  //  {
  //      // Implement update logic here
  //  }