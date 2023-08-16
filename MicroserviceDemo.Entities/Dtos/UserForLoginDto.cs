using MicroserviceDemo.Core.Entities;

namespace MicroserviceDemo.Entities.Dtos
{
    public class UserForLoginDto : IDto
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
