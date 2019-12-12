namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique ID for Prize
        /// </summary>
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
            
        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberTextbox = 0;
            int.TryParse(placeNumber, out placeNumberTextbox);
            PlaceNumber = placeNumberTextbox;

            decimal prizeAmountTextBox = 0;
            decimal.TryParse(prizeAmount, out prizeAmountTextBox);
            PrizeAmount = prizeAmountTextBox;

            double prizePercentageTextBox = 0;
            double.TryParse(prizePercentage, out prizePercentageTextBox);
            PrizePercentage = prizePercentageTextBox;


        }
    }

}
