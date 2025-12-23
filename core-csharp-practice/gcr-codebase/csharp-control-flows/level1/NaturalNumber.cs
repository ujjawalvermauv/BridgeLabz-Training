using System;

class NaturalNumber{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        int sum=0;
        if (n>=0){
            int Sum=n * (n+1) / 2 ;
            Console.WriteLine("The sum of "+n + "natural numbers is "+ sum);

        }
        else{
            Console.WriteLine("The number "+ n +"is not a natural number");
        }
        

    }
}