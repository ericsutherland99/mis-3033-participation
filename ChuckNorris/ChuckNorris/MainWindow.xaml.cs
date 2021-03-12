using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;

namespace ChuckNorris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            populatecategorycombobox();
        }

        private void populatecategorycombobox()
        {
            cmb_category.Items.Add("All");
            cmb_category.SelectedIndex = 0;

            //Chuck fill;
            string url = "https://api.chucknorris.io/jokes/categories";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                string[] categories = JsonConvert.DeserializeObject<string[]>(json);
                foreach(string category in categories)
                {
                    cmb_category.Items.Add(category);
                }
            }
        }
    }
}
