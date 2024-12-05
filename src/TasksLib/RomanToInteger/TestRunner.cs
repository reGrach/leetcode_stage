namespace TasksLib.RomanToInteger;

public class TestRunner : ITest
{
    public void Run()
    {
        int i = 1;
        foreach (var _exmpl in ExampleModel.GetExamples())
        {
            var res = new Solution().RomanToInt(_exmpl.Numeric);
            if (res == _exmpl.Result)
                Console.WriteLine($"Example {i}: SUCCESS");
            else
                Console.WriteLine($"Example {i}: FAIL");

            i++;
        }
    }

}
