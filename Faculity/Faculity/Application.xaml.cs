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
    /// Interaction logic for Application.xaml
    /// </summary>
    public partial class Application : Page
    {
        public Application()
        {
            InitializeComponent();
        }
    }
}



//public partial class ApplicationFormPage : Window
//{
//    private readonly FacultyContext _context;
//    private readonly Student _loggedInStudent;

//    public ApplicationFormPage(FacultyContext context, Student loggedInStudent)
//    {
//        InitializeComponent();
//        _context = context;
//        _loggedInStudent = loggedInStudent;
//        LoadDepartments();
//    }

//    private void LoadDepartments()
//    {
//        // Populate the ComboBox with departments from the database
//        DepartmentComboBox.ItemsSource = _context.Departments.ToList();
//    }

//    private void SubmitButton_Click(object sender, RoutedEventArgs e)
//    {
//        // Validate that a department is selected
//        if (DepartmentComboBox.SelectedItem == null)
//        {
//            MessageBox.Show("Please select a department.");
//            return;
//        }

//        // Update the student's department selection
//        var selectedDepartment = (Department)DepartmentComboBox.SelectedItem;
//        _loggedInStudent.DepId = selectedDepartment.Department_Id;

//        try
//        {
//            // Save changes to the database
//            _context.SaveChanges();
//            MessageBox.Show("Application saved successfully.");
//            Close(); // Close the application form page
//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show($"Error saving application: {ex.Message}");
//        }
//    }
//}