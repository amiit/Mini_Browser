﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace MiniBrowser
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string site = textBox1.Text;
            if (site == "please enter text to search")
                textBox1.Text = "";
            if (site.Length == 0)
            {
                textBox1.Text = "please enter text to search";
                return;
            }
            else
            {
                site = "http://www.google.com/search?q=" + textBox1.Text;
                webBrowser1.Navigate(new Uri(site, UriKind.Absolute));
             }

        }
    }
}