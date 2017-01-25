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
    /// Interaction logic for UC_RegistrationSteps.xaml
    /// </summary>
    public partial class UC_RegistrationSteps : UserControl
    {
        public UC_RegistrationSteps()
        {
            InitializeComponent();
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            text_Confirm.FontSize = e.NewSize.Height / 3.5;
            text_Register.FontSize = e.NewSize.Height / 3.5;

            arrow.ArrowSize = e.NewSize.Height / 3.5;

            border_Register.Padding = new Thickness(e.NewSize.Height / 5);
            border_Confirm.Padding = new Thickness(e.NewSize.Height / 5);
        }

        public void StepConfirm()
        {
            border_Register.Opacity = 0.5;
            border_Register.Background = Brushes.Green;
            text_Register.FontWeight = FontWeights.Black;
            text_Register.Foreground = Brushes.White;

            border_Confirm.BorderBrush = Brushes.Black;
            text_Confirm.Opacity = 1;
        }
    }
}
