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
        List<Control> visibleUC = new List<Control>();
        Panel visiblePanel;
        GoBack goBack = GoBack.nonono;

        public MainWindow()
        {
            InitializeComponent();

            uc_Login.hyperlink.Click += Uc_Login_RegistrationClicked;
            uc_Registration.button_Enter.Click += Uc_Registration_RegistrationClicked;
            uc_RegistrationConfirm.b_Confirm.Click += Uc_RegistrationConfirm_ConfirmClicked;

            visibleUC.Add(uc_Login);
        }

        // UC_RegistrationConfirm - нажата кнопка "Подтвердить"
        private void Uc_RegistrationConfirm_ConfirmClicked(object sender, EventArgs e)
        {

        }

        // UC_Registration - нажата кнопка "Зарегистрироваться"
        private void Uc_Registration_RegistrationClicked(object sender, EventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation(1, 0, new TimeSpan(0, 0, 0, 0, 150));
            da.FillBehavior = FillBehavior.Stop;

            da.Completed += (aa, bb) =>
            {
                uc_Registration.Opacity = 0;
                uc_Registration.Visibility = Visibility.Hidden;

                uc_RegistrationSteps.StepConfirm();
                VisibilityAnimation(uc_RegistrationConfirm, 1, 150);
            };

            uc_Registration.BeginAnimation(UserControl.OpacityProperty, da);
        }

        // UC_Login - нажата гиперссылка "Зарегистрируйся!"
        private void Uc_Login_RegistrationClicked(object sender, EventArgs e)
        {
            VisibilityAnimation(uc_Login, 0, 150);

            uc_RegistrationConfirm.Visibility = Visibility.Hidden;
            uc_Registration.Visibility = Visibility.Visible;
            uc_Registration.Opacity = 1;
            uc_RegistrationSteps.StepFirst();

            VisibilityAnimation(panel_Registration, 1, 150);
            VisibilityAnimation(to_Back, 1, 150);

            visibleUC.Clear();
            visiblePanel = panel_Registration;
            text_Title.Text = "Регистрация";
            goBack = GoBack.ToLogin;
        }

        //адаптация к размеру окна
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            text_Title.FontSize = e.NewSize.Height / 17.5;
            pic_Avatar.Width = pic_Avatar.Height = e.NewSize.Height / 12.5;
            to_Back.Width = to_Back.Height = e.NewSize.Height / 12.5;
            uc_RegistrationSteps.Height = e.NewSize.Height / 10;
        }

        private void to_Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (goBack)
            {
                case GoBack.ToLogin:
                    foreach (var item in visibleUC)
                    {
                        item.Opacity = 0;
                        item.Visibility = Visibility.Hidden;
                    }

                    if (visiblePanel != null)
                    {
                        visiblePanel.Opacity = 0;
                        visiblePanel.Visibility = Visibility.Hidden;
                        visiblePanel = null;
                    }

                    VisibilityAnimation(to_Back, 0, 150);
                    VisibilityAnimation(uc_Login, 1, 150);

                    visibleUC.Clear();
                    text_Title.Text = "Логин";
                    goBack = GoBack.nonono;
                    break;
                case GoBack.nonono:
                    //visibleUC.Clear();
                    break;
                default:
                    break;
            }
        }

        #region Animation
        void VisibilityAnimation(Control control, double to, int durationMsec)
        {
            DoubleAnimation da = new DoubleAnimation(to, new TimeSpan(0, 0, 0, 0, durationMsec));
            da.FillBehavior = FillBehavior.Stop;
            da.Completed += (sender, e) => control.Opacity=to;
            if (to != 0)
                control.Visibility = Visibility.Visible;
            else
                da.Completed += (sender, e) => control.Visibility = Visibility.Hidden;

            control.BeginAnimation(Control.OpacityProperty, da);
        }
        void VisibilityAnimation(Panel panel, double to, int durationMsec)
        {
            DoubleAnimation da = new DoubleAnimation(to, new TimeSpan(0, 0, 0, 0, durationMsec));
            da.FillBehavior = FillBehavior.Stop;
            da.Completed += (sender, e) => panel.Opacity=to;
            if (to != 0)
                panel.Visibility = Visibility.Visible;
            else
                da.Completed += (sender, e) => panel.Visibility = Visibility.Hidden;

            panel.BeginAnimation(Panel.OpacityProperty, da);
        }
        void VisibilityAnimation(UserControl userControl, double to, int durationMsec)
        {
            DoubleAnimation da = new DoubleAnimation(to, new TimeSpan(0, 0, 0, 0, durationMsec));
            da.FillBehavior = FillBehavior.Stop;
            da.Completed += (sender, e) => userControl.Opacity=to;
            if (to != 0)
                userControl.Visibility = Visibility.Visible;
            else
                da.Completed += (sender, e) => userControl.Visibility = Visibility.Hidden;

            userControl.BeginAnimation(UserControl.OpacityProperty, da);
        }
        void VisibilityAnimation(Shape shape, double to, int durationMsec)
        {
            DoubleAnimation da = new DoubleAnimation(to, new TimeSpan(0, 0, 0, 0, durationMsec));
            da.FillBehavior = FillBehavior.Stop;
            da.Completed += (sender, e) => shape.Opacity = to;
            if (to != 0)
                shape.Visibility = Visibility.Visible;
            else
                da.Completed += (sender, e) => shape.Visibility = Visibility.Hidden;

            shape.BeginAnimation(UserControl.OpacityProperty, da);
        }
        #endregion

    }

    public enum GoBack
    {
        ToLogin,
        nonono
    }
}
