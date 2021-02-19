using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MomeNikki
{
	public class Item
	{
		public string Name { get; set; }
		public ObservableCollection<Item> Children { get; set; } = new ObservableCollection<Item>();

		public override string ToString()
		{
			return Name;
		}
	}
}
