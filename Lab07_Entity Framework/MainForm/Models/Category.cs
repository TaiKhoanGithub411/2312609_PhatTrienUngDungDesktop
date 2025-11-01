﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Models
{
    public enum CategoryType
    {
        Drink,
        Food
    }
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CategoryType Type { get; set; }
    }
}
