using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("MainProg.Test")]

namespace MainProg
{
    
    internal class Items
    {
        public Items()
        {
            list = new Dictionary<string, Item>();
        }
        public Dictionary<string, Item> list { get; set; }
        public void Load()
        {
            list.Add("a", new Item() { Id = 1, Name = "banana" });
            list.Add("b", new Item() { Id = 2, Name = "apple" });
            list.Add("c", new Item() { Id = 3, Name = "grape" });
        }

        public int Calc(string itemName,int count)
        {
            Item item = list[itemName];
            return item.Price* count;
        }

        public int Plus(int a,int b)
        {
            return a + b ;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
}
