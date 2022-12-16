using IMS.CoreBusiness;

namespace IMS.UseCases.Interfaces
{
    public interface IViewProductsByNameUseCase
    {
        Task<List<Product>> ExecuteAsync(string name = "");
    }
}