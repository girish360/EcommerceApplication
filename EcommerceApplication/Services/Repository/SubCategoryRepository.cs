using System.Collections.Generic;
using System.Linq;
using EcommerceApplication.Models;
using EcommerceApplication.DataContext;
using EcommerceApplication.Services.Infrastructure;

namespace EcommerceApplication.Services.Repository
{
    public class SubCategoryRepository : ISubCategory
    {
        private MyContext _db;

        public SubCategoryRepository(MyContext db)
        {
            _db = db;
        }
        public int Count()
        {
            return _db.SubCategory.Count();
        }

        public void Delete(int id)
        {
            var SubCategory = GetById(id);
            if (SubCategory != null)
            {
                _db.SubCategory.Remove(SubCategory);
            }
        }

        public IEnumerable<SubCategory> GetAll()
        {
            return _db.SubCategory.Select(c => c);
        }

        public SubCategory GetById(int id)
        {
            return _db.SubCategory.FirstOrDefault(c => c.SubCategoryId == id);
        }   

        public void Insert(SubCategory subCat)
        {
            _db.SubCategory.Add(subCat);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(SubCategory subCat)
        {
            _db.SubCategory.Update(subCat);
        }
    }
}
