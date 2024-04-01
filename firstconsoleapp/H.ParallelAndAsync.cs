using System;
using System.Threading;
using System.Threading.Tasks;

public class ParallelAndAsync
{
    //parallel programming
    //taks: takes time and independent
    int[] numbers=[32123,67453,98374,9983207,63473213];
    private void CalculateSquare(int n)
    {
        var square=n*n;
        Console.WriteLine($"Square of {n}is{square}");
        Thread.Sleep(1000);  //1s time
    }
    //sequential
      public void ProcessNumbers()
    {
        Console.WriteLine("Sequential loop:");
        foreach(var num in numbers)  //sync-one after another
        {
            CalculateSquare(num);
        }  public void ProcessNumbersParallel()
    {
        Console.WriteLine("Prallel loop:");
        ////TPL=Task Parallel Library
        Parallel.ForEach(numbers,CalculateSquare);  //parallel vanney class ko method ho
    }
    }


//parallel programming is a side effect of sync
    public async Task MakeTea(){
        await IgniteStove();
        await BoilWaterOnTeaPot();
        await PrepareMasala();
       await  AddIngrediants();

    }

     private async void IgniteStove(){
        await Task.Delay(1000);
    }

     private  async Task<bool> BoilWaterOnTeaPot(){
        return false;
    }


     private async Task PrepareMasala(){
        
    }

     private async Task AddIngrediants(){
        
    }
}