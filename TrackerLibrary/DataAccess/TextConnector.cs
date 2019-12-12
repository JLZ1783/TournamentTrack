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
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string Tournamentfile = "TournamentModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            //Load the text file and convert the text to List<PersoModel>
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            people.Add(model);

            people.SaveToPeopleFile(PeopleFile);

            return model;
        }

        //TODO - Wire up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load Text file and convert the text fito list<PrizeModel>

            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

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

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
            int currentId = 1;
            if (teams.Count > 0)
            {
                int currentID = teams.OrderByDescending(x => x.Id).First().Id + 1;

            }

            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);

            return model;
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = Tournamentfile.FullFilePath().LoadFile()
                .ConvertToTournamentModels(TeamFile, PeopleFile, PrizesFile);
            
            int currentId = 1;

            if(tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            tournaments.Add(model);

            tournaments.SaveToTournamentFile(Tournamentfile);
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetTeams_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
        }

    }
}