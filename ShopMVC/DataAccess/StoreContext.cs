﻿using System.Data.Entity;

namespace ShopMVC.DataAccess
{
    //a context for handling Items from database
    public class StoreContext : DbContext
    {
        public DbSet<Models.StockItem> Items { get; set; }
        public StoreContext() : base("DefaultConnection") { }
    }
}