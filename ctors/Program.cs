// Կոնստրուկտորների շղթայական կանչ

// using System;

// class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public Person() : this("Unknown") {}
//     public Person(string name) : this(name, 18) {}
//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }
//     public void Display()
//     {
//         Console.WriteLine($"Name: {Name}, Age: {Age}");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Person p1 = new Person();
//         Person p2 = new Person("Alice");
//         Person p3 = new Person("Bob", 25);

//         p1.Display();
//         p2.Display();
//         p3.Display();
//     }
// }


// Մեքենայի տվյալներ

// using System;

// class Car
// {
//     public string Name { get; set; }
//     public string Model { get; set; }
//     public int Year { get; set; }

//     public Car(string name, string model, int year)
//     {
//         Name = name;
//         Model = model;
//         Year = year;
//     }

//     public void Display()
//     {
//         Console.WriteLine($"Car: {Name} {Model} {Year}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Car myCar = new Car("Toyota", "Corolla", 2020);
//         myCar.Display();
//     }
// }


// Գրքի տվյալներ

// using System;

// class Book
// {
//     public string Name { get; set; }
//     public string Author { get; set; }
//     public double Price { get; set; }

//     public Book() : this("Unknown", "Unknown Author", 0.0) {}
//     public Book(string name) : this(name, "Unknown Author", 0.0) {}
//     public Book(string name, string author) : this(name, author, 0.0) {}
//     public Book(string name, string author, double price)
//     {
//         Name = name;
//         Author = author;
//         Price = price;
//     }

//     public void Display()
//     {
//         Console.WriteLine($"Book: {Name}, Author: {Author}, Price: ${Price}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Book defaultBook = new Book();
//         defaultBook.Display();
        
//         Book namedBook = new Book("C# Programming");
//         namedBook.Display();
        
//         Book authorBook = new Book("C# Programming", "John Doe");
//         authorBook.Display();
        
//         Book fullBook = new Book("C# Programming", "John Doe", 29.99);
//         fullBook.Display();
//     }
// }
