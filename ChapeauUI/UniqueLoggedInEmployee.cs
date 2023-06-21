using ChapeauModel;

namespace ChapeauUI;

public class UniqueLoggedInEmployee
{
    private static UniqueLoggedInEmployee uniqueInstance; //Singleton Pattern
    private Employee loggedEmployee;

    private UniqueLoggedInEmployee()
    {
        loggedEmployee = new Employee();
    }

    public static UniqueLoggedInEmployee GetInstance()
    {
        if (uniqueInstance == null)
            uniqueInstance = new UniqueLoggedInEmployee();

        return uniqueInstance;
    }

    public Employee GetEmployee()
    {
        return loggedEmployee;
    }

    public void LogEmployee(Employee employee)
    {
        loggedEmployee = employee;
    }
}