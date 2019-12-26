using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Services
{
    public class InventoryServices : IInventorServices
    {
        private readonly Dictionary<string, InventoryItems> _inventoryItems;

        public InventoryServices()
        {
            _inventoryItems = new Dictionary<string, InventoryItems>();
        }

        InventoryItems IInventorServices.AddInventoryItems(InventoryItems items)
        {
            _inventoryItems.Add(items.ItemName, items);

            return items;
        }

        Dictionary<string, InventoryItems> IInventorServices.DeleteInventoryItems(InventoryItems items)
        {

            bool item = _inventoryItems.ContainsKey(items.ItemName);
            if (item) 
            {
                _inventoryItems.Remove(items.ItemName);
            }

            return _inventoryItems;
         
        }

        Dictionary<string, InventoryItems> IInventorServices.GetInventoryItems()
        {
            return _inventoryItems;
        }

    }
}
