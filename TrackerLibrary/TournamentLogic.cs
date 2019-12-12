using System;
using System.Collections.Generic;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary
{



    public static class TournamentLogic
    {
        // ORDER our list randomly
        //2*2*2*2 2^4 (2^n)

        // check if big enough - if not add byes - teams = 2^n
        // Create first round of matchups
        // create every round after that - 8 matchups - 4 - 2 - 1 (each matchup is 2 teamIds or 1 teamId & 1 bye)
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeamsList);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);

            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));

            CreateOtherRounds(model, rounds);
        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });

                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }
                model.Rounds.Add(currRound);
                previousRound = currRound;
                currRound = new List<MatchupModel>();
                round += 1;
               

               
               

            }
        }
        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();

            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                if (byes > 0 || curr.Entries.Count > 1) // is this where we get 2 teams per matchup???
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();

                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }
            return output;
        }

        //TODO - Use this as an example of calculating the number of something.
        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0; //lesson 18 time 44:06
            int totalTeams = 1;

            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }
            output = totalTeams - numberOfTeams;
            return output;
        }
        // TODO  Where does a method parameter come from? 
        // Where is teamCount's value coming from?? It gets passed in during the CreateRounds() method when we first find a list of team model called randomizedTeams. The int rounds property calls the method below and passes in randomizedteams.count as 'int teamCount'.....Each method does not generate it own parameters rather parameters are assigned at the time the method is called. Apples?
        //
        private static int FindNumberOfRounds(int teamCount)
        {
            //Initialize variables
            int output = 1;
            int val = 2;
            //Enter While loop and change the abo variables

            while (val < teamCount)
            {
                //output **OF THE METHOD** = output + 1
                output += 1;
                // val = val * 2
                val *= 2;
            }
            return output;
        }
        //TODO Randomize a list using this example
        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            // teams.OrderBy(x => Guid.NewGuid()).ToList();
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
