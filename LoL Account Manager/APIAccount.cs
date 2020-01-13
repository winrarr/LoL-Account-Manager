using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoL_Account_Manager
{
    public class APIAccount : IAPIAccount
    {
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string Puuid { get; set; }
        public string Name { get; set; }
        public string ProfileIconId { get; set; }
        public string RevisionDate { get; set; }
        public string SummonerLevel { get; set; }
    }
}
