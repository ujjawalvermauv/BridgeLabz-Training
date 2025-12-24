using System;

class TwoDToOneD{
    static void Main(){
        Console.WriteLine("Enter Rows:");
        int rows =int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Coloumn:");
        int Coloumn =int.Parse(Console.ReadLine());
        int[,] matrix=new int [rows,Coloumn];
        Console.WriteLine("Enter matrix elements");
        for(int i=0;i<rows;i++){
            for(int j=0;j<Coloumn;j++){
                matrix[i,j]=int.Parse(Console.ReadLine());
            }
        }
        int [] array=new int[rows*Coloumn];
        int index=0;
         for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < Coloumn; j++)
            {
                array[index] = matrix[i, j];
                index++;
            }
        }
        Console.WriteLine("1D Array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}