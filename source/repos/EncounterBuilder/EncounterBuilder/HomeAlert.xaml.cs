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
using System.Windows.Shapes;

namespace EncounterBuilder
{
    /// <summary>
    /// Interaction logic for HomeAlert.xaml
    /// </summary>
    public partial class HomeAlert : Window
    {
        Window win = null;
        public HomeAlert() {
            //this.win = win;
            InitializeComponent();
        }// end homealert window constructor

        private void LeaveWithoutSaving_Click(object sender, RoutedEventArgs e)
        {
           
        }// end leave without saving click

        private void Cancel_Click(object sender, RoutedEventArgs e) {
            Close();
        }// cancel click

        private void SaveAndExit_Click(object sender, RoutedEventArgs e) {
            // some call to the save method then close self and parent
        }// end save and exit click


    }// end HomeAlert


} // end namespace
