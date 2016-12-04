using System;

class Program
{
    public static void Main()
    {
        Encapsulation encp = new Encapsulation();
        encp.ID = -100;
       
        Console.WriteLine("Id =" + encp.ID );

    }
}
public class Encapsulation
{
    private  int id;
    private string Name;
    private int PassMarks;
    public int ID
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Id cannot be negative");
            }
            this.id = value;

        }
        get
        {
            return this.id;
        }
        
        


        
    }
    

}
