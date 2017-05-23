﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMVC.Models
{
    public class StockItem
    {
        //Primary key
        [Key]
        public int ID { get; set; }
        //Proporties
        public string ArticleNumber { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ShelfPosition { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}