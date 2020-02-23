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
            Console.WriteLine("Create a potion: [c]");
            Console.WriteLine("Quit: [q]");
            result = Console.ReadLine();
            if(result.ToLower().Equals("q")){
                Console.WriteLine("Goodbye");
                break;
            }else if(result.ToLower().Equals("c")){
                System.Console.WriteLine("Great!");
                int exitCode = makeCauldron();
                if(exitCode == 1){
                    break;
                }
                exitCode = chooseIngredients();
                if(exitCode == 1){
                    break;
                }
            }else{
                Console.Clear();
                System.Console.WriteLine("Not a recognised input, please try again");
            }
        }
    }
    
    static int makeCauldron(){
        while(true){
            String result;
            Console.WriteLine("How large would you like the cauldron to be?");
            Console.WriteLine("Big: [1]");
            Console.WriteLine("Medium: [2]");
            Console.WriteLine("Small: [3]");
            Console.WriteLine("Quit: [q]");
            result = Console.ReadLine();
            if(result.Equals("1")){
                concrete = CauldronFactory.buildBigCauldron();
                return 0;
            }else if(result.Equals("2")){
                concrete = CauldronFactory.buildMedCauldron();
                return 0;
            }else if(result.Equals("3")){
                concrete = CauldronFactory.buildSmallCauldron();
                return 0;
            }else if(result.ToLower().Equals("q")){
                Console.WriteLine("Goodbye");
                return 1;
            }else{
                Console.Clear();
                System.Console.WriteLine("Not a recognised input, please try again");
            }
        }
    }

    static int chooseIngredients(){
        System.Console.WriteLine("Choose your potion ingredients");
        
        return 0;
    }
}