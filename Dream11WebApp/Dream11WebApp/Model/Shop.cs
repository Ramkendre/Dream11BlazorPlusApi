using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dream11WebApp.Model
{
    public  class Shop : ComponentBase
    {
        public  List<ShopItem> ShoppingItems = new List<ShopItem>();

        protected override void OnInit()
        {
            base.OnInit();
        }
        public  void AddItem(ShopItem obj)
        {
            ShoppingItems.Add(obj);
            Console.WriteLine(obj);
        }

    }

    public  class ShopItem
    {
        public string ItemId { get; set; }
        public string Item { get; set; }
    }
}
