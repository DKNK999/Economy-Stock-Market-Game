using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Economy_Game
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_Continue_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            this.NavigationService.Navigate(game);
        }

        private void btn_NewGame_Click(object sender, RoutedEventArgs e)
        {
            NewGameSave newGameSave = new NewGameSave();
            this.NavigationService.Navigate(newGameSave);
        }

        private void btn_Options_Click(object sender, RoutedEventArgs e)
        {
            Options options = new Options();
            this.NavigationService.Navigate(options);
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
