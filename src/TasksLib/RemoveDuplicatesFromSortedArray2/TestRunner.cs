namespace TasksLib.RemoveDuplicatesFromSortedArray2;

public class TestRunner : ITest
{
    public void Run()
    {
        int i = 1;
        foreach (var _example in ExampleModel.GetExamples())
        {
            var result = new Solution().RemoveDuplicates(_example.Nums);

            if (result == _example.Result.res && Enumerable.SequenceEqual(_example.Result.newNums, _example.Nums))
                Console.WriteLine($"Example {i}: SUCCESS");
            else
                Console.WriteLine($"Example {i}: FAIL");

            i++;
        }
    }
}