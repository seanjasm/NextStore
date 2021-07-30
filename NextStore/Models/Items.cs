using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextStore.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string name { get; set; }

        public ItemType itemType { get; set; }
    }
}
