using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace problem2
{
    class ShoppingCart<T> where T:Items
    {
        ArrayList items = new ArrayList();
        public void AddItem(string item)
        {
            items.Add(item);
        }
        public void RemoveItem(string item)
        {
            items.Remove(item);
        }
        public void ClearCart()
        {
              items.Clear();          
        }

    }
}
