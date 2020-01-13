using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoL_Account_Manager
{
    public class Account : IAPIAccount, IAPIRank
    {
        public Account(APIAccount apia, APIRank apir, string username, string password, string server)
        {
            this.Username = username;
            this.Password = password;
            this.Server = server;
            if (apia != null)
            {
                addAPIAccount(apia);
            }
            if (apir != null)
            {
                addAPIRank(apir);
            }
        }

        #region credentials
        public string Username { get; set; }
        public string Password { get; set; }
        public string Server { get; set; }
        #endregion

        #region apia
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string Puuid { get; set; }
        public string Name { get; set; }
        public string ProfileIconId { get; set; }
        public string RevisionDate { get; set; }
        public string SummonerLevel { get; set; }
        #endregion

        #region apir
        public string QueueType { get; set; }
        public string SummonerName { get; set; }
        public bool HotStreak { get; set; }
        public int Wins { get; set; }
        public bool Veteran { get; set; }
        public int Losses { get; set; }
        public string Rank { get; set; }
        public string Tier { get; set; }
        public bool Inactive { get; set; }
        public bool FreshBlood { get; set; }
        public string LeagueId { get; set; }
        public string SummonerId { get; set; }
        public int LeaguePoints { get; set; }
        #endregion

        public void addAPIAccount(APIAccount account)
        {
            Id = account.Id;
            AccountId = account.AccountId;
            Puuid = account.Puuid;
            Name = account.Name;
            ProfileIconId = account.ProfileIconId;
            RevisionDate = account.RevisionDate;
            SummonerLevel = account.SummonerLevel;
        }

        public void addAPIRank(APIRank rank)
        {
            QueueType = rank.QueueType;
            SummonerName = rank.SummonerName;
            HotStreak = rank.HotStreak;
            Wins = rank.Wins;
            Veteran = rank.Veteran;
            Losses = rank.Losses;
            Rank = rank.Rank;
            Tier = rank.Tier;
            Inactive = rank.Inactive;
            FreshBlood = rank.FreshBlood;
            LeagueId = rank.LeagueId;
            SummonerId = rank.SummonerId;
            LeaguePoints = rank.LeaguePoints;
        }
    }
}
