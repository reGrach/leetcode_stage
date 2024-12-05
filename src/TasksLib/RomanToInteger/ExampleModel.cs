namespace TasksLib.RomanToInteger;

public record ExampleModel : IExample<int>
{
     public required string Numeric { get; set; }

     public required int Result { get; set; }

     public static IEnumerable<ExampleModel> GetExamples() =>
     [
          new()
          {
               Numeric = "III",
               Result = 3
          },
          new()
          {
               Numeric = "LVIII",
               Result = 58
          },
          new()
          {
               Numeric = "MCMXCIV",
               Result = 1994
          },
    ];
}