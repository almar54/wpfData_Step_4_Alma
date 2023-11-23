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
using wpfData.ServiceReferenceSnacks;

namespace wpfData
{
    /// <summary>
    /// Interaction logic for UsersUserControl.xaml
    /// </summary>
    public partial class UsersUserControl : UserControl
    {
        private ServiceSnackClient serviceSnack;
        public UsersUserControl()
        {
            InitializeComponent();
            serviceSnack = new ServiceSnackClient();
            UserList list = serviceSnack.GetAllUsers();
            usersListView.ItemsSource = list;
        }
    }
}
