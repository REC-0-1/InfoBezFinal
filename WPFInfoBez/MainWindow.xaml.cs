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

namespace WPFInfoBez
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ContentC.Content = new AffinCaesarVM();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ContentC.Content = new CyclicGenerationSsessionKeyTwoVM();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ContentC.Content = new EuclidsAlgorithmVM();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ContentC.Content = new SundaramSieveVM();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ContentC.Content = new DiffieHellmanProtocolVM();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ContentC.Content = new Bitwise();
        }
    }
}
