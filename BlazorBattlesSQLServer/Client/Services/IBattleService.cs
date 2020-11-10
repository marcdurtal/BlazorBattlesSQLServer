using BlazorBattlesSQLServer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattlesSQLServer.Client.Services
{
    public interface IBattleService
    {
        IList<BattleHistoryEntry> History { get; set; }
        Task<BattleResult> StartBattle(int opponentId);
        BattleResult LastBattle { get; set; }
        Task GetHistory();
    }
}
