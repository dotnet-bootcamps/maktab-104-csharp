using S40_AspNetCore_DI.Contracts;
using S40_AspNetCore_DI.Infrastructures;

namespace S40_AspNetCore_DI.Domain
{
    public class MessageCreator
    {
        private readonly IStudentRepository _repository;

        public MessageCreator(IStudentRepository repository
            // ,StudentInMemoryRepository repository
            // ,StudentEfRepository repository
            )
        {
            _repository = repository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="studentCode"></param>
        /// <param name="message">use {StudentName} PlaceHolder To Add Student Name in the message</param>
        public string Create(int studentCode, string message)
        {
            // var repo = new StudentInMemoryRepository();


            var studentName = _repository.GetStudentName(studentCode, "20");
            return message.Replace("{StudentName}", studentName);
        }
    }
}
