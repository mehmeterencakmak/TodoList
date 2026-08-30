// Console.WriteLine("Enter a number");
// string input = Console.ReadLine();
// try
// {
//     int number = ParseStringToInt(input);
//     var result = 10 / (number);

//     Console.WriteLine($"10 / {number} is " +result);
// }
// catch(FormatException ex)
// {
//     Console.WriteLine("Wrong format. Input string is not parsable to int." + ex.Message);
// }
// catch(DivideByZeroException ex)
// {
//     Console.WriteLine("Division by zero is an invalid operation. " + "Exception message: " +ex.Message);
// }
// catch(Exception ex)
// {
//     Console.WriteLine("Unexpected error occured." + "Exception message: " + ex.Message);
// }
// finally
// {
//     Console.WriteLine("Finally block is being executed.");
// }

// int ParseStringToInt(string input)
// {
//     return int.Parse(input);
// }


// try
// {
//     var result = GetFirstElement(new int[0]);
// }
// catch
// {

// }

// Console.ReadKey();

// int  GetFirstElement(IEnumerable<int> numbers)
// {
//     foreach(var number in numbers)
//     {
//         return number;
//     }
//     throw new Exception("The collection cannot be empty.");
// }

// Console.ReadKey();

// int GetFirstElement(IEnumerable<int> numbers)
// {
//     foreach(var number in numbers)
//     {
//         return number;
//     }
//     throw new InvalidOperationException("The collection cannot be empty.");
// }


// bool IsFirstElementPositive(IEnumerable<int> numbers)
// {
//     try
//     {
//         var firstElement = GetFirstElement(numbers);
//         return firstElement > 0;
//     }
//     catch(InvalidOperationException Ex)
//     {
//         Console.WriteLine("The collection is empty.");
//         return true;
//     }
//     catch(NullReferenceException ex)
//     {
//         throw new ArgumentException("The collection is null.", ex);
//     }
// }


using System.Runtime.Serialization;

throw new Exception();

Console.ReadKey();
[Serializable]

public class CustomException : Exception
{
    public int StatusCode { get; }

    protected CustomException(SerilizationInfo info, StreamingContext) : base(info, context)
    {
        
    }
    public CustomException(){
        
    }

    public CustomException(string message, int statusCode) : base(message)
    {
        StatusCode = statusCode;
    }
    
    public CustomException(string message, int statusCode, Exception innerException) : base(message, innerException)
    {
        StatusCode = statusCode;
    }

    public CustomException(string massage) : base(message)
    {
        
    }
    public CustomException(string message, Exception innerException) : base(message, innerException)
    {
        
    }
}