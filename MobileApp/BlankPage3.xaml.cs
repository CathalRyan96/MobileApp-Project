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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MobileApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage3 : Page
    {
        public BlankPage3()
        {
            this.InitializeComponent();
        }

        //Increase button for goals for team 1
        private int a = 0;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            a++;
            textBox2.Text = a.ToString();

        }

        //The decrease button for goals for team 1
        private static int b = 0;

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            b = a - 1;
            textBox2.Text = b.ToString();

        }

  
       
        //Increase button for points for team 1
        private int d = 0;
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            d++;
            textBox4.Text = d.ToString();

        }

        private int c = 0;
        

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            c = d - 1;
            textBox4.Text = c.ToString();
        }
    }
}
