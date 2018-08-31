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

namespace Viotech
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            // if there is account on this computer
            // show Login page
            var welcome = new welcome();
            welcome.setframe = container;
            container.Navigate(welcome);
        }

        private void windows_closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // tell the storage class to save its user to disk.
        }
    }
}
