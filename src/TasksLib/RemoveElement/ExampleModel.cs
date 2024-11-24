namespace TasksLib.RemoveElement;

public record ExampleModel : IExample<(int k, int[] newNums)>
{
    public required int[] Nums { get; set; }

    public required int Val { get; set; }

    public required (int k, int[] newNums) Result { get; set; }

    public static IEnumerable<ExampleModel> GetExamples() =>
    [
        new()
        {
             Nums = [3,2,2,3],
             Val = 3,
             Result = (2, [2,2,0,0] ),
        },
        new()
        {
             Nums = [0,1,2,2,3,0,4,2],
             Val = 2,
             Result = (5, [0,1,4,0,3,0,0,0] ),
        }
    ];
}