using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Ghram_today
{
    /// <summary>
    ///This code by Mustsfa Jawad © 2016
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void tx_p_d_TextChanged(object sender, TextChangedEventArgs e)
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
    }
}
