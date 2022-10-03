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

namespace EncounterBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }

        private void CreateEncounter_Click(object sender, RoutedEventArgs e) {
            new CreateEncounter().Show();
            
            
            Close();
        }// end create encounter click

        private void CreateCharacter_Click(object sender, RoutedEventArgs e) {
            new CreateCharacter().Show();
            Close();
        }// end create char click

        private void ViewEncounters_Click(object sender, RoutedEventArgs e) {
            // new ViewEncounters().Show();
            Close();
        }// end view encounter click

        private void ViewCharacters_Click(object sender, RoutedEventArgs e) {
            // new ViewCharacters().Show();
            Close();
        }// end view char clikc
    }
}
