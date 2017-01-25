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
    /// Interaction logic for UC_RegistrationConfirm.xaml
    /// </summary>
    public partial class UC_RegistrationConfirm : UserControl
    {
        public event EventHandler ConfirmClicked;

        public UC_RegistrationConfirm()
        {
            InitializeComponent();
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            text_Info.FontSize = e.NewSize.Height / 30;
            text_InsertCode.FontSize = e.NewSize.Height / 20;

            tb_Code.FontSize = e.NewSize.Height / 25;
            b_Confirm.FontSize = e.NewSize.Height / 25;
        }

        private void b_Confirm_Click(object sender, RoutedEventArgs e)
        {
            ConfirmClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
