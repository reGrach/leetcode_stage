namespace TasksLib.RemoveElement;

public class TestRunner : ITest
{
    public void Run()
    {
        int i = 1;
        foreach (var _example in ExampleModel.GetExamples())
        {
            var result = new Solution().RemoveElement(_example.Nums, _example.Val);

            if (_example.Result.k != result)
                Console.WriteLine($"Example {i}: FAIL");
            else
            {
                Array.Sort(_example.Nums, 0, _example.Result.k);

                for (int j = 0; j < _example.Result.k; j++)
                    if (_example.Result.newNums[j] != _example.Nums[j])
                    {
                        Console.WriteLine($"Example {i}: FAIL");
                        break;
                    }

                Console.WriteLine($"Example {i}: SUCCESS");
            }

            i++;
        }
    }
}
