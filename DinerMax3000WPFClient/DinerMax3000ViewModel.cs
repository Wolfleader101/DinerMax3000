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
		private Menu _selectedMenu = new Menu();
		public Menu SelectedMenu
		{
			get
			{
				return _selectedMenu;
			}
			set
			{
				_selectedMenu = value;
			}
		}

		private MenuItem _newMenuItem = new MenuItem();
		public MenuItem NewMenuItem
		{
			get
			{
				return _newMenuItem;
			}
			set
			{
				_newMenuItem = value;
			}
		}
	}
}
