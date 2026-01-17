using System;

class Tracker
{
    public string UserName{get;set;}
    public int Steps{get;set;}

    public Tracker(string UserName,int Steps)
    {
        this.UserName=UserName;
        this.Steps=Steps;
    }
    public override string ToString()
    {
        return "User Name is :" + this.UserName + " ||  steps count :"  + this.Steps;
    }
}
class BubbleSortUtil
{
    public static void BubbleSort(Tracker [] arr)
    {
        int n=arr.Length;
        for(int i = 0; i < n - 1; i++)
        {
            for(int j = 0; j < n - i - 1; j++) // n-i-1 because on less than i
            {
                if (arr[j].Steps < arr[j + 1].Steps) // if previus element is smaller than swap because largest should be at last
                {
                    Tracker temp =arr[j]; //swapping is done here using a temp
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            }
        }
    }
}
class Program
{
    static void Main(string [] args)
    {
         Tracker[] trackers ={new Tracker ("harsh",7700),
                             new Tracker("ujjawal",8899),
                             new Tracker("sonu",8700)
    };
    BubbleSortUtil.BubbleSort(trackers);
    foreach(Tracker t in trackers)
        {
            System.Console.WriteLine(t);
    }
    }
} 