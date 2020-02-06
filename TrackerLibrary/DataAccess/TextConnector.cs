using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void CreatePerson(PersonModel model)
        {
            //Load the text file and convert the text to List<PersoModel>
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            people.Add(model);

            people.SaveToPeopleFile();

            
        }

        //TODO - Wire up the CreatePrize for text files.
        public void CreatePrize(PrizeModel model)
        {
            // Load Text file and convert the text fito list<PrizeModel>

            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find Max ID
            int currentId = 1;
            if (prizes.Count > 0)
            {
                int currentID = prizes.OrderByDescending(x => x.Id).First().Id + 1;

            }

            model.Id = currentId;


            //Add new record with the new ID
            prizes.Add(model);

            //Convert the prizes to list<string>
            // Save the list<string> tp the text file

            prizes.SaveToPrizeFile();

           
        }

        public void  CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
           
            int currentId = 1;
            if (teams.Count > 0)
            {
                 currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;

            }

            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile();

            
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.Tournamentfile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();
            
            int currentId = 1;

            if(tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            model.SaveRoundsToFile();

            tournaments.Add(model);

            tournaments.SaveToTournamentFile();
            
            TournamentLogic.UpdateTournamentResults(model);
        }

        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetTeams_All()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public List<TournamentModel> GetTournament_All()
        {
          return GlobalConfig.Tournamentfile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }
    }
}