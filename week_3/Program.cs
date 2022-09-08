using System;

public class Program{
    public static void Main(string[] args){

        inputInformation();
    Printinfor();
    exchange.money_in();
    

    }
    public static void Printinfor(){
        Console.WriteLine("Name : {0}",MediagarnKar.Name);
        Console.WriteLine("Name : {0}",MediagarnKar.Number);
        Console.WriteLine("Name : {0}",MediagarnKar.OWnerName);
        Console.WriteLine("Name : {0}",MediagarnKar.RegisValue);
    }

     public static void inputInformation(){
         Console.WriteLine("Please Input Name");
        MediagarnKar.Name = Console.ReadLine();
        Console.WriteLine("Pleas input Number");
        MediagarnKar.Number = Console.ReadLine();
        Console.WriteLine("Pleas input OwnerName");
        MediagarnKar.OWnerName = Console.ReadLine();
        Console.WriteLine("Pleas input RegisterValue");
        MediagarnKar.RegisValue = Console.ReadLine();
    }
}



