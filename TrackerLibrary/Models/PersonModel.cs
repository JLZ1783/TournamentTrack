namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhoneNumber { get; set; }

        public int Id { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }

        }   
        public PersonModel()
        {

        }
        public PersonModel(
            string firstName, string lastName, string emailAddress, string cellPhoneNumber)
        {
            FirstName = firstName;

            LastName = lastName;

            EmailAddress = emailAddress;

            CellPhoneNumber = cellPhoneNumber;

           
        }
    }
}

