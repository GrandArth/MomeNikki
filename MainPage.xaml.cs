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
using System.Collections.ObjectModel;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace MomeNikki
{
	/// <summary>
	/// 可用于自身或导航至 Frame 内部的空白页。
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
			DataAccess.InitializeDatabase();
		}



		private void NavigationViewControl_Loaded(object sender, RoutedEventArgs e)
		{
			foreach (NavigationViewItemBase item in NavigationViewControl.MenuItems)
			{
				if (item is NavigationViewItem && item.Tag.ToString() == "home")
				{
					NavigationViewControl.SelectedItem = item;
					ContentFrame.Navigate(typeof(NikkiPage));
					break;
				}
			}
		}

		private void NavigationViewControl_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
		{

			if (args.IsSettingsInvoked)
			{
				ContentFrame.Navigate(typeof(SettingsPage));
			}
			else
			{
				// find NavigationViewItem with Content that equals InvokedItem
				var item = sender.MenuItems.OfType<NavigationViewItem>().First(x => (string)x.Content == (string)args.InvokedItem);
				NavView_Navigate(item as NavigationViewItem);
			}
		}

		private void NavView_Navigate(NavigationViewItem item)
		{
			switch (item.Tag)
			{
				case "home":
					ContentFrame.Navigate(typeof(NikkiPage));
					break;
			}
		}
	}
}
