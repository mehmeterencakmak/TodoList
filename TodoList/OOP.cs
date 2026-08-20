// var internationalPizzaDay23 = new DateTime(2023, 2, 9, 12, 34, 11);

// Console.WriteLine("Year is " +internationalPizzaDay23.Year);
// Console.WriteLine("Month is " +internationalPizzaDay23.Month);
// Console.WriteLine("Day of the weak is " +internationalPizzaDay23.DayOfWeek);


// var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);
// Console.WriteLine();
// Console.WriteLine("Year is " +internationalPizzaDay24.Year);
// Console.WriteLine("Month is " +internationalPizzaDay24.Month);
// Console.WriteLine("Day of the weak is " +internationalPizzaDay24.DayOfWeek);



// var rectangle1 = new Rectangle(5,10);
// Console.WriteLine("Width is " + rectangle1.Width);
// Console.WriteLine("Height is " + rectangle1.Height);
// Console.WriteLine("Area is "+ rectangle1.CalculateArea());
// Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());

// var rectangle2 = new Rectangle(2,3);
// Console.WriteLine("Width is " + rectangle2.Width);
// Console.WriteLine("Height is " + rectangle2.Height);
// Console.WriteLine("Area is "+ rectangle2.CalculateArea());
// Console.WriteLine("Circumference is " + rectangle2.CalculateCircumference());

// var calculator = new ShapesMeasurementsCalculator();
// Console.WriteLine("Area is "+ calculator.CalculateRectangleArea(rectangle1));
// Console.WriteLine("Circumference is "+ calculator.CalculateRectangleCircumference(rectangle1));


// Console.ReadKey();

// class Rectangle
// {
//     public int Width = 3;
//     public int Height = 4;

//     public Rectangle(int width, int height)
//     {
//         Width = width;
//         Height = height;
//     }

// }

// class ShapesMeasurementsCalculator
// {
//     public int CalculateRectangleCircumference(Rectangle rectangle)
//     {
//         return 2*rectangle.Width + 2*rectangle.Height;
//     }

//     public int CalculateRectangleArea(Rectangle rectangle)
//     {
//         return rectangle.Width * rectangle.Height;
//     }
// }


// // OVERLOADİNG//
// var medicalAppointment = new MedicalAppointment(
//     "Mehmet Eren Çakmak", new DateTime(2023,4,3)
// );
// override month and day
// medicalAppointment.Reschedule(5, 1);

// add a given number of months and days
// medicalAppointment.Reschedule(1,2);

// class MedicalAppointment
// {
//     private string _patientName;
//     private DateTime _date;

//     public MedicalAppointment(string patientName, DateTime date)
//     {
//         _patientName = patientName;
//         _date = date;
//     }

//     public void Reschedule(DateTime date)
//     {
//         _date = date;
//     }
//     public void MoveByMonthsAndDay(int month, int day)
//     {
//         _date = new DateTime(_date.Year, month, day);
//     }
//     public void MoveByMonthsAndDay(int monthsToAdd, int daysToAdd)
//     {
//         _date = new DateTime(
//             _date.Year,
//             _date.Month + monthsToAdd,
//             _date.Day + daysToAdd
//         );
//     }

// }


// //OVERLOADİNG//
// var medicalAppointment = new MedicalAppointment(
//     "Mehmet Eren Çakmak", new DateTime(2023,4,3)
// );
// //override month and day
// medicalAppointment.Reschedule(5, 1);

// // add a given number of months and days
// medicalAppointment.Reschedule(1,2);

// class MedicalAppointment
// {
//     private string _patientName;
//     private DateTime _date;

//     public MedicalAppointment(string patientName, DateTime date)
//     {
//         _patientName = patientName;
//         _date = date;
//     }

//     public MedicalAppointment(string patientName) :
//         this(patientName, 7)
//     {
//     }

//     public MedicalAppointment(string patientName, int daysFromNow)
//     {
//         _patientName = patientName;
//         _date = DateTime.Now.AddDays(daysFromNow);
//     }

//     public void Reschedule(DateTime date)
//     {
//         _date = date;
//     }
//     public void MoveByMonthsAndDay(int month, int day)
//     {
//         _date = new DateTime(_date.Year, month, day);
//     }
//     public void MoveByMonthsAndDay(int monthsToAdd, int daysToAdd)
//     {
//         _date = new DateTime(
//             _date.Year,
//             _date.Month + monthsToAdd,
//             _date.Day + daysToAdd
//         );
//     }

// }


// // this //


// var medicalAppointment = new MedicalAppointment(
//     "Mehmet Eren Çakmak", new DateTime(2023,4,3)
// );

// class MedicalAppointmentPrinter
// {
//     public void Print(MedicalAppointment medicalAppointment)
//     {
//         Console.WriteLine(
//             "Appointment will take place on " + medicalAppointment.GetDate());
//     }
// }


// class MedicalAppointment
// {
//     private string _patientName;
//     private DateTime _date;

//     public MedicalAppointment(string patientName, DateTime date)
//     {
//         _patientName = patientName;
//         _date = date;
//     }

//     public DateTime GetDate() => _date;

//     public MedicalAppointment(string patientName) :
//         this(patientName, 7)
//     {
//     }

//     public MedicalAppointment(string patientName, int daysFromNow)
//     {
//         _patientName = patientName;
//         _date = DateTime.Now.AddDays(daysFromNow);
//     }

//     public void Reschedule(DateTime date)
//     {
//         _date = date;
//         var printer = new MedicalAppointment();
//         printer.Print(this);
//     }
//     public void MoveByMonthsAndDay(int month, int day)
//     {
//         _date = new DateTime(_date.Year, month, day);
//     }
//     public void MoveByMonthsAndDay(int monthsToAdd, int daysToAdd)
//     {
//         _date = new DateTime(
//             _date.Year,
//             _date.Month + monthsToAdd,
//             _date.Day + daysToAdd
//         );
//     }

// }


// // // this //


// var medicalAppointment = new MedicalAppointment(
//     "Mehmet Eren Çakmak", new DateTime(2023,4,3)
// );

// class MedicalAppointmentPrinter
// {
//     public void Print(MedicalAppointment medicalAppointment)
//     {
//         Console.WriteLine(
//             "Appointment will take place on " + medicalAppointment.GetDate());
//     }
// }


// class MedicalAppointment
// {
//     private string _patientName;
//     private DateTime _date;

//     public MedicalAppointment(string patientName, DateTime date)
//     {
//         _patientName = patientName;
//         _date = date;
//     }

//     public DateTime GetDate() => _date;

//     // public MedicalAppointment(string patientName) :
//     //     this(patientName, 7)
//     // {
//     // }

//     public MedicalAppointment(string patientName)
//     {
//         _patientName = patientName;
//     }
//     public MedicalAppointment(string patientName, int daysFromNow)
//     {
//         _patientName = patientName;
//         _date = DateTime.Now.AddDays(daysFromNow);
//     }

//     public void Reschedule(DateTime date)
//     {
//         _date = date;
//         var printer = new MedicalAppointment();
//         printer.Print(this);
//     }
//     public void MoveByMonthsAndDay(int month, int day)
//     {
//         _date = new DateTime(_date.Year, month, day);
//     }
//     public void MoveByMonthsAndDay(int monthsToAdd, int daysToAdd)
//     {
//         _date = new DateTime(
//             _date.Year,
//             _date.Month + monthsToAdd,
//             _date.Day + daysToAdd
//         );
//     }

// }


// var rectangle1 = new Rectangle(5,10);
// Console.WriteLine("Width is " + rectangle1.Width);
// Console.WriteLine("Height is " + rectangle1.GetHeight());
// Console.WriteLine("Area is "+ rectangle1.CalculateArea());
// Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());

// class Rectangle
// {
//     const int NumberOfSides = GetOne();

//     readonly int NumberOfSidesReadonly;
//     public readonly int Width = 3;
//     private int _height = 4;

//     public static int GetOne() => 1;

//     public Rectangle(int width, int height)
//     {
//         NumberOfSidesReadonly = 4;
//         Width = GetLengthOrDefault(width, nameof(Width));
//         _height = GetLengthOrDefault(height, nameof(_height));
//     }

//     public int GetHeight() => _height;

//     public void SetHeight(int value)
//     {
//         _height = value;
//     }

//     private int GetLengthOrDefault(int length, int name)
//     {
//         const int defaultValueIfNonPositive = 1;
//         if(length <= 0)
//         {
//             Console.WriteLine($"{name} must be a positive number.");
//             Width = defaultValueIfNonPositive;
//         }
//         return length;
//     }

// }



// class ShapesMeasurementsCalculator
// {
//     public int CalculateRectangleCircumference() => 2*rectangle.Width + 2*rectangle.Height;


//     public int CalculateRectangleArea() => rectangle.Width * rectangle.Height;

// }



// var rectangle1 = new Rectangle(5,10);
// Console.WriteLine("Width is " + rectangle1.Width);

// rectangle1.Width = 15;

// // Console.WriteLine("Height is " + rectangle1.GetHeight());
// // Console.WriteLine("Area is "+ rectangle1.CalculateArea());
// // Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());

// class Rectangle
// {


//     public Rectangle(int width, int height)
//     {
//         Width = GetLengthOrDefault(width, nameof(Width));
//         _height = GetLengthOrDefault(height, nameof(_height));
//     }

//     public int Width{ get; private set;  }

//     private int _height;

//     public int GetHeight() => _height;

//     public void SetHeight(int value)
//     {
//         if(value > 0)
//         {
//             _height = value;        
//         }
//     }

//     private int GetLengthOrDefault(int length, string name)
// {
//         const int defaultValueIfNonPositive = 1;

//     if(length <= 0)
//     {
//         Console.WriteLine($"{name} must be a positive number.");
//         return defaultValueIfNonPositive;
//     }

//     return length;
// }

// }



// // class ShapesMeasurementsCalculator
// // {
// //     public int CalculateRectangleCircumference() => 2*rectangle.Width + 2*rectangle.Height;


// //     public int CalculateRectangleArea() => rectangle.Width * rectangle.Height;

// // }


// var person = new Person
// {
//    Name = "Jhon",
//     YearOfBirth = 1999
// };

// class Person
// {
//     public string Name {get; set;}
//     public int YearOfBirth {get; init;}

//     // public Person(string name){
//     //     Name = name;
//     // }

//     // public Person(string name, int yearOfBirth)
//     // {
//     //     Name = name;
//     //     YearOfBirth = yearOfBirth;
//     // }
// }


// Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
// Console.WriteLine($"1 - 2 is {Calculator.Substract(1, 2)}");
// Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)} ");

// static class Calculator
// {
//     public static int Add(int a, int b) => a + b;
//     public static int Substract(int a, int b) => a - b;
//     public static int Multiply(int a, int b) => a * b;
// }


// Pizza application for  override, inheritence..

// var pizza = new Pizza();
// pizza.AddIngredient(new Cheddar());
// pizza.AddIngredient(new Mozzarella());
// pizza.AddIngredient(new TomataSauce());
// Console.WriteLine(pizza.Describe());


// var ingredient = new Ingredient();
// ingredient.PublicField = 10;

// var cheddar = new Cheddar();
// cheddar.PublicField = 20;

// Console.WriteLine("Value in ingredient: " + ingredient.PublicField);
// Console.WriteLine("Value in cheddar: " + cheddar.PublicField);

// Console.WriteLine(cheddar.PublicMethod());
// Console.WriteLine(cheddar.ProtectedMethod());
// Console.WriteLine(cheddar.PrivateMethod());

// Console.WriteLine("Variable of type Cheddar");
// Cheddar cheddar = new Cheddar();
// Console.WriteLine(cheddar.Name);

// Console.WriteLine("Variable of type Ingredient");
// Ingredient ingredient = new Cheddar();
// Console.WriteLine(ingredient.Name);

// var ingredients = new List<Ingredient>
// {
//     new Cheddar(),
//     new Mozzarella(),
//     new TomataSauce()
// };
// foreach(var ingredient in ingredients)
// {
//     Console.WriteLine(ingredient.Name);
// }


// var cheddar = new Cheddar();
// Console.WriteLine(cheddar);

// Console.WriteLine(pizza.Describe());

// var ingredient = new Ingredient(1);
// var cheddar = new Cheddar(2, 12);
// Console.WriteLine(cheddar);

// Console.ReadKey();

// public class Pizza
// {
//     private List<Ingredient> _ingredients = new List<Ingredient>();

//     public void AddIngredient(Ingredient ingredient) => 
//     _ingredients.Add(ingredient);

//     public override string ToString() => 
//         $"This is a pizza with {string.Join(", ", _ingredients)}";
// }
// public class Ingredient
// {

//     public Ingredient(int priceIfExtraTopping){
//         Console.WriteLine("Constructor fro the Ingredient class");
//         PriceIfExtraTopping = priceIfExtraTopping;
//     }
//     public int PriceIfExtraTopping {get; }

//     public override string ToString() => Name;
//     public virtual string Name {get; } = "Some ingredient";
//     public int PublicField;
//     public string PublicMethod() => 
//         "This method is PUBLIC in the Ingredient class.";
//     protected string ProtectedMethod() => 
//         "This method is PROTECTED in the Ingredient class.";
//     private string PrivateMethod() => 
//         "This method is PRIVATE in the Ingredient class.";
    
// }

// public class Cheese : Ingredient
// {
//     public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
//     {
        
//     }
// }

// public class ItalianFoodItem
// {
    
// }

// public class Cheddar : Ingredient
// {

//     public Cheddar(int priceIfExtraTopping, int agedForMonths) : base(priceIfExtraTopping)
//     {
//         AgedForMonths = agedForMonths;
//         Console.WriteLine("Constructor from the Cheddar class");
//     }

//     public override string Name  => 
//     $"{base.Name}, more specifically, " +
//     $"a Cheddar cheese aged for {AgedForMonths} months";
//     public int AgedForMonths {get;}
//     public void UseMethodsFromBaseClass()
//     {
//         Console.WriteLine(PublicMethod());
//         Console.WriteLine(ProtectedMethod());
//         // Console.WriteLine(PrivateMethod());
//     }
// }
// public class TomataSauce : Cheese
// {
//     public TomataSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
//     {
        
//     }
//     public  string Name  => "Tomato sauce";
//     public int TomatosIn100Grams {get;}
// }
// public class Mozzarella : Ingredient
// {
//     public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
//     {
        
//     }
//     public override string Name  => "Mozzarella";
//     public bool IsLight {get;}
// }



// var numbers = new List<int> {1, 4, 6, -1, 12, 44, -8, -19};
// bool shallAddPositiveOnly = false;

// NumbersSumCalculator calculator = 
//     shallAddPositiveOnly ? 
//     new PositiveNumbersSumCalculator() :
//     new NumbersSumCalculator();

// int sum = calculator.Calculate(numbers);


 
// Console.WriteLine("Sum is: " +sum);
// Console.ReadKey();


// public class NumbersSumCalculator
// {
//     public int Calculate(List<int> numbers)
//     {
//         int sum = 0;
//         foreach(int number in numbers)
//         {
//             if (ShallBeAdded(number))
//             {
//                 sum += number;
//             }
//         }
//         return sum;
//     }
//     protected virtual bool ShallBeAdded(int number)
//     {
//         return true;
//     }
// }

// public class PositiveNumbersSumCalculator 
//     : NumbersSumCalculator
// {
//     protected override bool ShallBeAdded(int number)
//     {
//         return number > 0;
//     }
// }


