using System;

class PotionRunner
{
    public static Cauldron concrete {get;set;}
    static void Main(string[] args)
    {
        while(true){
            String result;
            Console.WriteLine("Welcome to PotionMaker");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("create a potion: [c]");
            Console.WriteLine("quit: [q]");
            result = Console.ReadLine();
            if(result.Equals("q")||result.Equals("Q")){
                Console.WriteLine("Goodbye");
                break;
            }else if(result.Equals("c")||result.Equals("C")){
                Console.WriteLine("Great!");
                concrete = new RealCauldron(5);
                System.Console.WriteLine(concrete.getNumber());
            }
        }
    }
}