namespace TasksLib.BestTimeToBuyAndSellStock;

public record ExampleModel : IExample<int>
{
     public required int[] Prices { get; set; }

     public required int Result { get; set; }

     public static IEnumerable<ExampleModel> GetExamples() =>
     [
          new()
          {
               Prices = [7,1,5,3,6,4],
               Result = 5
          },
          new()
          {
               Prices = [7,6,4,3,1],
               Result = 0
          },
    ];
}