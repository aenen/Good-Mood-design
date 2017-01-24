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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            uc_Login.RegistrationClicked += Uc_Login_RegistrationClicked;
            uc_Registration.RegistrationClicked += Uc_Registration_RegistrationClicked;
        }

        private void Uc_Registration_RegistrationClicked(object sender, EventArgs e)
        {

        }

        private void Uc_Login_RegistrationClicked(object sender, EventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation(0, 1, new TimeSpan(0, 0, 0, 0, 150));
            uc_Registration.Visibility = Visibility.Visible;
            uc_Registration.BeginAnimation(Panel.OpacityProperty, da);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            text_Title.FontSize = e.NewSize.Height / 17.5;
            pic_Avatar.Width = pic_Avatar.Height = e.NewSize.Height / 12.5;
        }
    }
}
