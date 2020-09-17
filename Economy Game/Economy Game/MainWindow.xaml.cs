using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using IniParser;
using IniParser.Model;
using IniParser.Parser;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainMenu mainMenu = new MainMenu();
            frame_MainWindow.NavigationService.Navigate(mainMenu);

            if (File.Exists(@"C:\Users\nicho\Documents\My Games\EconomyGame\Config.ini") == true)
            {

            }
            else
            {
                File.Create(@"C:\Users\nicho\Documents\My Games\EconomyGame\Config.ini");
            }

        }
    }
}

