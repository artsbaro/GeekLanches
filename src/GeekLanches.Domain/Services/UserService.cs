using SIP.Domain.Entities;
using SIP.Domain.Interfaces.Repositories;
using SIP.Domain.Interfaces.Services;


namespace SIP.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) 
            : base(userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
