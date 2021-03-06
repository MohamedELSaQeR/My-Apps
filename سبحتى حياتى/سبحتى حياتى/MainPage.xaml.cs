﻿using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace سبحتى_حياتى
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MySplitViev.IsPaneOpen = false;
            MySplitViev.DisplayMode = SplitViewDisplayMode.Inline;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.MyFrame.Navigate(typeof(Views.Home_Page));
            Header.Text = "سبحتى";
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as RadioButton;
            if (button != null)
            {
                switch (button.Content.ToString())
                {
                    case "سبحتى":
                        this.MyFrame.Navigate(typeof(Views.Home_Page));
                        break;
                    case "أذكار بعد الصلاة":
                        this.MyFrame.Navigate(typeof(Views.After_Page));
                        break;
                    case "أذكار الصباح و المساء":
                        this.MyFrame.Navigate(typeof(Views.Morning_Page));
                        break;
                    case "التسابيح اليومية":
                        this.MyFrame.Navigate(typeof(Views.Daily_Page));
                        break;
                    case "الأعدادات":
                        this.MyFrame.Navigate(typeof(Views.Settings_Page));
                        break;
                }
                MySplitViev.IsPaneOpen = false;
                Header.Text = button.Content.ToString();
            }
        }
        private void SplitTogleBtn_Click(object sender, RoutedEventArgs e)
        {
            MySplitViev.IsPaneOpen = !MySplitViev.IsPaneOpen;
        }

    }
}
