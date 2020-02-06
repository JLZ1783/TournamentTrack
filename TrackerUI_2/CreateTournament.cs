using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI_2
{
    public partial class CreateTournament : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeams_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournament()
        {
         InitializeComponent();
            
            WireUpLists();
        }

        private void WireUpLists()
        {
            SelectTeamDropDown.DataSource = null;
            SelectTeamDropDown.DataSource = availableTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";

            TournamentTeamsListBox.DataSource = null;
            TournamentTeamsListBox.DataSource = selectedTeams;
            TournamentTeamsListBox.DisplayMember = "TeamName";

            PrizesListBox.DataSource = null;
            PrizesListBox.DataSource = selectedPrizes;
            PrizesListBox.DisplayMember = "PlaceName";
        }

        private void CreateTournament_Load(object sender, EventArgs e)
        {

        }

        private void RemoveSelectedTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)TournamentTeamsListBox.SelectedItem;
            if( t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }
                     
        private void RemoveSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizesListBox.SelectedItem;

            if(p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();

            }
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
          {
            TeamModel t = (TeamModel)SelectTeamDropDown.SelectedItem;

            if( t != null )
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
                                              
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            //Call create prize form
            CreatePrize frm = new CreatePrize(this);
            frm.Show();
                                  
        }

        public void PrizeComplete(PrizeModel model)
        {
            // get back from the form PrizeModel
            // Take the ProeModel and put it into list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }
        private void CreateNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            //Create tournament model
            TournamentModel tm = new TournamentModel();
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee",
                    "Invalid Fee", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeamsList = selectedTeams;

            //TODO Wire up matchups
            TournamentLogic.CreateRounds(tm);
                        
            //Create Tournament Entry
            //Create all of the prizes entries
            //create all of the team entries
            GlobalConfig.Connection.CreateTournament(tm);

            TournamentViewer frm = new TournamentViewer(tm);
            frm.Show();
            this.Close();


        }
    }
}
