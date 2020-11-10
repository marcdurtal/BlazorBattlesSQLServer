using BlazorBattlesSQLServer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattlesSQLServer.Server.Services
{
    public interface IUtilityService
    {
        Task<User> GetUser();
    }
}
