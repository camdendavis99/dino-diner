﻿using System;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        public void EntreeSelected(object sender, RoutedEventArgs args)
        {
            Button button = (Button)sender;
            string entree = (string)button.Tag;

            CustomizeCombo comboScreen = new CustomizeCombo();
            comboScreen.EntreeSelected(entree);
            NavigationService.Navigate(comboScreen);
        }
    }
}
