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
using CreateUsersDesktop.Winows;

namespace CreateUsersDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateUsers_Click(object sender, RoutedEventArgs e)
        {
            int countOfUsers = Convert.ToInt32(txtBoxCountOfUsers.Text);

            CreateUsersWindow createUsersWindow = new CreateUsersWindow(countOfUsers);
            createUsersWindow.Show();
            this.Close();
        }
    }
}