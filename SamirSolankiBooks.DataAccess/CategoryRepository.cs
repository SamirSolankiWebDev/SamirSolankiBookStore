using SamirSolankiBooks.DataAccess.Repository.IRepository;
using SamirSolankiBooks.Models;
using SamirSolankiBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamirSolankiBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();

            var objFromDb = _db.Categories.FirstOrDefault(sbyte => sbyte.Id == category.Id);
        }
            

    }
}
