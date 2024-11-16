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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {

        private facultyEntities _context;
        public LogIn(facultyEntities context)
        {
            InitializeComponent();
            _context = context;
        }

        private void LoginBTN_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTXT.Text;
            string password = pwTXT.Text;

            var user = _context.Students.SingleOrDefault(x => x.Email == email && x.Passwords == password);

            if (user != null)
            {
                if (user.Email == "admin@example.com") // Hard-coded admin account
                {
                    var adminPage = new Admin(_context);
                    adminPage.Show();
                }
                else
                {
                    var applicationFormPage = new Application(_context, user);
                    applicationFormPage.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Incorrect email or password.");
            }
        }

        private void SignupBTN_Click(object sender, RoutedEventArgs e)
        {
            var signUpPage = new SignUP(_context);
            signUpPage.Show();
           

        }
    }
}





