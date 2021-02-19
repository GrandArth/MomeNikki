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
using muxc = Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace MomeNikki
{
	/// <summary>
	/// 可用于自身或导航至 Frame 内部的空白页。
	/// </summary>

	/// <summary>
	/// 可用于自身或导航至 Frame 内部的空白页。
	/// </summary>
	public sealed partial class NikkiPage : Page
	{
		public ObservableCollection<Nikki> ActiveNikkis = new ObservableCollection<Nikki>();
		public ObservableCollection<Item> AvailableDates = new ObservableCollection<Item>();
		public ObservableCollection<int> ActiveDays = new ObservableCollection<int>();
		public TreeViewNode InvokedNode = new TreeViewNode();
		public string InvokedYear = System.DateTime.Now.ToString("yyyy");
		public string InvokedMonth = System.DateTime.Now.ToString("MM");
		public string InvokedDay = System.DateTime.Now.ToString("dd");
		public NikkiPage()
		{
			this.InitializeComponent();
			AvailableDates = Get_InitialRecordTreeViewData();
			this.Refresh_Page();
		}

		public void Refresh_Page()
		{
			ActiveDays = DataAccess.GetAvailableDays(InvokedYear, InvokedMonth);
			ActiveNikkis.Clear();
			foreach (Nikki returnedNiki in DataAccess.GetRecordsInMonth(InvokedYear, InvokedMonth))
			{
				ActiveNikkis.Add(returnedNiki);
			}


		}

		private void SendBottom_Click(object sender, RoutedEventArgs e)
		{
			Nikki.NextID = DataAccess.ReturnMaxUid() + 1;
			Nikki tempNikki = new Nikki(NewDairyBox.Text, MemoDatePicker.Date.Year, MemoDatePicker.Date.Month,
				MemoDatePicker.Date.Day, MemoTimePicker.Time.Hours, MemoTimePicker.Time.Minutes);
			DataAccess.AddRecordExecute(tempNikki.GenSQLAddtoTable());
			InvokedYear = MemoDatePicker.Date.Year.ToString();
			InvokedMonth = MemoDatePicker.Date.Month.ToString();
			InvokedDay = MemoDatePicker.Date.Day.ToString();
			this.Refresh_Page();

		}

		public ObservableCollection<Item> Get_InitialRecordTreeViewData()
		{
			var ViewList = new ObservableCollection<Item>();

			ObservableCollection<int> ActiveYear = DataAccess.GetAvailableYear();
			foreach (int currentYear in ActiveYear)
			{
				Item yearCategory = new Item() { Name = currentYear.ToString() };
				ObservableCollection<int> ActiveMonth = DataAccess.GetAvailableMonth(currentYear.ToString());
				foreach (int currentMonth in ActiveMonth)
				{
					Item monthCategory = new Item() { Name = currentMonth.ToString() };
					ObservableCollection<int> ActiveDays = DataAccess.GetAvailableDays(currentYear.ToString(), currentMonth.ToString());
					foreach (int currenday in ActiveDays)
					{
						Item DayItem = new Item() { Name = currenday.ToString(), Children = null };
						monthCategory.Children.Add(DayItem);
					}
					yearCategory.Children.Add(monthCategory);
				}
				ViewList.Add(yearCategory);
			}
			return ViewList;
		}

		private void DateTreeView_ItemInvoked(muxc.TreeView sender, muxc.TreeViewItemInvokedEventArgs args)
		{
			foreach (muxc.TreeViewNode currentNode in sender.SelectedNodes)
			{

				if (currentNode != null && currentNode.Depth == 2)
				{
					string currentMonth = currentNode.Parent.Content.ToString();
					string currentYear = currentNode.Parent.Parent.Content.ToString();
					InvokedMonth = currentMonth;
					InvokedYear = currentYear;
					InvokedDay = currentNode.Content.ToString();
					this.Refresh_Page();
				}
			}
		}


	}
}
