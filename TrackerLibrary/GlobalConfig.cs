using System;
using System.Collections.Generic;
using System.Configuration;
using TrackerLibrary.DataAccess;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string Tournamentfile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";

        public static IDataConnection Connection { get; private set; } 
        
        public static void InitializeConnections(DatabaseType db)
        {
          
            
            if (db == DatabaseType.Sql)
            {
                //TODO- Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            else if (db == DatabaseType.TextFile)
            {

                //TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }

        }

        public static void InitializeConnections(object sql)
        {
            throw new NotImplementedException();
        }



        public static string CnnString(string name)
        {
          return  ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppKeyLookup(string key)
        {
           return ConfigurationManager.AppSettings[key];
        }
    }
}
