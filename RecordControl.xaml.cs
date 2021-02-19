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

//https://go.microsoft.com/fwlink/?LinkId=234236 上介绍了“用户控件”项模板

namespace MomeNikki
{
	public sealed partial class RecordControl : UserControl
	{
		public Nikki pageNikki => this.DataContext as Nikki;
		public RecordControl()
		{
			this.InitializeComponent();
			this.DataContextChanged += (s, e) => Bindings.Update();
		}

		private void DeleteButtom_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			DataAccess.RemoveRecordExecute(pageNikki.GenSQLRemoveSelf());
			this.MainPanel.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
		}

		private void EditButtom_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			if (this.EditButtom.Content.ToString() == "Edit")
			{
				this.RecordMainBody.IsReadOnly = false;
				this.EditButtom.Content = "Submit";
			}
			else if (this.EditButtom.Content.ToString() == "Submit")
			{
				this.RecordMainBody.IsReadOnly = true;
				DataAccess.UpdateRecordExecute(pageNikki.GenSqlUpdateSelf());
				this.EditButtom.Content = "Edit";
			}
		}
	}
}
