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
    /// Interaction logic for userInputs.xaml
    /// </summary>
    public partial class userInputs : Page
    {
        public userInputs()
        {
            InitializeComponent();
        }

        private void sign_in_btn_click(object sender, RoutedEventArgs e)
        {
            // get user the user data, hash the password
            // save it in the filesystem
        }

        private void btn_close_clicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
