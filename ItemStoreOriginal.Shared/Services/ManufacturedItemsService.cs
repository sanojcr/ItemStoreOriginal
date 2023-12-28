using ItemStoreOriginal.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemStoreOriginal.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace ItemStoreOriginal.Shared.Services
{
    public class ManufacturedItemsService: IManufacturedItemsService
    {
        public async Task<List<Item>> GetAllManufacturedItemsAsync()
        {
            ItemStoreOriginal.Shared.Models.EFCoreStoreDB nwDb = new ItemStoreOriginal.Shared.Models.EFCoreStoreDB();
            return await nwDb.Items.ToListAsync();
        }

        public async Task<Item> InsertManufacturedItemsAsync(Item item)
        {
            ItemStoreOriginal.Shared.Models.EFCoreStoreDB nwDb = new ItemStoreOriginal.Shared.Models.EFCoreStoreDB();
            await nwDb.Items.AddAsync(item);
            await nwDb.SaveChangesAsync();

            return item;
        }
    }
}
