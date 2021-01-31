using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBnB.Models
{
    public class Host
    {
        public int hostId { get; set; }
        public string hostName { get; set; }
        public string hostRoomType { get; set; }
        public string price { get; set; }
        public bool available { get; set; }
    }
}