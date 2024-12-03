namespace TasksLib.MajorityElement;

public class TestRunner : ITest
{
    public void Run()
    {
        int i = 1;
        foreach (var _example in ExampleModel.GetExamples())
        {
            var result = new Solution().MajorityElement(_example.Nums);

            if (result == _example.Result)
                Console.WriteLine($"Example {i}: SUCCESS");
            else
                Console.WriteLine($"Example {i}: FAIL");

            i++;
        }
    }
}