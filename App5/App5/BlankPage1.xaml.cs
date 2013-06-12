using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace App5
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。Parameter
        /// 属性通常用于配置页。</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            Image1.Source = App5.App.p1;
            Image2.Source = App5.App.p2;
            Image3.Source = App5.App.p3;
            Image4.Source = App5.App.p4;
            Image5.Source = App5.App.p5;
            Image6.Source = App5.App.p6;
            Image7.Source = App5.App.p7;

            TextBlock2.Text = App5.App.t1;
            TextBlock4.Text = App5.App.t2;
            TextBlock6.Text = App5.App.t3;
            
        }

        private void Button23_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(MainPage));
            }
        }
    }
}
