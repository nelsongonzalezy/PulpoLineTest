using Core.Context;
using Core.Entities;

namespace Core.Service
{
    public class CarbonEmissionDbService : ICarbonEmissionDbService
    {
        private readonly Repository<CarbonEmissionEntities> _repository;

        public CarbonEmissionDbService(DbCoreContext context)
        {
            _repository = new Repository<CarbonEmissionEntities>(context);
        }

        public async Task<bool> Create(CarbonEmissionEntities entity)
        {
            var result = await _repository.Create(entity);
            return result;
        }
        public async Task<bool> Update(CarbonEmissionEntities entity)
        {
            var result = await _repository.Update(entity);
            return result;
        }
        public async Task<bool> HardDelete(int Id)
        {
            var result = await _repository.HardDelete(Id);
            return result;
        }
        public async Task<CarbonEmissionEntities> GetByid(int Id)
        {
            return await _repository.GetByKey(Id);
        }
        public async Task<IEnumerable<CarbonEmissionEntities>> GetAll()
        {
            return await _repository.GetAll();
        }
        public async Task<List<CarbonEmissionEntities>> GetFilteredData(int CompanyId )
        {
                return _repository.GetAllAsync().Result.Where(e => !e.IsDeleted && e.CompanyId == CompanyId).ToList();

        }

    }
}
