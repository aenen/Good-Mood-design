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
        public UC_Login()
        {
            InitializeComponent();

            this.IsVisibleChanged += UC_Login_IsVisibleChanged;
        }

        private void UC_Login_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue)
                return;

            tb_Password.Clear();
            tb_PhoneNumber.Clear();
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
    }
}
