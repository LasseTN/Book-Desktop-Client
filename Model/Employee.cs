namespace Model {
    public class Employee {

        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Employee() { }

        public Employee(int id, string firstName, string lastName, DateTime birthdate, string address, string phone, string email) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthdate;
            Address = address;
            Phone = phone;
            Email = email;
        }
    }
}