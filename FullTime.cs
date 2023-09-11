class FullTime : Employee
{
    private int b, total;
    public FullTime(string id, string name, int sal, string jd, int b) : base(id, name, sal, jd)
    {
        this.b = b;
    }

    public void GrossIncome()
    {
        total = ((12 * sal) + (2 * b));
        Console.WriteLine(" income:" + total);
    }
    public void ShowInfo()
    {
        base.displayEmp();
        Console.WriteLine("Bonus:" + b);
    }
}
