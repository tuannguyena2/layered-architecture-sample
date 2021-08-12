using System.Collections.Generic;

namespace DomainLayer.Entities
{
    public class Topic : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}