class PartTime : Employee
{
    private int c, t2;
    public PartTime(string id, string name, int sal, string jd, int c) : base(id, name, sal, jd)
    {
        this.c = c;
    }

    public void GrossIncome()
    {
        t2 = ((12 * sal) + c);
        Console.WriteLine(" income:" + t2);
    }

    public void ShowInfo()
    {
        base.displayEmp();
        Console.WriteLine("Commition:" + c);
    }
}
