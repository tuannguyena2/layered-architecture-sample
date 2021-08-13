using DataLayer.Abstractions;
using DataLayer.Abstractions.Repositories;
using DataLayer.Entities;
using ServiceLayer.Abstractions.Services;
using ServiceLayer.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer.Services
{
    class SADPService : ISADPService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ITopicRepository _topicRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IAssignmentRepository _assignmentRepository;

        public SADPService(IUnitOfWork unitOfWork,
            IEmployeeRepository employeeRepository, ITopicRepository topicRepository,
            ISubjectRepository subjectRepository, IAssignmentRepository assignmentRepository)
        {
            _unitOfWork = unitOfWork;
            _employeeRepository = employeeRepository;
            _topicRepository = topicRepository;
            _subjectRepository = subjectRepository;
            _assignmentRepository = assignmentRepository;
        }

        public IList<TopicDTO> ListAllAvailableTopics()
        {
            var availableTopics = new List<TopicDTO>();

            var topics = _topicRepository.GetAll().ToList();
            foreach (var topic in topics)
            {
                var subjects = _subjectRepository.GetWhere(s => s.TopicId == topic.Id).ToList();
                var data = new TopicDTO
                {
                    Id = topic.Id,
                    Name = topic.Name,
                    Subjects = subjects.Select(s => new SubjectDTO { Id = s.Id, Name = s.Name })
                };

                availableTopics.Add(data);
            }

            return availableTopics;
        }

        public IList<EmployeeDTO> ListAllEmployees()
        {
            var employees = _employeeRepository.GetAll();
            return employees.Select(s => new EmployeeDTO { Id = s.Id, Name = s.Name }).ToList();
        }

        public IList<SubjectDTO> GetSubjectsByTopic(int topicId)
        {
            var subjects = _subjectRepository.GetWhere(x => x.TopicId == topicId);
            return subjects.Select(s => new SubjectDTO { Id = s.Id, Name = s.Name }).ToList();
        }

        public bool RegisterAssignment(int employeeId, int subjectId)
        {
            var emp = _employeeRepository.GetById(employeeId);
            var sub = _subjectRepository.GetById(subjectId);

            if (emp != null && sub != null)
            {
                var assignmentEntity = new Assignment
                {
                    EmployeeId = employeeId,
                    SubjectId = subjectId,
                    IsRegistered = true
                };

                _assignmentRepository.Add(assignmentEntity);
                _unitOfWork.Commit();

                return true;
            }

            return false;
        }
    }
}
