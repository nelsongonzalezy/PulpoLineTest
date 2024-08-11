using Core.Entities;

namespace DataService.Service
{
    public class CarbonEmissionModel : BaseModel
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal CarbonEmissionValues { get; set; }
        public DateTime DateCarbonEmission { get; set; }
        public string TypeCarbonEmission { get; set; } = string.Empty;


        public static explicit operator CarbonEmissionEntities(CarbonEmissionModel model)
        {
            return new CarbonEmissionEntities
            {
                Id = model.Id,
                CompanyId = model.CompanyId,
                Description = model.Description,
                CarbonEmissionValues = model.CarbonEmissionValues,
                DateCarbonEmission = model.DateCarbonEmission,
                TypeCarbonEmission = model.TypeCarbonEmission,
                IsDeleted = model.IsDeleted,
                ModifiedBy =model.ModifiedBy,
                ModifiedDate = model.ModifiedDate,
                CreateBy =model.CreateBy,
                CreateDate =model.CreateDate,
            };
        }
        public static explicit operator CarbonEmissionModel(CarbonEmissionEntities entities)
        {
            return new CarbonEmissionModel
            {
                Id = entities.Id,
                CompanyId = entities.CompanyId,
                Description = entities.Description,
                CarbonEmissionValues = entities.CarbonEmissionValues,
                DateCarbonEmission = entities.DateCarbonEmission,
                TypeCarbonEmission = entities.TypeCarbonEmission,
                IsDeleted = entities.IsDeleted,
                ModifiedBy = entities.ModifiedBy,
                ModifiedDate = entities.ModifiedDate    ,
                CreateBy = entities.CreateBy,
                CreateDate = entities.CreateDate,
            };
        }
    }
}
