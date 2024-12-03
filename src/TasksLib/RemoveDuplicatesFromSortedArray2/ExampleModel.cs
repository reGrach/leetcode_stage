namespace TasksLib.RemoveDuplicatesFromSortedArray2;

public record ExampleModel : IExample<(int res, int[] newNums)>
{
     public required int[] Nums { get; set; }
     public (int res, int[] newNums) Result { get; set; }

     public static IEnumerable<ExampleModel> GetExamples() =>
      [
          new()
        {
             Nums = [1,1,1,2,2,3],
             Result = (5 , [1,1,2,2,3,0])
        },
        new()
        {
             Nums = [0,0,1,1,1,1,2,3,3],
             Result = (7 , [0,0,1,1,2,3,3,0,0])
        }
    ];
}
