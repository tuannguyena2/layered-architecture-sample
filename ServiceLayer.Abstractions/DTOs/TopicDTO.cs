using System.Collections.Generic;

namespace ServiceLayer.Abstractions.DTOs
{
    public class TopicDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<SubjectDTO> Subjects { get; set; }
    }
}
