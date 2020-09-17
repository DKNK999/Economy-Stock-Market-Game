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
    /// Interaction logic for NewGameSave.xaml
    /// </summary>
    public partial class NewGameSave : Page
    {
        public NewGameSave()
        {
            InitializeComponent();
        }

        private void btn_NewGame_Back_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.NavigationService.Navigate(mainMenu);
        }

    }
}

