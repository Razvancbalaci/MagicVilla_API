using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
    public interface IVillaNumberService
    {
        Task<T> GetAll<T>(string token);
        Task<T> Get<T>(int id, string token);
        Task<T> Create<T>(VillaNumberCreateDTO dto, string token);  
        Task<T> Update<T>(VillaNumberUpdateDTO dto, string token);
        Task<T> Delete<T>(int id, string token);
    }
}
