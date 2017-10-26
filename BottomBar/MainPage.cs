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
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;
using Windows.UI;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace S_8
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
           
         mainFrame.Navigate(typeof(Pages.Home));

     }

     private void Button_Click(object sender, RoutedEventArgs e)
     {
          _splitMode.IsPaneOpen = !_splitMode.IsPaneOpen;
     }

     private void HomeBt(object sender, RoutedEventArgs e)
     {
         mainFrame.Navigate(typeof(Pages.Home));
     }

     private void RecentBt(object sender, RoutedEventArgs e)
     {

     }

     private void MusicLibBt(object sender, RoutedEventArgs e)
     {
         mainFrame.Navigate(typeof(Pages.MusicLibrary));
     }

     private void SettingBt(object sender, RoutedEventArgs e)
     {

     }

     private void HelpBt(object sender, RoutedEventArgs e)
     {

     }
 }
}
