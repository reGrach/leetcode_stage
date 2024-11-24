using System;

namespace TasksLib.MergeSortedArray;

public class TestRunner : ITest
{
    public void Run()
    {
        int i = 1;
        foreach (var _exmpl in ExampleModel.GetExamples())
        {
            Solution.Merge(_exmpl.ArrayOne, _exmpl.NumOne, _exmpl.ArrayTwo, _exmpl.NumTwo);
            if (Enumerable.SequenceEqual(_exmpl.ArrayOne, _exmpl.Result))
                Console.WriteLine($"Example {i}: SUCCESS");
            else
                Console.WriteLine($"Example {i}: FAIL");

            i++;
        }
    }

}
