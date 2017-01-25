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
            uc_RegistrationConfirm.ConfirmClicked += Uc_RegistrationConfirm_ConfirmClicked;
        }

        // UC_RegistrationConfirm - нажата кнопка "Подтвердить"
        private void Uc_RegistrationConfirm_ConfirmClicked(object sender, EventArgs e)
        {
            // your logic here
        }

        // UC_Registration - нажата кнопка "Зарегистрироваться"
        private void Uc_Registration_RegistrationClicked(object sender, EventArgs e)
        {

            //your logic here

            DoubleAnimation da = new DoubleAnimation(1, 0, new TimeSpan(0, 0, 0, 0, 150));

            da.Completed += (aa, bb) =>
              {
                  uc_RegistrationSteps.StepConfirm();
                  DoubleAnimation da2 = new DoubleAnimation(0, 1, new TimeSpan(0, 0, 0, 0, 150));
                  uc_RegistrationConfirm.Visibility = Visibility.Visible;
                  uc_RegistrationConfirm.BeginAnimation(UserControl.OpacityProperty, da2);
              };

            uc_Registration.BeginAnimation(UserControl.OpacityProperty, da);
        }

        // UC_Login - нажата гиперссылка "Зарегистрируйся!"
        private void Uc_Login_RegistrationClicked(object sender, EventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation(0, 1, new TimeSpan(0, 0, 0, 0, 150));
            panel_Registration.Visibility = Visibility.Visible;
            panel_Registration.BeginAnimation(Panel.OpacityProperty, da);
        }



        //адаптация к размеру окна
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            text_Title.FontSize = e.NewSize.Height / 17.5;
            pic_Avatar.Width = pic_Avatar.Height = e.NewSize.Height / 12.5;
            uc_RegistrationSteps.Height = e.NewSize.Height / 10;
        }
    }
}
