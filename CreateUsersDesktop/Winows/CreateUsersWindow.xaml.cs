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
using CreateUsers.Classes;

namespace CreateUsersDesktop.Winows
{
    /// <summary>
    /// Логика взаимодействия для CreateUsersWindow.xaml
    /// </summary>
    public partial class CreateUsersWindow : Window
    {
        private int _countOfUsers { get; }
        private int CountOfUsers { get; set; }
        private int countOfCurrentUser;
        private List<User> users = new List<User>();

        public CreateUsersWindow(int countOfUSers)
        {
            this._countOfUsers = countOfUSers;
            this.CountOfUsers = countOfUSers;
            InitializeComponent();
            txtBlockCountOfUsers.Text = $"Пользователь {countOfCurrentUser} из {_countOfUsers}";
        }

        private void btnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtBoxUserName.Text;
            int userAge = Convert.ToInt32(txtBoxUserAge.Text);
            

            using(ApplicationContext db = new ApplicationContext())
            {
                if (CountOfUsers < 1)
                {
                    ShowAllUsersWindow showAllUsersWindow = new ShowAllUsersWindow(GetUsers());
                    showAllUsersWindow.Show();
                    this.Close();
                }
                else
                {
                    User user = new User(userName, userAge);
                    db.Users.Add(user);
                    db.SaveChanges();
                    CountOfUsers--;
                    countOfCurrentUser++;
                    txtBlockCountOfUsers.Text = $"Пользователь {countOfCurrentUser} из {_countOfUsers}";

                }
                if (countOfCurrentUser == _countOfUsers)
                {
                    btnCreateUser.Width = 355;
                    btnCreateUser.Height = 85;
                    txtBlockContentOfButton.Text = "Просмотреть всех пользователей";
                }
            }
        }
        private List<User> GetUsers()
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                users = db.Users.ToList();
                return users;
            }
        }
    }
}
