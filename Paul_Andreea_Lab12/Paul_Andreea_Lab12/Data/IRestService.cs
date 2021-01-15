using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Paul_Andreea_Lab12.Models;
using Paul_Andreea_Lab12.Data;

namespace Paul_Andreea_Lab12.Data
{
        public interface IRestService
    {
        List<ShopList> Items { get; }

        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
        Task SaveShopListAsync(ShopList item, bool isNewItem = true);
        Task SaveShopListAsync(ShopList item, bool isNewItem = true);
    }
}
