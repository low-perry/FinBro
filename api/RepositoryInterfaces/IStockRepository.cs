
using api.DTOs.Stock;
using api.helpers;
using api.Models;

namespace api.RepositoryInterfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject query);
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock> CreateAsync(Stock stock);
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto updateStockRequestDto);
        Task<Stock?> DeleteAsync(int id);

        Task<bool> StockExists(int id);

    }
}