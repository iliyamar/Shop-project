﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Configuration;

namespace Shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShopContext shopContext = new ShopContext();
            //  var a = shopContext.Products.ToList();
            
            shopContext.Database.Initialize(true);
            // Console.WriteLine(a);

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddProduct newProduct = new AddProduct();
            newProduct.Show();
        }

        private void button_ViewProducts_Click(object sender, RoutedEventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts();
            viewProducts.Show();
        }
    }
}