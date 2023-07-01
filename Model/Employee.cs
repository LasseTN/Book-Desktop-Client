namespace Model {
    public class Employee {
        public int? EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Employee() { }

        public Employee(int employeeId, string firstName, string lastName, DateTime birthDate, string address, string phone, string email) {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Address = address;
            Phone = phone;
            Email = email;
        }
    }
}
