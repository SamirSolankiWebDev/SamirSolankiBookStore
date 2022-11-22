using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SamirSolankiBooks.DataAccess.Repository.IRepository;
using SamirSolankiBookStore.DataAccess.Data;
using SamirSolankiBooks.Models;

namespace SamirSolankiBooks.DataAccess.Repository

{
   public class CategoryRepository: Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }
        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb!=null)
            {
                objFromDb.Name = category.Name;
               
            }
        }
    }
}
