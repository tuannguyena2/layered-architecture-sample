using ServiceLayer.Abstractions.DTOs;
using System.Collections.Generic;

namespace ServiceLayer.Abstractions.Services
{
    public interface ISADPService
    {
        IList<TopicDTO> ListAllAvailableTopics();
        IList<EmployeeDTO> ListAllEmployees();
        IList<SubjectDTO> GetSubjectsByTopic(int topicId);
        bool RegisterAssignment(int employeeId, int subjectId);
    }
}
