using System.Collections.Generic;

namespace ServiceLayer.DTOs
{
    public class TopicDTO : BaseDTO
    {
        public IEnumerable<SubjectDTO> Subjects { get; set; }
    }
}
