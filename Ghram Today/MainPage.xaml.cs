///This code by Mustsfa Jawad © 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Ghram_Today.Resources;

namespace Ghram_Today
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        private void tx_p_d_TextChanged(object sender, TextChangedEventArgs e)
        {
                    //Start tx_p_d work >>

                    if (tx_p_d.Text == "")
                    {
                        tx_p_d.Text = "1";
                        MessageBox.Show("The input is not correct!", "Error", MessageBoxButton .OKCancel );
                    }
                    tb_p_d.Text = tx_p_d.Text;
                    tx_p_d1.Text = tx_p_d.Text;
                    tx_p_d2.Text = tx_p_d.Text;
                    // Primery process 
                    double a, b, c = 0;
                    double x, y, z, s, m, t;
                    a = Convert.ToDouble(tx_p_d1.Text);
                    b = Convert.ToDouble(tx31_1.Text);
                    c = a / b;
                    tx_convert1.Text = tx_convert.Text;
                    tx_total1.Text = c.ToString();
                    x = Convert.ToDouble(tx_p_d2.Text);
                    y = Convert.ToDouble(tx31_100.Text);
                    z = Convert.ToDouble(tx1000.Text);
                    s = Convert.ToDouble(tx_convert1.Text);
                    m = x / y / z * s;
                    tx_total2.Text = m.ToString();
                    t = c + m;
                    tb_convert.Text = t.ToString();
                    // for know iraqi grham of buy
                    double a1, b1, c1, d, f, g1, t1;
                    a1 = Convert.ToDouble(tb_convert.Text);
                    b1 = Convert.ToDouble(tx_iraqi.Text);
                    c1 = Convert.ToDouble(tx_0_875.Text);
                    d = Convert.ToDouble(tx_dolar.Text);
                    f = a1 - b1;
                    g1 = c1 * d;
                    t1 = f * g1;
                    tb_iqB.Text = t1.ToString();
                    // for know Ghalegi grham of buy
                    double a2, b2, c2, d2, f2, g2, t2;
                    a2 = Convert.ToDouble(tb_convert.Text);
                    b2 = Convert.ToDouble(tx_ghalegi.Text);
                    c2 = Convert.ToDouble(tx_0_875.Text);
                    d2 = Convert.ToDouble(tx_dolar.Text);
                    f2 = a2 - b2;
                    g2 = c2 * d2;
                    t2 = f2 * g2;
                    tb_ghB.Text = t2.ToString();
                    // for know Ghalegi grham of sale (with cost)
                    double a3, b3, c3, d3, f3, g3, h3;
                    a3 = Convert.ToDouble(tb_convert.Text);
                    b3 = Convert.ToDouble(tx_cost.Text);
                    c3 = Convert.ToDouble(tx_0_88.Text);
                    d3 = Convert.ToDouble(tx_dolar.Text);
                    f3 = a3 * c3;
                    g3 = f3 + b3;
                    h3 = g3 * d3;
                    tb_ghS.Text = h3.ToString();  
        }


        private void tx_convert_TextChanged(object sender, TextChangedEventArgs e)
        {
            tx_p_d1.Text = tx_p_d.Text;
            tx_p_d2.Text = tx_p_d.Text;
            tx_convert1.Text = tx_convert.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb_p_d.Text = tx_p_d.Text;
            tx_p_d1.Text = tx_p_d.Text;
            tx_p_d2.Text = tx_p_d.Text;
            // Primery process 
            double a, b, c = 0;
            double x, y, z, s, m, t;
            a = Convert.ToDouble(tx_p_d1.Text);
            b = Convert.ToDouble(tx31_1.Text);
            c = a / b;
            tx_convert1.Text = tx_convert.Text;
            tx_total1.Text = c.ToString();
            x = Convert.ToDouble(tx_p_d2.Text);
            y = Convert.ToDouble(tx31_100.Text);
            z = Convert.ToDouble(tx1000.Text);
            s = Convert.ToDouble(tx_convert1.Text);
            m = x / y / z * s;
            tx_total2.Text = m.ToString();
            t = c + m;
            tb_convert.Text = t.ToString();
            // for know iraqi grham of buy
            double a1, b1, c1, d, f, g1, t1;
            a1 = Convert.ToDouble(tb_convert.Text);
            b1 = Convert.ToDouble(tx_iraqi.Text);
            c1 = Convert.ToDouble(tx_0_875.Text);
            d = Convert.ToDouble(tx_dolar.Text);
            f = a1 - b1;
            g1 = c1 * d;
            t1 = f * g1;
            tb_iqB.Text = t1.ToString();
            // for know Ghalegi grham of buy
            double a2, b2, c2, d2, f2, g2, t2;
            a2 = Convert.ToDouble(tb_convert.Text);
            b2 = Convert.ToDouble(tx_ghalegi.Text);
            c2 = Convert.ToDouble(tx_0_875.Text);
            d2 = Convert.ToDouble(tx_dolar.Text);
            f2 = a2 - b2;
            g2 = c2 * d2;
            t2 = f2 * g2;
            tb_ghB.Text = t2.ToString();
            // for know Ghalegi grham of sale (with cost)
            double a3, b3, c3, d3, f3, g3, h3;
            a3 = Convert.ToDouble(tb_convert.Text);
            b3 = Convert.ToDouble(tx_cost.Text);
            c3 = Convert.ToDouble(tx_0_88.Text);
            d3 = Convert.ToDouble(tx_dolar.Text);
            f3 = a3 * c3;
            g3 = f3 + b3;
            h3 = g3 * d3;
            tb_ghS.Text = h3.ToString();

        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/exit.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //My storyBoard animations begin();
            sw_menu_close.Begin();
            sw_about.Begin();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //My storyBoard animations begin();

            sw_abot_close.Begin();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var web2 = Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.facebook.com/WifSoftware"));
        }

        private void bt_open1_Click(object sender, RoutedEventArgs e)
        {
            sw_menu.Begin();
            bt_open1.Visibility = Visibility.Collapsed;
            bt_close.Visibility = Visibility.Visible;
        }

        private void bt_close_Click(object sender, RoutedEventArgs e)
        {
            sw_menu_close.Begin();
            bt_close.Visibility = Visibility.Collapsed;
            bt_open1.Visibility = Visibility.Visible;
        }

        private void tx_dolar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tx_dolar.Text == "")
            {
                MessageBox.Show("You can not complating this task with this value of Dollar", "Dollar price", MessageBoxButton.OK);
                tx_dolar.Text = "1.26";
            }
        }

        private void tx_convert_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (tx_convert.Text == "")
            {
                MessageBox.Show(" You can not complating this task with this value ", "The Convertation ", MessageBoxButton.OK);
                tx_convert.Text = "65";

            }
        }

        private void tx_ghalegi_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tx_ghalegi.Text == "")
            {
                MessageBox.Show("You can not complating this task with this value ", "price  Ghaljy", MessageBoxButton.OK);
                tx_ghalegi.Text = "0.8";

            }
        }

        private void tx_iraqi_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tx_iraqi.Text == "")
            {
                MessageBox.Show("You can not complating this task with this value ", "price Iraqi", MessageBoxButton.OK);
                tx_iraqi.Text = "2.80";

            }
        }

        private void tx_cost_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tx_cost.Text == "")
            {
                MessageBox.Show("You can not complating this task with this value , The value must to be 2 or higher ", "Cost", MessageBoxButton.OK);
                tx_cost.Text = "4";
            }
        }
    }
}