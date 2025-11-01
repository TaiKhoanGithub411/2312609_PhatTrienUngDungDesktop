using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Models
{
    public class FoodModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string CategoryName { get; set; }
        public string Notes { get; set; }
        public int Price { get; set; }
    }
}
