namespace TasksLib;

public interface IExample { }

public interface IExample<T> : IExample
{
    public T Result { get; set; }
}