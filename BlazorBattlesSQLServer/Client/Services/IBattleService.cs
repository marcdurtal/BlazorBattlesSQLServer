using BlazorBattlesSQLServer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattlesSQLServer.Client.Services
{
    public interface IBattleService
    {
        Task<BattleResult> StartBattle(int opponentId);
        BattleResult LastBattle { get; set; }
    }
}
