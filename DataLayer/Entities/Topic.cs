using System.Collections.Generic;

namespace DataLayer.Entities
{
    public class Topic : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}