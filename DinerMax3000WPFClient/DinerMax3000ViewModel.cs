using System;
using System.Collections.Generic;
using System.Text;
using DinerMax3000.Business;

namespace DinerMax3000.WPFClient
{
	public class DinerMax3000ViewModel
	{
		public List<Menu> AllMenus
		{
			get
			{
				return Menu.GetAllMenus();
			}
		}
	}
}
