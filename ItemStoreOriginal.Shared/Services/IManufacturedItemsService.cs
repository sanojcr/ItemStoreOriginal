using ItemStoreOriginal.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemStoreOriginal.Shared.Services
{
    public interface IManufacturedItemsService
    {
        public Task<List<Item>> GetAllManufacturedItemsAsync();
        public Task<Item> InsertManufacturedItemsAsync(Item item);
    }
}
