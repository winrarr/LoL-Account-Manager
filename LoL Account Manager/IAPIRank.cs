using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoL_Account_Manager
{
    public interface IAPIRank
    {
        string QueueType { get; set; }
        string SummonerName { get; set; }
        bool HotStreak { get; set; }
        int Wins { get; set; }
        bool Veteran { get; set; }
        int Losses { get; set; }
        string Rank { get; set; }
        string Tier { get; set; }
        bool Inactive { get; set; }
        bool FreshBlood { get; set; }
        string LeagueId { get; set; }
        string SummonerId { get; set; }
        int LeaguePoints { get; set; }
    }
}
