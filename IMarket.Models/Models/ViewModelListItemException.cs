using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMarket.Models.Models
{
    public class ViewModelListItemException : ViewModelListItem
    {
        public DateTime DeliveryTime { get; set; }

        public DateTime ReceivedTime { get; set; }
    }
}
