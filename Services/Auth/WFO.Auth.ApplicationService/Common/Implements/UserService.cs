using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFO.Auth.ApplicationService.AuthModule;
using WFO.Auth.ApplicationService.Common.Abstracts;
using WFO.Auth.Infrastructure;

namespace WFO.Auth.ApplicationService.Common.Implements
{
    public class UserService : AuthServiceBase, IUserService
    {
        public UserService(ILogger<UserService> logger, AuthDbContext dbContext) : base(logger, dbContext)
        {
        }
        public void HelloWord()
        {

        }
    }
}
