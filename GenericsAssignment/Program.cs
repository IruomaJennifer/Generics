// See https://aka.ms/new-console-template for more information


//Assignment 1
void ReverseArray<T>(ref T[] input)
 {
    T[] result = new T[input.Length];
    int index = input.Length;
    for (int i = 0; i < input.Length; i++)
    {
        result[i]=input[index-1];
        index--;
    }
    input = result;
 }

var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach (var item in array)
{
    Console.Write($"{item} ");
}
ReverseArray(ref array);
Console.WriteLine();
foreach (var item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
Console.WriteLine();

//Assignment 2
void GetLastElementAndCount<T>(T[] array)
{
    int count = 0;
    foreach (var element in array)
    {
        count++;
    }
    Console.WriteLine($"Last element is: {array[count-1]}");
    Console.WriteLine($"Number of elements: {count}");
}
var classMates = new string[] { "Victory", "Dozie", "Gideon", "Suzy", "Iruoma", "Ifesi" };
GetLastElementAndCount(classMates);


//Assignment 3
public class DataStore1<T> : IDataStore<T> where T:EntityBase
{
    public void Create(T inputObject)
    {
        Console.WriteLine($"{inputObject.Id} has been created in Data Store 1");
    }

    public void Delete(int id)
    {
        Console.WriteLine($"object {id} has been deleted from Data Store 1");
    }

    public T Read(int id)
    {
        Console.WriteLine($"object {id} has been read from Data Store 1");
        return default(T);
    }

    public List<T> ReadList()
    {
        Console.WriteLine($"objects have been read from Data Store 1");
        return default(List<T>);
    }

    public void Update(T inputObject)
    {
        Console.WriteLine($"{inputObject.Id} has been updated in Data Store 1");
    }
}

public class StudentDataStore : IDataStore<Student>
{
    public void Create(Student student)
    {
        Console.WriteLine($"Student {student.Id} has been created in the student data Store");
    }

    public void Delete(int id)
    {
        Console.WriteLine($"Student {id} has been deleted from the student data Store");
    }

    public Student Read(int id)
    {
        Console.WriteLine($"Student {id} has been read from the student data store");
        return default(Student);
    }

    public List<Student> ReadList()
    {
        Console.WriteLine($"Students have been read from the student data store");
        return default(List<Student>);
    }

    public void Update(Student student)
    {
        Console.WriteLine($" Siudent {student.Id} has been updated in the student data store");
    }
}