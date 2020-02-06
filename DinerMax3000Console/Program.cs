using System;
using System.Collections.Generic;
using DinerMax3000.Business;
using System.Data;

namespace DinerMax3000Console
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Menu> menusFromDatabase = Menu.GetAllMenus();
			Menu firstMenu = menusFromDatabase[0];
			firstMenu.SaveNewMenuItem("Fish n Chips", "fried hake and chips", 10);
			menusFromDatabase = Menu.GetAllMenus();

			Order HungryGuest = new Order();

			foreach (Menu currentMenu in menusFromDatabase)
			{
				foreach (MenuItem currentItem in currentMenu.items)
				{
					HungryGuest.items.Add(currentItem);
				}
			}

			

			Console.WriteLine("The total price for the order is: " + HungryGuest.Total);
			Console.WriteLine("test");
		}
	}
}
