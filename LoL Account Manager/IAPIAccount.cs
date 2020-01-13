using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoL_Account_Manager
{
    public interface IAPIAccount
    {
        string Id { get; set; }
        string AccountId { get; set; }
        string Puuid { get; set; }
        string Name { get; set; }
        string ProfileIconId { get; set; }
        string RevisionDate { get; set; }
        string SummonerLevel { get; set; }
    }
}
