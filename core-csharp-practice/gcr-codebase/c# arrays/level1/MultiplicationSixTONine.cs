using System;

class MultiplicationSixTONine{
    static void Main(){
        Console.WriteLine("Enter a Number:");
        int Number= int.Parse(Console.ReadLine());

        int [] result = new int [4];
        int index=0;
        for(int i=6;i<9;i++){
            result[index++] = Number * i;


        }
        index = 0;
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(Number + " * " + i + " = " + result[index++]);
        }
    }
}