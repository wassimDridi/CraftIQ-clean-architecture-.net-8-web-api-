using CraftIQ.Inventory.Shared.Contracts.Categories;

namespace CraftIQ.Inventory.Core.Interfaces
{
    public interface ICategoriesServices
    {
        ValueTask<CategoriesOperationsContract> CreateCategory(CategoriesOperationsContract contract);
        ValueTask<List<CategoriesContract>> ReadCategories();
        ValueTask<CategoriesContract> ReadCategoryById(Guid categoryld);
        ValueTask UpdateCategory(Guid categoryld , CategoriesOperationsContract contract);
        ValueTask DeleteCategory(Guid categoryld);
    }
}
