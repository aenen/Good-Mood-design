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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for UC_Login.xaml
    /// </summary>
    public partial class UC_Login : UserControl
    {
        public event EventHandler RegistrationClicked;
        public event EventHandler LoginClicked;

        public UC_Login()
        {
            InitializeComponent();
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            button_Enter.FontSize = e.NewSize.Height / 30;
            tb_Password.FontSize = e.NewSize.Height / 30;
            tb_PhoneNumber.FontSize = e.NewSize.Height / 30;
            text_Number.FontSize = e.NewSize.Height / 29;
            text_Password.FontSize = e.NewSize.Height / 29;
            text_Register.FontSize = e.NewSize.Height / 35;
            text_Link.FontSize = e.NewSize.Height / 35;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation(1, 0, new TimeSpan(0, 0, 0, 0, 150));
            da.Completed += new EventHandler((ob, xz) =>
            {
                panel_Login.Visibility = Visibility.Hidden;
                RegistrationClicked?.Invoke(this,EventArgs.Empty);
            });
            this.BeginAnimation(UserControl.OpacityProperty, da);
        }
    }
}
