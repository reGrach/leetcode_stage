namespace TasksLib.MergeSortedArray;

public record ExampleModel : IExample<int[]>
{
     public required int[] ArrayOne { get; set; }

     public required int NumOne { get; set; }

     public required int[] ArrayTwo { get; set; }

     public required int NumTwo { get; set; }

     public required int[] Result { get; set; }

     public static IEnumerable<ExampleModel> GetExamples() =>
     [
          new()
          {
               ArrayOne = [1,2,3,0,0,0],
               NumOne = 3,
               ArrayTwo = [2,5,6],
               NumTwo = 3,
               Result = [1,2,2,3,5,6]
          },
          new()
          {
               ArrayOne = [1],
               NumOne = 1,
               ArrayTwo = [],
               NumTwo = 0,
               Result = [1]
          },
          new()
          {
               ArrayOne = [0],
               NumOne = 0,
               ArrayTwo = [1],
               NumTwo = 1,
               Result = [1]
          },
          new()
          {
               ArrayOne = [2,0],
               NumOne = 1,
               ArrayTwo = [1],
               NumTwo = 1,
               Result = [1,2]
          },
          new()
          {
               ArrayOne = [1,2,4,5,6,0],
               NumOne = 5,
               ArrayTwo = [3],
               NumTwo = 1,
               Result = [1,2,3,4,5,6]
          },
    ];
}