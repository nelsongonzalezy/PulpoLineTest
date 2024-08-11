using Core.Entities;

namespace Core.Service
{
    public interface ICarbonEmissionDbService
    {
        Task<bool> Create(CarbonEmissionEntities entity);
        Task<bool> Update(CarbonEmissionEntities entity);
        Task<bool> HardDelete(int Id);
        Task<CarbonEmissionEntities> GetByid(int Id);
        Task<IEnumerable<CarbonEmissionEntities>> GetAll();
        Task<List<CarbonEmissionEntities>> GetFilteredData(int CompanyId);

    }
}
