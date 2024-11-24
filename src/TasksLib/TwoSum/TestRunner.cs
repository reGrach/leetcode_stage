namespace TasksLib.TwoSum;

public class TestRunner : ITest
{
    public void Run()
    {
        int i = 1;
        foreach (var _example in ExampleModel.GetExamples())
        {
            var result = new Solution().Run(_example.Nums, _example.Target);

            if (Enumerable.SequenceEqual(_example.Result, result))
                Console.WriteLine($"Example {i}: SUCCESS");
            else
                Console.WriteLine($"Example {i}: FAIL");

            i++;
        }
    }
}