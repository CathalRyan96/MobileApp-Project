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
using Windows.Media.Playback;
using Windows.Media.Core;
using Windows.Storage;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MobileApp
{
    

    public sealed partial class BlankPage3 : Page
    {
        //Initialising new timer
        DispatcherTimer mytimer = new DispatcherTimer();
        int currentcount = 0;

        MediaPlayer player;

        public BlankPage3()
        {
            this.InitializeComponent();

            

            mytimer = new DispatcherTimer();

            mytimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            mytimer.Tick += new EventHandler<object>(mytime_Tick);



        }

        private void mytime_Tick(object sender, object e)
        {
            textBlock4.Text = currentcount++.ToString();
        }



        //Increase button for goals for team 1
        private int a = 0;
        private async void button_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("applause.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();


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

        private int f = 0;
        private async void button2_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mysong = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("applause.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mysong.SetSource(stream, file.ContentType);
            mysong.Play();

            f++;
            textBox3.Text = f.ToString();

        }

        private int g = 0;
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            g = f - 1;
            textBox3.Text = g.ToString();
        }

        private int h = 0;
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            h++;
            textBox5.Text = h.ToString();

        }

        private int i = 0;
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            i = h - 1;
            textBox5.Text = i.ToString();

        }


        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            mytimer.Start();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            mytimer.Stop();
        }
    }
}
