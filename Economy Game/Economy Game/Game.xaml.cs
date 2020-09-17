using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        public Game()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User() { ID = 1, Name = "John Doe", Location = "your moms" });
            users.Add(new User() { ID = 2, Name = "Jane Doe", Location = "your moms" });
            users.Add(new User() { ID = 3, Name = "Sammy Doe",Location = "your moms" });


            dg_OwnedProperties.ItemsSource = users;

        }
    }

    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }
    }
}
