namespace Core.Entities
{
    public class CarbonEmissionEntities : BaseEntities
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal CarbonEmissionValues { get; set; }
        public DateTime DateCarbonEmission { get; set; } 
        public string TypeCarbonEmission { get; set; } = string.Empty;

    }
}
