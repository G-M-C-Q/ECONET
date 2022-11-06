namespace EconetBlazor.Server.Services.ProductService
{
    public interface IProductService

    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
        Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchText, int page);
        Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);
        Task<ServiceResponse<List<Product>>> GetFeaturedProducts();
    }
    
    
    /*{
        //get products 
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        //get individual product 
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        //get product category 
        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
        //search products 
        Task<ServiceResponse<List<Product>>> SearchProducts(string searchText);

        //pagination search result
        Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchText, int page);
        Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);
        Task<ServiceResponse<List<Product>>> GetFeaturedProducts();
    }*/
}