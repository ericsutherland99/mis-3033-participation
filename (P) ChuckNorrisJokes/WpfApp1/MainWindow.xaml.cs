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

namespace WpfApp1
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

            Chuck_Norris chuck_;
            string url = "https://api.chucknorris.io/jokes/categories";
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                chuck_ = JsonConvert.DeserializeObject<Chuck_Norris>(json);
                foreach (var item in chuck_.categories)
                {
                    cmb_category.Items.Add(item);
                }
            }
        }
    }
}
