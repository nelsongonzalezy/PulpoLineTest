namespace DataService.Service
{
    public interface ICarbonEmission
    {
        Task<List<CarbonEmissionModel>> GetAll();
        Task<CarbonEmissionModel> GetById(int Id);
        Task<List<CarbonEmissionModel>> GetByCompanyId(int CompanyId);
        Task<int> CreateCarbonEmission(CarbonEmissionModel model);
        Task<bool> UpdateCarbonEmission(CarbonEmissionModel model);
        Task<bool> SoftDeleteCarbonEmission(int Id);
        Task<bool> HardDeleteCarbonEmission(int Id);

    }
}
