namespace DataService.Service
{
    public class BaseModel
    {
        public bool IsDeleted { get; set; }
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedDate { get; set; } 
        public string CreateBy { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
    }
}
