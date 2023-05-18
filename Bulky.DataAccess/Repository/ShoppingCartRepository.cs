﻿using SOBeCommerce.DataAccess.Repository.IRepository;
using SOBeCommerce.DataAcess.Data;
using SOBeCommerce.Models;


namespace SOBeCommerce.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository {
        private ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        

        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
