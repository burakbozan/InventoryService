using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Services
{
    public interface IInventorServices
    {
        InventoryItems AddInventoryItems(InventoryItems items);
        Dictionary<string,InventoryItems> GetInventoryItems();
    }
}
