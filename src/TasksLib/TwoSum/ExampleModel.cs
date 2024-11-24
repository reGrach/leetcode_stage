namespace TasksLib.TwoSum;

public record ExampleModel : IExample<int[]>
{
     public required int[] Nums { get; set; }

     public required int Target { get; set; }

     public required int[] Result { get; set; }

     public static IEnumerable<ExampleModel> GetExamples() =>
     [
         new()
        {
             Nums = [2,7,11,15],
             Target = 9,
             Result = [0, 1]
        },
        new()
        {
             Nums = [3,2,4],
             Target = 6,
             Result = [1, 2]
        },
        new()
        {
             Nums = [3,3],
             Target = 6,
             Result = [0, 1]
        },
    ];
}
