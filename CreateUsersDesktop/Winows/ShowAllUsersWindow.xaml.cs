using CreateUsers.Classes;
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

namespace CreateUsersDesktop.Winows
{
    /// <summary>
    /// Логика взаимодействия для ShowAllUsersWindow.xaml
    /// </summary>
    public partial class ShowAllUsersWindow : Window
    {
        private List<User> Users;

        public ShowAllUsersWindow(List<User> users)
        {
            this.Users = users;

            InitializeComponent();
            foreach (User user in users)
            {
                TextBlock txtBlockOfUser = new TextBlock();
                txtBlockOfUser.Margin = new Thickness(10);
                txtBlockOfUser.Text = $"{user.Name}\n{user.Age}";
                txtBlockOfUser.FontSize = 32;
                stcPanelAllUsers.Children.Add(txtBlockOfUser);
            }
        }
    }
}
