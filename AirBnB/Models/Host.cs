using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AirBnB.Controllers;

namespace AirBnB.Models
{
    public class Host
    {
        public int hostId { get; set; }
        public string hostName { get; set; }
        public HostRoomType hostRoomType { get; set; }
        public string price { get; set; }
        public bool available { get; set; }
    }
}