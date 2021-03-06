﻿using System;
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

namespace _P_Json
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool front = true;
        public MainWindow()
        {
            InitializeComponent();

            AllPokemonAPI api;
            string url = "https://pokeapi.co/api/v2/pokemon?limit=1200";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllPokemonAPI>(json);

            }

            foreach (var item in api.results.OrderBy(x => x.name).ToList())
            {
                lstPokemon.Items.Add(item);
            }
        }

        private void lstPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selecteditem = (resultobject)lstPokemon.SelectedItem;
            ClickPokemon click;
            string url2 = selecteditem.url;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url2).Result;
                click = JsonConvert.DeserializeObject<ClickPokemon>(json);

                //lblheight.Content = click.height;
                //lblweight.Content = click.weight;
                //imgpokemon.Source = new BitmapImage(new Uri(click.sprites.front_default));
            }
            lblheight.Content = click.height;
            lblweight.Content = click.weight;
            imgpokemon.Source = new BitmapImage(new Uri(click.sprites.front_default));



        }

        private void btnswitch_Click(object sender, RoutedEventArgs e)
        {
            var selecteditem = (resultobject)lstPokemon.SelectedItem;
            ClickPokemon click;
            string url2 = selecteditem.url;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url2).Result;
                click = JsonConvert.DeserializeObject<ClickPokemon>(json);

                if (click.sprites.back_default is null)
                {
                    return;
                }
                if (front)
                {
                    imgpokemon.Source = new BitmapImage(new Uri(click.sprites.back_default));
                    front = false;
                }
                else
                {
                    imgpokemon.Source = new BitmapImage(new Uri(click.sprites.front_default));
                    front = true;
                }

            }
            
        }

    }
}
