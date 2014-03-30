using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtlasWichita.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public int Formal { get; set; }
        public int Conformist { get; set; }
        public int BlueCollar { get; set; }
        public int Simple { get; set; }
        public int Trendy { get; set; }
        public int Gritty { get; set; }
        public int Independent { get; set; }
        public int Local { get; set; }
        public int Energetic { get; set; }
        public int Modern { get; set; }
        public int Elegant { get; set; }
    }
}