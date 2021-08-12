namespace DataLayer.Entities
{
    public class Assignment : BaseEntity
    {
        public virtual Employee Employee { get; set; }
        public virtual int EmployeeId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual int SubjectId { get; set; }
        public virtual bool IsRegistered { get; set; }
    }
}