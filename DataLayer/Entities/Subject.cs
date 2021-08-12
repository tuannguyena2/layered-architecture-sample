using System.Collections.Generic;

namespace DataLayer.Entities
{
    public class Subject : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual int TopicId { get; set; }
        public virtual ICollection<Assignment> Asssigments { get; set; }
    }
}