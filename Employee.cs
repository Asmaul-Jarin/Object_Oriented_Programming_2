class Employee
{
    public int sal;
    private string id, name, jd;
    public Employee(string id, string name, int sal, string jd)
    {
        this.id = id;
        this.name = name;
        this.sal = sal;
        this.jd = jd;
    }

    public void displayEmp()
    {
        Console.WriteLine("ID:" + id);
        Console.WriteLine("Name:" + name);
        Console.WriteLine("Salary:" + sal);
        Console.WriteLine(" joining date:" + jd);
    }
}
