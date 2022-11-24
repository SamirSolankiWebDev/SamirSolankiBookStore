using System;
using System.Collections.Generic;
using System.Text;

namespace SamirSolankiBooks.DataAccess.Repository.IRepository
{

    public interface  IProductRepository : IRepository<Product>
    {
        void Update(IProductRepository product);
    }
 /*  public void Update (Product product)
    {
        var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
        if(objFromDb != null)  // save changes if not null
        {
            if (product.ImageUrl != null)
            {
                objFromDb.ImageUrl = product.ImageUrl; // add the check for Imae=geUrl
            }
            objFromDb.Title = product.Title;
            objFromDb.Description = product.Description;
            objFromDb.ISBN = product.ISBN;
            objFromDb.Author = product.Author;
            objFromDb.ListPrice = product.ListPrice;
            objFromDb.CategoryId = product.CategoryId;
            objFromDb.CoverTypeId = product.CoverTypeId;   // all properties of Product object

        }
    }*/
}
