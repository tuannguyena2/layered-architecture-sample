using System.Collections.Generic;

namespace ServiceLayer.Abstractions.DTOs
{
    public class TopicDTO : BaseDTO
    {
        public IEnumerable<SubjectDTO> Subjects { get; set; }
    }
}
