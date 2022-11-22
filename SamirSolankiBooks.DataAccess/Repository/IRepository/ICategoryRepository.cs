using SamirSolankiBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace SamirSolankiBooks.DataAccess.Repository.IRepository
{
   public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
