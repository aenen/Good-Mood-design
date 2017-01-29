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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for UC_Registration.xaml
    /// </summary>
    public partial class UC_Registration : UserControl
    {
        public UC_Registration()
        {
            InitializeComponent();

            this.IsVisibleChanged += UC_Registration_IsVisibleChanged;
        }

        private void UC_Registration_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue)
                return;

            tb_ConfirmPassword.Clear();
            tb_Email.Clear();
            tb_Name.Clear();
            tb_Password.Clear();
            tb_PhoneNumber.Clear();
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            button_Enter.FontSize = e.NewSize.Height / 30;
            tb_Password.FontSize = e.NewSize.Height / 30;
            tb_PhoneNumber.FontSize = e.NewSize.Height / 30;
            tb_ConfirmPassword.FontSize = e.NewSize.Height / 30;
            tb_Email.FontSize = e.NewSize.Height / 30;
            tb_Name.FontSize = e.NewSize.Height / 30;

            text_Number.FontSize = e.NewSize.Height / 28;
            text_Password.FontSize = e.NewSize.Height / 28;
            text_ConfirmPassword.FontSize = e.NewSize.Height / 28;
            text_Email.FontSize = e.NewSize.Height / 28;
            text_Name.FontSize = e.NewSize.Height / 28;
        }
    }
}
