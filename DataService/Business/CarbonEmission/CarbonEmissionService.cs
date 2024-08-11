using Core.Entities;
using Core.Service;

namespace DataService.Service

{
    public class CarbonEmissionService : ICarbonEmission
    {
        private readonly ICarbonEmissionDbService _DbService;
        public CarbonEmissionService(ICarbonEmissionDbService DbService) {
            _DbService = DbService;
        }

        public async Task<List<CarbonEmissionModel>> GetAll() 
        {
            var entities = await _DbService.GetAll();
            return entities.Select(e => (CarbonEmissionModel)e).ToList();
        }
        public async Task<CarbonEmissionModel> GetById(int Id) => ((CarbonEmissionModel) await _DbService.GetByid(Id)); 
               
        public async Task<List<CarbonEmissionModel>> GetByCompanyId(int CompanyId) 
        {
            var entities = await _DbService.GetFilteredData(CompanyId);
            return entities.Select(e => (CarbonEmissionModel)e).ToList(); ;
        }       
        public async Task<int> CreateCarbonEmission(CarbonEmissionModel model) 
        {
            var valid = await _DbService.Create((CarbonEmissionEntities)model);
            return valid ? model.Id : 0; 
        }
        public async Task<bool> UpdateCarbonEmission(CarbonEmissionModel model) 
        {
            model.IsDeleted = true;
            return await _DbService.Update((CarbonEmissionEntities)model);
        }        
        public async Task<bool> SoftDeleteCarbonEmission(int Id) 
        {
            var SoftDeleteModel = await _DbService.GetByid(Id);
            SoftDeleteModel.IsDeleted = true;
            return await _DbService.Update(SoftDeleteModel);
        }
        public async Task<bool> HardDeleteCarbonEmission(int Id) => (await _DbService.HardDelete(Id));
    }
}
