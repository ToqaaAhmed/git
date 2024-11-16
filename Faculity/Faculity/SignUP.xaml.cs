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
using Faculity;

namespace Faculity
{
    /// <summary>
    /// Interaction logic for SignUP.xaml
    /// </summary>
    public partial class SignUP : Page
    {
        public SignUP()
        {
            InitializeComponent();
        }
    }
}
//private readonly FacultyContext _context;

//public SignUpPage(FacultyContext context)
//{
//    InitializeComponent();
//    _context = context;
//    DepartmentComboBox.ItemsSource = _context.Departments.ToList();
//}

//private void SignUpButton_Click(object sender, RoutedEventArgs e)
//{
//    if (PasswordBox.Password != ConfirmPasswordBox.Password)
//    {
//        MessageBox.Show("Passwords do not match.");
//        return;
//    }

//    var newStudent = new Student
//    {
//        Name = NameTextBox.Text,
//        Password = PasswordBox.Password,
//        Email = EmailTextBox.Text,
//        Address = AddressTextBox.Text,
//        Age = int.Parse(AgeTextBox.Text),
//        DepId = ((Department)DepartmentComboBox.SelectedItem).Department_Id
//    };

//    _context.Students.Add(newStudent);
//    _context.SaveChanges();

//    MessageBox.Show("Registration successful! Please log in.");
//    var loginPage = new LoginPage(_context);
//    loginPage.Show();
//    Close();
//}