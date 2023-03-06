using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EasyCRMAppNET.Domain.Entities;
using EasyCRMAppNET.Domain.Interfaces;
using EasyCRMAppNET.Infrastructure;
using EasyCRMAppNET.Infrastructure.IOToTXT;

namespace EasyCRMAppNET.App
{
    internal class CategoryService : ICategoryService //Validation,Business Rules,Create Operation
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = IOCContainer.Resolve<IRepository<Category>>();
        }

        public void Create(int id, string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Kategori adı boş olmamalı!!");

            var oldCategory = _categoryRepository.GetList().FirstOrDefault(c => c.Name == name);
            if (oldCategory != null)
                return;

            Category category= new Category();
            category.Id = id;
            category.Name = name.ToUpper();
            _categoryRepository.Add(category);
        }

        public bool Delete(int categoryId)
        {
            return _categoryRepository.Remove(categoryId);
        }

        public IReadOnlyCollection<Category> GetCategories()
        {
            return _categoryRepository.GetList().ToList().AsReadOnly();
        }

        public Category Update(int categoryId, string newCategoryName)
        {
            if (string.IsNullOrWhiteSpace(newCategoryName))
                throw new ArgumentNullException("Kategori adı boş olmamalı!!");

            var category= new Category();
            category.Id = categoryId;
            category.Name = newCategoryName.ToUpper();
            return _categoryRepository.Update(categoryId, category);
        }
    }
}
