namespace ChapeauModel
{
    public enum EmployeeType
    {
        Manager,
        Chef,
        Bartender,
        Waiter
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get { return FirstName + " " + LastName; } }
        public EmployeeType EmployeeType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

    }
}