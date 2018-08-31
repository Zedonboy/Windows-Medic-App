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

namespace Viotech
{
    /// <summary>
    /// Interaction logic for welcome.xaml
    /// </summary>
    public partial class welcome : Page
    {
        private Frame _frame;

        public welcome()
        {
            InitializeComponent();
        }

        private void doctor_btn_click(object sender, RoutedEventArgs e)
        {
            _frame.Navigate(new Dashboard());
        }

        public Frame setframe
        {
            set
            {
                this._frame = value;
            }
        }
    }
}
