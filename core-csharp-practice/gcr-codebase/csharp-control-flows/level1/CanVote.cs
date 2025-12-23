using System;

class CanVote{
    static void Main(){
        Console.WriteLine("please Enter your Age:");
        int age =int.Parse(Console.ReadLine());
        if(age>=18){
            Console.WriteLine("The person's age is "+age+"and can vote.");
        }
        else{
            Console.WriteLine("The person's age is"+age+"and cannot vote");
        }

    }
}