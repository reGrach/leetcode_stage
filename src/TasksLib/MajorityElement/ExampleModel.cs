namespace TasksLib.MajorityElement;

public record ExampleModel : IExample<int>
{
     public required int[] Nums { get; set; }
     public int Result { get; set; }

     public static IEnumerable<ExampleModel> GetExamples() =>
     [
          new()
          {
               Nums = [3,2,3],
               Result = 3
          },
          new()
          {
               Nums = [2,2,1,1,1,2,2],
               Result = 2
          }
    ];
}
