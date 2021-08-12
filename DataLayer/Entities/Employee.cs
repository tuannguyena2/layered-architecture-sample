using System.Collections.Generic;

namespace DataLayer.Entities
{
    public class Employee : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Department { get; set; }
        public virtual string WorkingProject { get; set; }
        public virtual ICollection<Assignment> Asssigments { get; set; }
    }
}