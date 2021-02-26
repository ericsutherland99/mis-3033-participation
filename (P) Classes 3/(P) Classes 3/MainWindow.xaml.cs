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

namespace _P__Classes_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
            bool gooddata = true;
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(txtcity.Text) == true)
            {
                gooddata = false;
                errors.Add("City");
                //MessageBox.Show("You must enter a valid city");
            }
            if (string.IsNullOrWhiteSpace(txtfirstname.Text) == true)
            {
                gooddata = false;
                errors.Add("First Name");
                //MessageBox.Show("You must enter a valid first name");
            }
            if (string.IsNullOrWhiteSpace(txtlastname.Text) == true)
            {
                gooddata = false;
                errors.Add("Last Name");
                //MessageBox.Show("You must eneter a valid first name");
            }
            double gpa;
            if (double.TryParse(txtGPA.Text, out gpa) == false)
            {
                gooddata = false;
                errors.Add("GPA");
                //MessageBox.Show("You must enter a valid GPA");
            }
            if (string.IsNullOrWhiteSpace(txtmajor.Text) == true)
            {
                gooddata = false;
                errors.Add("Major");
                //MessageBox.Show("You must enter a valid major");
            }
            if (string.IsNullOrWhiteSpace(txtstreetname.Text) == true)
            {
                gooddata = false;
                errors.Add("Street Name");
                //MessageBox.Show("Please enter a valid street name");
            }
            int streetnumber, zipcode;
            if (int.TryParse(txtstreetnumber.Text, out streetnumber) == false)
            {
                gooddata = false;
                errors.Add("Street Number");
                //MessageBox.Show("You must enter a valid street number");
            }
            if (int.TryParse(txtzip.Text, out zipcode) == false)
            {
                gooddata = false;
                errors.Add("ZipCode");
                //MessageBox.Show("You must enter a valid zip code");
            }
            if (string.IsNullOrWhiteSpace(txtstate.Text) == true)
            {
                gooddata = false;
                errors.Add("State");
                //MessageBox.Show("You must enter a valid state");
            }
            if (gooddata == false)
            {
                string total = string.Empty;
                foreach (string category in errors)
                {
                    total = total + "\n" + category;
                }
                MessageBox.Show($"You have issues with your inputs in the following categories: {total}");
                return;
            }

            Student newstudent = new Student()
            {
                FirstName = txtfirstname.Text,
                LastName = txtlastname.Text,
                Major = txtmajor.Text,
                GPA = gpa

            };

            newstudent.SetAddress(streetnumber, txtstreetname.Text, txtstate.Text, txtcity.Text, zipcode);

            lstgraduates.Items.Add(newstudent);

            txtcity.Clear();
            txtfirstname.Clear();
            txtGPA.Clear();
            txtlastname.Clear();
            txtmajor.Clear();
            txtstate.Clear();
            txtstreetname.Clear();
            txtstreetnumber.Clear();
            txtzip.Clear();
        }

        private void dblclick(object sender, MouseButtonEventArgs e)
        {
            MyClickBrowser student = new MyClickBrowser();
            var selectedstudent = (Student)lstgraduates.SelectedItem;
            student.student = selectedstudent;
            student.studentz(selectedstudent);
            student.ShowDialog();
            
        }
    }
}
