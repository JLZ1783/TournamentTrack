using TrackerLibrary.Models;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using System.Collections.Generic;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreatePrize(PrizeModel model);
        void CreatePerson(PersonModel model);
        void CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);

        void UpdateMatchup(MatchupModel model);
        List<TeamModel> GetTeams_All();   
        List<PersonModel> GetPerson_All();
        List<TournamentModel> GetTournament_All();

    }
}
