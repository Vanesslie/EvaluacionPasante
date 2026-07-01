namespace API_pasantia.models.Interfaces;

public interface IProduct
{
    IQueryable<Product> GetSearchQuery(
        string? name,
        int? productTypeId,
        bool orderByIdAscending);
    Task<IReadOnlyList<Product>> GetActiveWithProductTypeAsync(CancellationToken cancellationToken = default);
    Task<Product?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<Product> AddAsync(Product producto, CancellationToken cancellationToken = default);
    Task<Product> DeactivateAsync(Product producto, CancellationToken cancellationToken = default);

}