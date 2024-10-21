using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFO.Auth.Infrastructure;

namespace WFO.Auth.ApplicationService.AuthModule
{
    public abstract class AuthServiceBase
    {
        protected readonly ILogger _logger;
        protected readonly AuthDbContext _authContext;

        protected AuthServiceBase(ILogger logger, AuthDbContext authContext)
        {
            _logger = logger;
            _authContext = authContext;
        }
    }
}
