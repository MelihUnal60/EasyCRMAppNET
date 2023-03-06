using EasyCRMAppNET.Domain.Entities;
using EasyCRMAppNET.Domain.Interfaces;

namespace EasyCRMAppNET.App
{
    public interface ICategoryService
    {
        void Create(int id, string name);

        bool Delete(int categoryId);

        IReadOnlyCollection<Category> GetCategories();

        Category Update(int categoryId,string newCategoryName);

    }
}