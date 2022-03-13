using AwesomeGymLive.Domain.Entities;
using AwesomeGymLive.Domain.Interfaces;
using MediatR;

namespace AwesomeGymLive.Application.Commands.AddStudent
{
    public class AddStudentCommandHandler : IRequestHandler<AddStudentCommand, Unit>
    {
        private readonly IStudentRepository studentRepository;
        public AddStudentCommandHandler(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public Task<Unit> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student(request.FullName, request.BirthDate);
            studentRepository.Add(student);
            return Task.FromResult(Unit.Value);
        }
    }
}
