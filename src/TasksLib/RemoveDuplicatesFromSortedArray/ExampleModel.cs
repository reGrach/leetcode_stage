namespace TasksLib.RemoveDuplicatesFromSortedArray;

public record ExampleModel : IExample<(int res, int[] newNums)>
{
     public required int[] Nums { get; set; }
     public (int res, int[] newNums) Result { get; set; }

     public static IEnumerable<ExampleModel> GetExamples() =>
     [
        new()
        {
             Nums = [1,1,2],
             Result = (2 , [1, 2, 0])
        },
        new()
        {
             Nums = [0,0,1,1,1,2,2,3,3,4],
             Result = (5 , [0,1,2,3,4,0,0,0,0,0])
        },
        new()
        {
             Nums = [1,2,2],
             Result = (2 , [1,2])
        },
        new()
        {
             Nums = [-3,-1,0,0,0,3,3],
             Result = (4, [-3,-1,0,3])
        }
    ];
}
