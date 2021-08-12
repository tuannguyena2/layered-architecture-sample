using ServiceLayer.Abstractions.DTOs;
using System.Collections.Generic;

namespace WebApp.Models
{
    public class TopicViewModel
    {
        public List<TopicDTO> Topics { get; set; } = new List<TopicDTO>();
    }
}
