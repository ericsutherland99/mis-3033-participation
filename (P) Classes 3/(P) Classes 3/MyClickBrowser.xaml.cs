using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _P__Classes_3
{
    /// <summary>
    /// Interaction logic for MyClickBrowser.xaml
    /// </summary>
    public partial class MyClickBrowser : Window
    {
        public Student student { get; set; }
        public MyClickBrowser()
        {
            InitializeComponent();

            //lblstudent.Content = $"{student.FirstName} {student.LastName}, {student.Address}";
        }
        public void studentz(Student s)
        {
            lblstudent.Content = $"{student.FirstName} {student.LastName}, {student.Address}";
        }

    }
}
