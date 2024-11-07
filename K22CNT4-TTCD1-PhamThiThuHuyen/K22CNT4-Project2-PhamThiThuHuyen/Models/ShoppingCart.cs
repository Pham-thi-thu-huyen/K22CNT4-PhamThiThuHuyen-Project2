using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K22CNT4_Project2_PhamThiThuHuyen.Models
{
    public class ShoppingCart
    {
        private List<cartItem> _items = new List<cartItem>();

        public void AddItem(int itemId, string itemName, decimal price, int quantity)
        {
            var existingItem = _items.FirstOrDefault(i => i.ItemId == itemId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _items.Add(new cartItem
                {
                    ItemId = itemId,
                    ItemName = itemName,
                    Price = price,
                    Quantity = quantity
                });
            }
        }

        public void RemoveItem(int itemId)
        {
            var item = _items.FirstOrDefault(i => i.ItemId == itemId);
            if (item != null)
            {
                _items.Remove(item);
            }
        }

        public decimal GetTotal()
        {
            return _items.Sum(i => i.Price * i.Quantity);
        }

        public List<cartItem> GetItems()
        {
            return _items;
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}