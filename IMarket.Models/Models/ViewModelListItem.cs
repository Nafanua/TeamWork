using System.Collections.Generic;

namespace IMarket.Models.Models
{
    public class ViewModelListItem
    {
        public string Name { get; set; }

        public IEnumerable<ItemBase> ItemList { get; set; }
    }
}