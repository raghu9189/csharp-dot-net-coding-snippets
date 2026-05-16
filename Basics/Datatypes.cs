namespace MyApp2.Basics
{

    class Person
    {
        private string _name;
        public Person(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }

    class Car
    {
        string _name;
        public Car(string name)
        {
            _name = name;
        }
    }
    class DataTypes
    {
        public static void Run()
        {
            // Value Types
            // Integers
            byte byteValue = 2;
            short shortValue = 20;
            int serielNo = 0;
            long longValue = 3444L;

            // Floating Points
            float floatValue = 23000.00f;
            double doubleValue = 34000.00d;
            decimal decimalValue = 321222.89m;

            // Boolean 
            bool isHuman = true;

            // Character 
            char gender = 'M';

            // Reference Types
            // String
            string name = "Raghu Ballu";

            // Class
            Person person = new Person("Raghu Class");
            Car myCar = new Car("Audi");
            Fruit banana = new Fruit("Banana");

            // Arrays
            int[] numbers = { 1, 2, 3, 4 };

            int? age = null;

            // Object Type
            object myValue = 34L;



            Console.WriteLine("hello raghu");
            Console.WriteLine($"{byteValue} {serielNo} {shortValue} {longValue}");
            Console.WriteLine($"{floatValue} {doubleValue} {decimalValue} ");
            Console.WriteLine($"{isHuman}");
            Console.WriteLine($"{gender} {name}");
            System.Console.WriteLine(person.GetName());
            foreach (int number in numbers)
            {
                System.Console.WriteLine(number);
            }
            System.Console.WriteLine(age);
            if (age == null)
            {
                System.Console.WriteLine("Yes age is null");
            }
            System.Console.WriteLine(myValue);
            banana.Name = "Kiwi";
            System.Console.WriteLine(banana.Name);

            int count = 0;
            while (count < 10)
            {
                System.Console.WriteLine(count);
                count++;
            }

            // Nullable Types
            int? bodyCount = null;
            int finalBodyCount = bodyCount ?? 34;
            System.Console.WriteLine(bodyCount.HasValue);
            System.Console.WriteLine(finalBodyCount);
            System.Console.WriteLine(bodyCount ?? 78);

            // Nullable Reference types
            string? userName = null;
            if (userName != null)
            {
                System.Console.WriteLine(userName.Length);
            }
            else
            {
                System.Console.WriteLine("User name is null");
            }

            // Implicit type

            foreach (var myNumber in numbers)
            {
                System.Console.WriteLine($"Number is {myNumber}");
            }

            // Arrays Advanced
            MyArrays.AllArrays();

            // Classes
            var myPeacock = new Peacock();
            myPeacock.eat();
            myPeacock.sleep();
            myPeacock.animalSound();

            // Primary Constructor
            var emp1 = new Employee("Software Developer");
            System.Console.WriteLine(emp1.Name);

            var citizen = new Citizen();
            if (citizen.Name is null) System.Console.WriteLine("Citizen is null");
            citizen.Name = "Peter Parker";
            System.Console.WriteLine(citizen.Name);

        }
    }
}

// Common Reference Types
// | Type        | Example             |
// | ----------- | ------------------- |
// | `string`    | Text                |
// | `class`     | Custom objects      |
// | `array`     | Collections         |
// | `interface` | Contracts           |
// | `delegate`  | Function references |
