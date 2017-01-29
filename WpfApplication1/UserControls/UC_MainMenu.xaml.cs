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
    /// Interaction logic for UC_MainMenu.xaml
    /// </summary>
    public partial class UC_MainMenu : UserControl
    {
        public UC_MainMenu()
        {
            InitializeComponent();
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            b_Receive.FontSize = e.NewSize.Height / 20;
            b_Send.FontSize = e.NewSize.Height / 20;

            b_Receive.Margin = new Thickness(e.NewSize.Height / 10);
            b_Send.Margin = new Thickness(e.NewSize.Height / 10);
        }
    }
}
