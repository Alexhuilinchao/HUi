using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace App5
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        
        private async  void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (this.Frame != null)
            {
                App5.App.p1=  new BitmapImage(new Uri("ms-appx:///Data/华清池/Pictures/01.jpg",UriKind.Absolute));
                App5.App.p2 = new BitmapImage(new Uri("ms-appx:///Data/华清池/Pictures/02.jpg", UriKind.Absolute));
                App5.App.p3 = new BitmapImage(new Uri("ms-appx:///Data/华清池/Pictures/03.jpg", UriKind.Absolute));
                App5.App.p4 = new BitmapImage(new Uri("ms-appx:///Data/华清池/Pictures/04.jpg", UriKind.Absolute));
                App5.App.p5 = new BitmapImage(new Uri("ms-appx:///Data/华清池/Pictures/05.jpg", UriKind.Absolute));
                App5.App.p6 = new BitmapImage(new Uri("ms-appx:///Data/华清池/Picture route/01.png", UriKind.Absolute));
                App5.App.p7 = new BitmapImage(new Uri("ms-appx:///Data/华清池/Bus route/01.png", UriKind.Absolute));
                
                string CountriesFile = @"Data\华清池\Scenic Introduction.txt";
                StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file = await InstallationFolder.GetFileAsync(CountriesFile);
                Stream Countries = await file.OpenStreamForReadAsync();
                StreamReader SR = new StreamReader(Countries, Encoding.GetEncoding("gb2312"));
                string st = SR.ReadLine();
                App5.App.t1 = st;
                string CountriesFile2 = @"Data\华清池\Entrance ticket&time.txt";
                StorageFolder InstallationFolder1 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file1 = await InstallationFolder1.GetFileAsync(CountriesFile2);
                Stream Countries1 = await file1.OpenStreamForReadAsync();
                StreamReader SB = new StreamReader(Countries1, Encoding.GetEncoding("gb2312"));
                string sb = SB.ReadLine();
                App5.App.t2 = sb;
                string CountriesFile3 = @"Data\华清池\Warm tip.txt";
                StorageFolder InstallationFolder3 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file2 = await InstallationFolder3.GetFileAsync(CountriesFile3);
                Stream Countries2 = await file2.OpenStreamForReadAsync();
                StreamReader Sc = new StreamReader(Countries2, Encoding.GetEncoding("gb2312"));
                string sc = Sc.ReadLine();
                App5.App.t3 = sc;
                
                this.Frame.Navigate(typeof(BlankPage1));
            }
         
        }

        private async  void Button2_Click_2(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                App5.App.p1 = new BitmapImage(new Uri("ms-appx:///Data/阿房宫遗址/Pictures/01.png", UriKind.Absolute));
                App5.App.p2 = new BitmapImage(new Uri("ms-appx:///Data/阿房宫遗址/Pictures/02.png", UriKind.Absolute));
                App5.App.p3 = new BitmapImage(new Uri("ms-appx:///Data/阿房宫遗址/Pictures/03.png", UriKind.Absolute));
                App5.App.p4 = new BitmapImage(new Uri("ms-appx:///Data/阿房宫遗址/Pictures/04.png", UriKind.Absolute));
                App5.App.p5 = new BitmapImage(new Uri("ms-appx:///Data/阿房宫遗址/Pictures/05.png", UriKind.Absolute));
                App5.App.p6 = new BitmapImage(new Uri("ms-appx:///Data/阿房宫遗址/Picture route/01.png", UriKind.Absolute));
                App5.App.p7 = new BitmapImage(new Uri("ms-appx:///Data/阿房宫遗址/Bus route/01.png", UriKind.Absolute));

                string CountriesFile = @"Data\阿房宫遗址\Scenic Introduction.txt";
                StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file = await InstallationFolder.GetFileAsync(CountriesFile);
                Stream Countries = await file.OpenStreamForReadAsync();
                StreamReader SR = new StreamReader(Countries, Encoding.GetEncoding("gb2312"));
                string st = SR.ReadLine();
                App5.App.t1 = st;
                string CountriesFile2 = @"Data\阿房宫遗址\Entrance ticket&time.txt";
                StorageFolder InstallationFolder1 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file1 = await InstallationFolder1.GetFileAsync(CountriesFile2);
                Stream Countries1 = await file1.OpenStreamForReadAsync();
                StreamReader SB = new StreamReader(Countries1, Encoding.GetEncoding("gb2312"));
                string sb = SB.ReadLine();
                App5.App.t2 = sb;
                string CountriesFile3 = @"Data\阿房宫遗址\Warm tip.txt";
                StorageFolder InstallationFolder3 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file2 = await InstallationFolder3.GetFileAsync(CountriesFile3);
                Stream Countries2 = await file2.OpenStreamForReadAsync();
                StreamReader Sc = new StreamReader(Countries2, Encoding.GetEncoding("gb2312"));
                string sc = Sc.ReadLine();
                App5.App.t3 = sc;

                this.Frame.Navigate(typeof(BlankPage1));
            }

        }


        private async void Button4_Click_4(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                App5.App.p1 = new BitmapImage(new Uri("ms-appx:///Data/兵马俑/Pictures/01.jpg", UriKind.Absolute));
                App5.App.p2 = new BitmapImage(new Uri("ms-appx:///Data/兵马俑/Pictures/02.jpg", UriKind.Absolute));
                App5.App.p3 = new BitmapImage(new Uri("ms-appx:///Data/兵马俑/Pictures/03.jpg", UriKind.Absolute));
                App5.App.p4 = new BitmapImage(new Uri("ms-appx:///Data/兵马俑/Pictures/04.jpg", UriKind.Absolute));
                App5.App.p5 = new BitmapImage(new Uri("ms-appx:///Data/兵马俑/Pictures/05.jpg", UriKind.Absolute));
                App5.App.p6 = new BitmapImage(new Uri("ms-appx:///Data/兵马俑/Picture route/root.jpg", UriKind.Absolute));
                App5.App.p7 = new BitmapImage(new Uri("ms-appx:///Data/兵马俑/Bus route/bus.jpg", UriKind.Absolute));

                string CountriesFile = @"Data\兵马俑\Scenic Introduction.txt";
                StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file = await InstallationFolder.GetFileAsync(CountriesFile);
                Stream Countries = await file.OpenStreamForReadAsync();
                StreamReader SR = new StreamReader(Countries, Encoding.GetEncoding("gb2312"));
                string st = SR.ReadLine();
                App5.App.t1 = st;
                string CountriesFile2 = @"Data\兵马俑\Entrance ticket&time.txt";
                StorageFolder InstallationFolder1 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file1 = await InstallationFolder1.GetFileAsync(CountriesFile2);
                Stream Countries1 = await file1.OpenStreamForReadAsync();
                StreamReader SB = new StreamReader(Countries1, Encoding.GetEncoding("gb2312"));
                string sb = SB.ReadLine();
                App5.App.t2 = sb;
                string CountriesFile3 = @"Data\兵马俑\Warm tip.txt";
                StorageFolder InstallationFolder3 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file2 = await InstallationFolder3.GetFileAsync(CountriesFile3);
                Stream Countries2 = await file2.OpenStreamForReadAsync();
                StreamReader Sc = new StreamReader(Countries2, Encoding.GetEncoding("gb2312"));
                string sc = Sc.ReadLine();
                App5.App.t3 = sc;

                this.Frame.Navigate(typeof(BlankPage1));
            }


        }

        private async void Button5_Click_5(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                App5.App.p1 = new BitmapImage(new Uri("ms-appx:///Data/翠华山/Pictures/01.png", UriKind.Absolute));
                App5.App.p2 = new BitmapImage(new Uri("ms-appx:///Data/翠华山/Pictures/02.png", UriKind.Absolute));
                App5.App.p3 = new BitmapImage(new Uri("ms-appx:///Data/翠华山/Pictures/03.png", UriKind.Absolute));
                App5.App.p4 = new BitmapImage(new Uri("ms-appx:///Data/翠华山/Pictures/04.png", UriKind.Absolute));
                App5.App.p5 = new BitmapImage(new Uri("ms-appx:///Data/翠华山/Pictures/05.png", UriKind.Absolute));
                App5.App.p6 = new BitmapImage(new Uri("ms-appx:///Data/翠华山/Picture route/01.jpg", UriKind.Absolute));
                App5.App.p7 = new BitmapImage(new Uri("ms-appx:///Data/翠华山/Bus route/01.jpg", UriKind.Absolute));

                string CountriesFile = @"Data\翠华山\Scenic Introduction.txt";
                StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file = await InstallationFolder.GetFileAsync(CountriesFile);
                Stream Countries = await file.OpenStreamForReadAsync();
                StreamReader SR = new StreamReader(Countries, Encoding.GetEncoding("gb2312"));
                string st = SR.ReadLine();
                App5.App.t1 = st;
                string CountriesFile2 = @"Data\翠华山\Entrance ticket&time.txt";
                StorageFolder InstallationFolder1 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file1 = await InstallationFolder1.GetFileAsync(CountriesFile2);
                Stream Countries1 = await file1.OpenStreamForReadAsync();
                StreamReader SB = new StreamReader(Countries1, Encoding.GetEncoding("gb2312"));
                string sb = SB.ReadLine();
                App5.App.t2 = sb;
                string CountriesFile3 = @"Data\翠华山\Warm tip.txt";
                StorageFolder InstallationFolder3 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file2 = await InstallationFolder3.GetFileAsync(CountriesFile3);
                Stream Countries2 = await file2.OpenStreamForReadAsync();
                StreamReader Sc = new StreamReader(Countries2, Encoding.GetEncoding("gb2312"));
                string sc = Sc.ReadLine();
                App5.App.t3 = sc;

                this.Frame.Navigate(typeof(BlankPage1));
            }

        }

        private async void Button6_Click_6(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                App5.App.p1 = new BitmapImage(new Uri("ms-appx:///Data/大唐芙蓉园/Pictures/01.jpg", UriKind.Absolute));
                App5.App.p2 = new BitmapImage(new Uri("ms-appx:///Data/大唐芙蓉园/Pictures/02.jpg", UriKind.Absolute));
                App5.App.p3 = new BitmapImage(new Uri("ms-appx:///Data/大唐芙蓉园/Pictures/03.jpg", UriKind.Absolute));
                App5.App.p4 = new BitmapImage(new Uri("ms-appx:///Data/大唐芙蓉园/Pictures/04.jpg", UriKind.Absolute));
                App5.App.p5 = new BitmapImage(new Uri("ms-appx:///Data/大唐芙蓉园/Pictures/05.jpg", UriKind.Absolute));
                App5.App.p6 = new BitmapImage(new Uri("ms-appx:///Data/大唐芙蓉园/Picture route/01.png", UriKind.Absolute));
                App5.App.p7 = new BitmapImage(new Uri("ms-appx:///Data/大唐芙蓉园/Bus route/01.png", UriKind.Absolute));

                string CountriesFile = @"Data\大唐芙蓉园\Scenic Introduction.txt";
                StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file = await InstallationFolder.GetFileAsync(CountriesFile);
                Stream Countries = await file.OpenStreamForReadAsync();
                StreamReader SR = new StreamReader(Countries, Encoding.GetEncoding("gb2312"));
                string st = SR.ReadLine();
                App5.App.t1 = st;
                string CountriesFile2 = @"Data\大唐芙蓉园\Entrance ticket&time.txt";
                StorageFolder InstallationFolder1 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file1 = await InstallationFolder1.GetFileAsync(CountriesFile2);
                Stream Countries1 = await file1.OpenStreamForReadAsync();
                StreamReader SB = new StreamReader(Countries1, Encoding.GetEncoding("gb2312"));
                string sb = SB.ReadLine();
                App5.App.t2 = sb;
                string CountriesFile3 = @"Data\大唐芙蓉园\Warm tip.txt";
                StorageFolder InstallationFolder3 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file2 = await InstallationFolder3.GetFileAsync(CountriesFile3);
                Stream Countries2 = await file2.OpenStreamForReadAsync();
                StreamReader Sc = new StreamReader(Countries2, Encoding.GetEncoding("gb2312"));
                string sc = Sc.ReadLine();
                App5.App.t3 = sc;

                this.Frame.Navigate(typeof(BlankPage1));
            }

        }

        private async void Button7_Click_7(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                App5.App.p1 = new BitmapImage(new Uri("ms-appx:///Data/大雁塔/Pictures/01.jpg", UriKind.Absolute));
                App5.App.p2 = new BitmapImage(new Uri("ms-appx:///Data/大雁塔/Pictures/02.jpg", UriKind.Absolute));
                App5.App.p3 = new BitmapImage(new Uri("ms-appx:///Data/大雁塔/Pictures/03.jpg", UriKind.Absolute));
                App5.App.p4 = new BitmapImage(new Uri("ms-appx:///Data/大雁塔/Pictures/04.jpg", UriKind.Absolute));
                App5.App.p5 = new BitmapImage(new Uri("ms-appx:///Data/大雁塔/Pictures/05.jpg", UriKind.Absolute));
                App5.App.p6 = new BitmapImage(new Uri("ms-appx:///Data/大雁塔/Picture route/01.png", UriKind.Absolute));
                App5.App.p7 = new BitmapImage(new Uri("ms-appx:///Data/大雁塔/Bus route/01.png", UriKind.Absolute));

                string CountriesFile = @"Data\大雁塔\Scenic Introduction.txt";
                StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file = await InstallationFolder.GetFileAsync(CountriesFile);
                Stream Countries = await file.OpenStreamForReadAsync();
                StreamReader SR = new StreamReader(Countries, Encoding.GetEncoding("gb2312"));
                string st = SR.ReadLine();
                App5.App.t1 = st;
                string CountriesFile2 = @"Data\大雁塔\Entrance ticket&time.txt";
                StorageFolder InstallationFolder1 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file1 = await InstallationFolder1.GetFileAsync(CountriesFile2);
                Stream Countries1 = await file1.OpenStreamForReadAsync();
                StreamReader SB = new StreamReader(Countries1, Encoding.GetEncoding("gb2312"));
                string sb = SB.ReadLine();
                App5.App.t2 = sb;
                string CountriesFile3 = @"Data\大雁塔\Warm tip.txt";
                StorageFolder InstallationFolder3 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file2 = await InstallationFolder3.GetFileAsync(CountriesFile3);
                Stream Countries2 = await file2.OpenStreamForReadAsync();
                StreamReader Sc = new StreamReader(Countries2, Encoding.GetEncoding("gb2312"));
                string sc = Sc.ReadLine();
                App5.App.t3 = sc;

                this.Frame.Navigate(typeof(BlankPage1));
            }

        }

        private async void Button8_Click_8(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                App5.App.p1 = new BitmapImage(new Uri("ms-appx:///Data/临潼骊山/Pictures/01.jpg", UriKind.Absolute));
                App5.App.p2 = new BitmapImage(new Uri("ms-appx:///Data/临潼骊山/Pictures/02.jpg", UriKind.Absolute));
                App5.App.p3 = new BitmapImage(new Uri("ms-appx:///Data/临潼骊山/Pictures/03.jpg", UriKind.Absolute));
                App5.App.p4 = new BitmapImage(new Uri("ms-appx:///Data/临潼骊山/Pictures/04.jpg", UriKind.Absolute));
                App5.App.p5 = new BitmapImage(new Uri("ms-appx:///Data/临潼骊山/Pictures/05.jpg", UriKind.Absolute));
                App5.App.p6 = new BitmapImage(new Uri("ms-appx:///Data/临潼骊山/Picture route/o1.png", UriKind.Absolute));
                App5.App.p7 = new BitmapImage(new Uri("ms-appx:///Data/临潼骊山/Bus route/01.png", UriKind.Absolute));

                string CountriesFile = @"Data\临潼骊山\Scenic Introduction.txt";
                StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file = await InstallationFolder.GetFileAsync(CountriesFile);
                Stream Countries = await file.OpenStreamForReadAsync();
                StreamReader SR = new StreamReader(Countries, Encoding.GetEncoding("gb2312"));
                string st = SR.ReadLine();
                App5.App.t1 = st;
                string CountriesFile2 = @"Data\临潼骊山\Entrance ticket&time.txt";
                StorageFolder InstallationFolder1 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file1 = await InstallationFolder1.GetFileAsync(CountriesFile2);
                Stream Countries1 = await file1.OpenStreamForReadAsync();
                StreamReader SB = new StreamReader(Countries1, Encoding.GetEncoding("gb2312"));
                string sb = SB.ReadLine();
                App5.App.t2 = sb;
                string CountriesFile3 = @"Data\临潼骊山\Warm tip.txt";
                StorageFolder InstallationFolder3 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file2 = await InstallationFolder3.GetFileAsync(CountriesFile3);
                Stream Countries2 = await file2.OpenStreamForReadAsync();
                StreamReader Sc = new StreamReader(Countries2, Encoding.GetEncoding("gb2312"));
                string sc = Sc.ReadLine();
                App5.App.t3 = sc;

                this.Frame.Navigate(typeof(BlankPage1));
            }

        }

        private async void Button9_Click_9(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                App5.App.p1 = new BitmapImage(new Uri("ms-appx:///Data/明城墙/Pictures/01.jpg", UriKind.Absolute));
                App5.App.p2 = new BitmapImage(new Uri("ms-appx:///Data/明城墙/Pictures/02.jpg", UriKind.Absolute));
                App5.App.p3 = new BitmapImage(new Uri("ms-appx:///Data/明城墙/Pictures/03.jpg", UriKind.Absolute));
                App5.App.p4 = new BitmapImage(new Uri("ms-appx:///Data/明城墙/Pictures/04.jpg", UriKind.Absolute));
                App5.App.p5 = new BitmapImage(new Uri("ms-appx:///Data/明城墙/Pictures/05.jpg", UriKind.Absolute));
                App5.App.p6 = new BitmapImage(new Uri("ms-appx:///Data/明城墙/Picture route/01.png", UriKind.Absolute));
                App5.App.p7 = new BitmapImage(new Uri("ms-appx:///Data/明城墙/Bus route/01.png", UriKind.Absolute));

                string CountriesFile = @"Data\明城墙\Scenic Introduction.txt";
                StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file = await InstallationFolder.GetFileAsync(CountriesFile);
                Stream Countries = await file.OpenStreamForReadAsync();
                StreamReader SR = new StreamReader(Countries, Encoding.GetEncoding("gb2312"));
                string st = SR.ReadLine();
                App5.App.t1 = st;
                string CountriesFile2 = @"Data\明城墙\Entrance ticket&time.txt";
                StorageFolder InstallationFolder1 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file1 = await InstallationFolder1.GetFileAsync(CountriesFile2);
                Stream Countries1 = await file1.OpenStreamForReadAsync();
                StreamReader SB = new StreamReader(Countries1, Encoding.GetEncoding("gb2312"));
                string sb = SB.ReadLine();
                App5.App.t2 = sb;
                string CountriesFile3 = @"Data\明城墙\Warm tip.txt";
                StorageFolder InstallationFolder3 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file2 = await InstallationFolder3.GetFileAsync(CountriesFile3);
                Stream Countries2 = await file2.OpenStreamForReadAsync();
                StreamReader Sc = new StreamReader(Countries2, Encoding.GetEncoding("gb2312"));
                string sc = Sc.ReadLine();
                App5.App.t3 = sc;

                this.Frame.Navigate(typeof(BlankPage1));
            }

        }

        private async void Button10_Click_10(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                App5.App.p1 = new BitmapImage(new Uri("ms-appx:///Data/曲江海洋公园/Pictures/01.jpg", UriKind.Absolute));
                App5.App.p2 = new BitmapImage(new Uri("ms-appx:///Data/曲江海洋公园/Pictures/02.jpg", UriKind.Absolute));
                App5.App.p3 = new BitmapImage(new Uri("ms-appx:///Data/曲江海洋公园/Pictures/03.jpg", UriKind.Absolute));
                App5.App.p4 = new BitmapImage(new Uri("ms-appx:///Data/曲江海洋公园/Pictures/04.jpg", UriKind.Absolute));
                App5.App.p5 = new BitmapImage(new Uri("ms-appx:///Data/曲江海洋公园/Pictures/05.jpg", UriKind.Absolute));
                App5.App.p6 = new BitmapImage(new Uri("ms-appx:///Data/曲江海洋公园/Picture route/01.png", UriKind.Absolute));
                App5.App.p7 = new BitmapImage(new Uri("ms-appx:///Data/曲江海洋公园/Bus route/01.png", UriKind.Absolute));

                string CountriesFile = @"Data\曲江海洋公园\Scenic Introduction.txt";
                StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file = await InstallationFolder.GetFileAsync(CountriesFile);
                Stream Countries = await file.OpenStreamForReadAsync();
                StreamReader SR = new StreamReader(Countries, Encoding.GetEncoding("gb2312"));
                string st = SR.ReadLine();
                App5.App.t1 = st;
                string CountriesFile2 = @"Data\曲江海洋公园\Entrance ticket&time.txt";
                StorageFolder InstallationFolder1 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file1 = await InstallationFolder1.GetFileAsync(CountriesFile2);
                Stream Countries1 = await file1.OpenStreamForReadAsync();
                StreamReader SB = new StreamReader(Countries1, Encoding.GetEncoding("gb2312"));
                string sb = SB.ReadLine();
                App5.App.t2 = sb;
                string CountriesFile3 = @"Data\曲江海洋公园\Warm tip.txt";
                StorageFolder InstallationFolder3 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file2 = await InstallationFolder3.GetFileAsync(CountriesFile3);
                Stream Countries2 = await file2.OpenStreamForReadAsync();
                StreamReader Sc = new StreamReader(Countries2, Encoding.GetEncoding("gb2312"));
                string sc = Sc.ReadLine();
                App5.App.t3 = sc;

                this.Frame.Navigate(typeof(BlankPage1));
            }


        }

        private async void Button11_Click_11(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                App5.App.p1 = new BitmapImage(new Uri("ms-appx:///Data/太平森林公园/Pictures/01.png", UriKind.Absolute));
                App5.App.p2 = new BitmapImage(new Uri("ms-appx:///Data/太平森林公园/Pictures/02.png", UriKind.Absolute));
                App5.App.p3 = new BitmapImage(new Uri("ms-appx:///Data/太平森林公园/Pictures/03.png", UriKind.Absolute));
                App5.App.p4 = new BitmapImage(new Uri("ms-appx:///Data/太平森林公园/Pictures/04.png", UriKind.Absolute));
                App5.App.p5 = new BitmapImage(new Uri("ms-appx:///Data/太平森林公园/Pictures/05.png", UriKind.Absolute));
                App5.App.p6 = new BitmapImage(new Uri("ms-appx:///Data/太平森林公园/Picture route/01.png", UriKind.Absolute));
                App5.App.p7 = new BitmapImage(new Uri("ms-appx:///Data/太平森林公园/Bus route/01.png", UriKind.Absolute));

                string CountriesFile = @"Data\太平森林公园\Scenic Introduction.txt";
                StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file = await InstallationFolder.GetFileAsync(CountriesFile);
                Stream Countries = await file.OpenStreamForReadAsync();
                StreamReader SR = new StreamReader(Countries, Encoding.GetEncoding("gb2312"));
                string st = SR.ReadLine();
                App5.App.t1 = st;
                string CountriesFile2 = @"Data\太平森林公园\Entrance ticket&time.txt";
                StorageFolder InstallationFolder1 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file1 = await InstallationFolder1.GetFileAsync(CountriesFile2);
                Stream Countries1 = await file1.OpenStreamForReadAsync();
                StreamReader SB = new StreamReader(Countries1, Encoding.GetEncoding("gb2312"));
                string sb = SB.ReadLine();
                App5.App.t2 = sb;
                string CountriesFile3 = @"Data\太平森林公园\Warm tip.txt";
                StorageFolder InstallationFolder3 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file2 = await InstallationFolder3.GetFileAsync(CountriesFile3);
                Stream Countries2 = await file2.OpenStreamForReadAsync();
                StreamReader Sc = new StreamReader(Countries2, Encoding.GetEncoding("gb2312"));
                string sc = Sc.ReadLine();
                App5.App.t3 = sc;

                this.Frame.Navigate(typeof(BlankPage1));
            }

        }

        private async void Button12_Click_12(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                App5.App.p1 = new BitmapImage(new Uri("ms-appx:///Data/柞水溶洞/Pictures/01.jpgg", UriKind.Absolute));
                App5.App.p2 = new BitmapImage(new Uri("ms-appx:///Data/柞水溶洞/Pictures/02.jpg", UriKind.Absolute));
                App5.App.p3 = new BitmapImage(new Uri("ms-appx:///Data/柞水溶洞/Pictures/03.jpg", UriKind.Absolute));
                App5.App.p4 = new BitmapImage(new Uri("ms-appx:///Data/柞水溶洞/Pictures/04.jpg", UriKind.Absolute));
                App5.App.p5 = new BitmapImage(new Uri("ms-appx:///Data/柞水溶洞/Pictures/05.jpg", UriKind.Absolute));
                App5.App.p6 = new BitmapImage(new Uri("ms-appx:///Data/柞水溶洞/Picture route/01.png", UriKind.Absolute));
                App5.App.p7 = new BitmapImage(new Uri("ms-appx:///Data/柞水溶洞/Bus route/01.png", UriKind.Absolute));

                string CountriesFile = @"Data\柞水溶洞\Scenic Introduction.txt";
                StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file = await InstallationFolder.GetFileAsync(CountriesFile);
                Stream Countries = await file.OpenStreamForReadAsync();
                StreamReader SR = new StreamReader(Countries, Encoding.GetEncoding("gb2312"));
                string st = SR.ReadLine();
                App5.App.t1 = st;
                string CountriesFile2 = @"Data\柞水溶洞\Entrance ticket&time.txt";
                StorageFolder InstallationFolder1 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file1 = await InstallationFolder1.GetFileAsync(CountriesFile2);
                Stream Countries1 = await file1.OpenStreamForReadAsync();
                StreamReader SB = new StreamReader(Countries1, Encoding.GetEncoding("gb2312"));
                string sb = SB.ReadLine();
                App5.App.t2 = sb;
                string CountriesFile3 = @"Data\柞水溶洞\Warm tip.txt";
                StorageFolder InstallationFolder3 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file2 = await InstallationFolder3.GetFileAsync(CountriesFile3);
                Stream Countries2 = await file2.OpenStreamForReadAsync();
                StreamReader Sc = new StreamReader(Countries2, Encoding.GetEncoding("gb2312"));
                string sc = Sc.ReadLine();
                App5.App.t3 = sc;

                this.Frame.Navigate(typeof(BlankPage1));
            }

        }

        private async void Button13_Click_13(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                App5.App.p1 = new BitmapImage(new Uri("ms-appx:///Data/朱雀森林公园/Pictures/01.png", UriKind.Absolute));
                App5.App.p2 = new BitmapImage(new Uri("ms-appx:///Data/朱雀森林公园/Pictures/02.png", UriKind.Absolute));
                App5.App.p3 = new BitmapImage(new Uri("ms-appx:///Data/朱雀森林公园/Pictures/03.png", UriKind.Absolute));
                App5.App.p4 = new BitmapImage(new Uri("ms-appx:///Data/朱雀森林公园/Pictures/04.png", UriKind.Absolute));
                App5.App.p5 = new BitmapImage(new Uri("ms-appx:///Data/朱雀森林公园/Pictures/05.png", UriKind.Absolute));
                App5.App.p6 = new BitmapImage(new Uri("ms-appx:///Data/朱雀森林公园/Picture route/01.png", UriKind.Absolute));
                App5.App.p7 = new BitmapImage(new Uri("ms-appx:///Data/朱雀森林公园/Bus route/01.png", UriKind.Absolute));

                string CountriesFile = @"Data\朱雀森林公园\Scenic Introduction.txt";
                StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file = await InstallationFolder.GetFileAsync(CountriesFile);
                Stream Countries = await file.OpenStreamForReadAsync();
                StreamReader SR = new StreamReader(Countries, Encoding.GetEncoding("gb2312"));
                string st = SR.ReadLine();
                App5.App.t1 = st;
                string CountriesFile2 = @"Data\朱雀森林公园\Entrance ticket&time.txt";
                StorageFolder InstallationFolder1 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file1 = await InstallationFolder1.GetFileAsync(CountriesFile2);
                Stream Countries1 = await file1.OpenStreamForReadAsync();
                StreamReader SB = new StreamReader(Countries1, Encoding.GetEncoding("gb2312"));
                string sb = SB.ReadLine();
                App5.App.t2 = sb;
                string CountriesFile3 = @"Data\朱雀森林公园\Warm tip.txt";
                StorageFolder InstallationFolder3 = Windows.ApplicationModel.Package.Current.InstalledLocation;
                StorageFile file2 = await InstallationFolder3.GetFileAsync(CountriesFile3);
                Stream Countries2 = await file2.OpenStreamForReadAsync();
                StreamReader Sc = new StreamReader(Countries2, Encoding.GetEncoding("gb2312"));
                string sc = Sc.ReadLine();
                App5.App.t3 = sc;

                this.Frame.Navigate(typeof(BlankPage1));
            }

        }

    }
}
