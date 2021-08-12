using ServiceLayer.Abstractions.DTOs;
using System.Collections.Generic;

namespace ServiceLayer.Abstractions.Services
{
    public interface ISADPService
    {
        IList<TopicDTO> ListAllAvailableTopics();
        bool RegisterAssignment(int employeeId, int subjectId);
    }
}
