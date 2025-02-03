using System;
using System.Collections.Generic;
using CSharpCrash.OOP;

namespace CSharpCrashCourse
{
    class Program
    {
        // Static keyword means:
        // 1. The member belongs to the type itself (Program class) rather than to a specific instance
        // 2. Only one copy exists in memory regardless of how many instances of the class are created
        // 3. Can be accessed without creating an instance of the class
        static void Main(string[] args)
        {
            // PrintToConsole();
            // VariablesAndDataTypes();
            // NumberType();
            // MathOperations();
            // IfElse();
            // SwitchStatement();
            // ForLoop();
            // WhileLoop();
            // DoWhileLoop();
            // ArrayExample()
            // Collections();
            // HashSetExample();
            // DictionaryExample();
            // QueueExample();
            // StackExample();

            //! OOP example 
            // Testing encapsulation
            // Ex 1
            Rectangle rectangle = new Rectangle(1.5, 2.5);
            rectangle.DisplayArea();
            // Ex 2
            BankAccount myBankAccount = new BankAccount();

            myBankAccount.Deposit(33);
            myBankAccount.Deposit(22);
            myBankAccount.DisplayBalance();
            

        }

        static void PrintToConsole()
        {
            Console.WriteLine("Hello, World!");
        }

        static void VariablesAndDataTypes()
        {
            int age = 20;
            DateTime today = DateTime.Parse("2004-02-08");
            string name = "Mong";
            char gender = 'M';
            Console.WriteLine($"My name is {name} and I am {age} years old. My gender is {gender}. Today is {today.ToShortDateString()}");
            bool isTrue = true;
            Console.WriteLine($"isTrue : {isTrue}");
        }

        static void NumberType()
        {
            int age = 20;
            Console.WriteLine($"age : {age}");
            float height = 5.9f;
            Console.WriteLine($"height : {height}");
            double weight = 70.5;
            Console.WriteLine($"weight : {weight}");
            decimal price = 19.95m;
            Console.WriteLine($"price : {price}");
        }
        static void MathOperations()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine($"a % b = {a % b}");
        }

        static void IfElse()
        {
            int a = 10;
            int b = 20;
            if (a > b)
            {
                Console.WriteLine($"a is greater than b");
            }
            else if (a < b)
            {
                Console.WriteLine($"a is less than b");
            }
            else
            {
                Console.WriteLine($"a is equal to b");
            }
        }
        static void SwitchStatement()
        {
            int a = 10;
            switch (a)
            {
                case 10: Console.WriteLine("a is 10"); break;
                default: Console.WriteLine("a is not 10"); break;
            }
        }

        static void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i : {i}");
            }
        }

        static void WhileLoop()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"i : {i}");
                i++;
            }
        }

        static void DoWhileLoop()
        {
            int i = 0;
            do
            {
                Console.WriteLine($"i : {i}");
                i++;
            } while (i < 10);
        }

        static void ArrayExample()
        {
            // Fixed-size Array
            // - Size cannot be changed after creation
            // - Better performance
            // - Less memory overhead
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Fixed Array length: {numbers.Length}");
            Console.WriteLine($"numbers[0]: {numbers[0]}");

            // Cannot add elements to fixed array
            // This will not work: numbers.Append(6); 

            // List<T> (Dynamic Array)
            // - Size can grow and shrink
            // - More flexible
            // - Slightly more memory overhead
            List<string> names = new List<string> { "John", "Jane", "Doe" };
            Console.WriteLine($"Initial List count: {names.Count}");

            // Adding elements
            names.Add("Mong");
            Console.WriteLine($"After adding, List count: {names.Count}");

            // Removing elements
            names.Remove("John");
            Console.WriteLine($"After removing, List count: {names.Count}");

            // Accessing elements
            Console.WriteLine($"First name: {names[0]}");

            // Iterating through the List
            Console.WriteLine("All names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        static void Collections()
        {
            List<object> anyTypeArray = new List<object>();
            anyTypeArray.Add("John");
            anyTypeArray.Add(20);
            anyTypeArray.Add(true);
            foreach (object item in anyTypeArray)
            {
                Console.WriteLine(item);
            }

            HashSet<string> uniqueNumbers = new HashSet<string>();

        }
        static void HashSetExample()
        {
            // HashSet - a collection of unique elements
            // - No duplicates allowed
            // - Very fast lookups O(1)
            // - Unordered collection
            HashSet<string> uniqueNames = new HashSet<string>();

            // Adding elements
            uniqueNames.Add("John");
            uniqueNames.Add("Jane");
            uniqueNames.Add("John");  // This won't be added (duplicate)

            Console.WriteLine($"Count: {uniqueNames.Count}");  // Output: 2

            // Checking if element exists (very fast)
            bool hasJohn = uniqueNames.Contains("John");  // true

            // Set operations
            HashSet<string> moreNames = new HashSet<string> { "Jane", "Bob", "Alice" };

            // Union (combines sets, no duplicates)
            uniqueNames.UnionWith(moreNames);

            // Intersection (common elements)
            uniqueNames.IntersectWith(moreNames);

            // Remove elements
            uniqueNames.Remove("John");
        }
        static void DictionaryExample()
        {
            // Creating a Dictionary<TKey, TValue>
            // Key: string (student name), Value: int (score)
            Dictionary<string, int> studentScores = new Dictionary<string, int>();

            // Adding key-value pairs
            studentScores.Add("John", 95);
            studentScores["Jane"] = 98;    // Alternative syntax
            studentScores["Bob"] = 85;

            // Accessing values
            Console.WriteLine($"John's score: {studentScores["John"]}");

            // Safe way to get values (prevents KeyNotFoundException)
            if (studentScores.TryGetValue("Jane", out int janeScore))
            {
                Console.WriteLine($"Jane's score: {janeScore}");
            }

            // Check if key exists
            bool hasStudent = studentScores.ContainsKey("Bob");

            // Updating values
            studentScores["Bob"] = 87;

            // Iterating through the dictionary
            foreach (KeyValuePair<string, int> student in studentScores)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            // Using deconstruction (C# 7+)
            foreach (var (name, score) in studentScores)
            {
                Console.WriteLine($"{name}: {score}");
            }

            // Remove an entry
            studentScores.Remove("Bob");
        }
        static void QueueExample()
        {
            // Creating a Queue (FIFO - First In First Out)
            Queue<string> printQueue = new Queue<string>();

            // Enqueue (add) items to the queue
            printQueue.Enqueue("Document1.pdf");
            printQueue.Enqueue("Document2.pdf");
            printQueue.Enqueue("Document3.pdf");

            Console.WriteLine($"Items in queue: {printQueue.Count}");  // Output: 3

            // Peek at the first item (without removing it)
            string nextToPrint = printQueue.Peek();
            Console.WriteLine($"Next document to print: {nextToPrint}");  // Document1.pdf

            // Dequeue (remove and return) items
            string processing = printQueue.Dequeue();  // removes Document1.pdf
            Console.WriteLine($"Now printing: {processing}");

            // Check if queue contains an item
            bool hasDoc = printQueue.Contains("Document2.pdf");  // true

            // Process entire queue
            while (printQueue.Count > 0)
            {
                // Remove each item in queue
                string currentDoc = printQueue.Dequeue();
                Console.WriteLine($"Processing: {currentDoc}");
            }
        }
        static void StackExample()
        {
            // Creating a Stack (LIFO - Last In First Out)
            Stack<string> browserHistory = new Stack<string>();

            // Push (add) items to the stack
            browserHistory.Push("google.com");
            browserHistory.Push("github.com");
            browserHistory.Push("stackoverflow.com");

            Console.WriteLine($"Pages in history: {browserHistory.Count}");  // Output: 3

            // Peek at the top item (without removing it)
            string currentPage = browserHistory.Peek();
            Console.WriteLine($"Current page: {currentPage}");  // stackoverflow.com

            // Pop (remove and return) items
            string previousPage = browserHistory.Pop();  // removes stackoverflow.com
            Console.WriteLine($"Going back to: {browserHistory.Peek()}");  // github.com

            // Check if stack contains an item
            bool hasPage = browserHistory.Contains("google.com");  // true

            // Process entire stack
            while (browserHistory.Count > 0)
            {
                string page = browserHistory.Pop();
                Console.WriteLine($"Removing: {page}");
            }
        }
        public void Display()
        {
            Console.WriteLine("Display me");
        }
    }

}
