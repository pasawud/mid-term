using System;
using System.Collections.Generic;
using System.Collections;


namespace mid_term_2
{
    enum Mainmenu
    {
        Login = 1,
        Register = 2,
    }
    class Program
    {
        static PersonList personList;
        //main menu
        static void Main(string[] args)
        {
            Program.personList = new PersonList();
            PrintMainMenu();
        }
        //แสดงผล menuหลักและรับค่า
        static void PrintMainMenu()
        {
            PrintHeader(1);
            PrintMenuList();
            InputMenuFromKeyboard();
        }
        //เลือกเมนู
        static void PrintMenuList()
        {
            Console.WriteLine("1. Login ");
            Console.WriteLine("2. Register");
        }
        //รับค่า
        static void InputMenuFromKeyboard()
        {
            Console.Write("Select Menu : ");
            Mainmenu menu = (Mainmenu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }
        //รับค่าแล้วแล้วรัน enum
        static void PresentMenu(Mainmenu menu)
        {
            if (menu == Mainmenu.Login)
            {
                LoginMenu();
            }
            else if (menu == Mainmenu.Register)
            {
                RegisterMenu();
            }
            else
                InputMainMenuError();
        }
        //ล็อคอิน
        static void LoginMenu()
        {
            PrintHeader(3);
            DisplayLogin();
        }
        //รับค่า name,pass
        static void DisplayLogin()
        {
            string name = InputName();
            string password = InputPassword();

            LoginStuff(name, password);
        }
        static string InputPassword()
        {
            Console.Write("Input password : ");

            string password = Console.ReadLine();

            return password;
        }
        static void LoginStuff(string name, string password)
        {
            Person Test = new Person("0", "0");

            int counter = 0;

            foreach (Person person in Program.personList.GetPersonList())
            {
                if (name == person.username)
                {
                    Test = person;
                    break;
                }
                counter++;
            }
            if (Test.username == "0")
            {
                Console.WriteLine("Invalid User name Input , please try again");

                Console.WriteLine("");

                PrintMainMenu();
            }

            if (password == Test.GetPassword())
            {
                Console.WriteLine("User exist on Database ");

                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("Invaild Password Input , please try again");

                Console.WriteLine("");

                PrintMainMenu();
            }

            if (Test is Student)
            {
                List<Person> numberList = personList.GetPersonList();
                Student TStudent = numberList[counter] as Student;

                PrintHeader(4);
                PrintName(name);
                PrintStudentID(TStudent.studentID);

            }

            if (Test is Employee)
            {
                List<Person> numberList = personList.GetPersonList();
                Employee TEmployee = numberList[counter] as Employee;

                PrintHeader(5);
                PrintName(name);
                PrintEmployeeID(TEmployee.employeeID);

            }
        }

        static void PrintName(string name)
        {
            Console.WriteLine("Name : {0}", name);
        }
        static void PrintStudentID(string input)
        {
            Console.WriteLine("StudentID : {0}", input);
        }
        static void PrintEmployeeID(string employeeid)
        {
            Console.WriteLine("EmployeeID : {0}", employeeid);
        }

        static string InputName()
        {
            Console.Write("Input name : ");

            string name = Console.ReadLine();

            return name;
        }
        static void InputMainMenuError()
        {
            Console.WriteLine("Invaild menu input , Please try again ");

            Console.WriteLine("");

            PrintMainMenu();
        }
        static void RegisterMenu()
        {
            PrintHeader(2);
            RegisterFromKeyboard();
        }
        static void RegisterFromKeyboard()
        {
            string name = InputName();
            string password = InputPassword();
            int menutype = InputUserType();

            CheckWhatType(name, password, menutype);
        }
        static void CheckWhatType(string name, string password, int usertype)
        {
            if (usertype == 1)
            {
                Student student = CreateNewStudent(name, password);
                Program.personList.AddNewPerson(student);

                PrintMainMenu();
            }
            else if (usertype == 2)
            {
                Employee employee = CreateEmployee(name, password);
                Program.personList.AddNewPerson(employee);

                PrintMainMenu();
            }
        }
        static int InputUserType()
        {
            Console.Write("Input User Type 1 = Student, 2 = Employee : ");

            int usertype = int.Parse(Console.ReadLine());

            return usertype;
        }
        static void PrintHeader(int menu)
        {
            if (menu == 1)
            {
                Console.WriteLine("Welcome to the Digital Library!");
                Console.WriteLine("-------------------------------");
            }
            if (menu == 2)
            {
                Console.WriteLine("Register new Person-");
                Console.WriteLine("--------------------");
            }
            if (menu == 3)
            {
                Console.WriteLine("Login Screen-----");
                Console.WriteLine("-----------------");
            }
            if (menu == 4)
            {
                Console.WriteLine("Student Management-");
                Console.WriteLine("-------------------");
            }
            if (menu == 5)
            {
                Console.WriteLine("Employee Management-");
                Console.WriteLine("--------------------");
            }
        }static Student CreateNewStudent(string name, string password)
        {
            return new Student(name, password, StudentID());
        }

        static Employee CreateEmployee(string name, string password)
        {
            return new Employee(name, password, EmployeeID());
        }
        static string StudentID()
        {
            Console.Write("Student ID : ");

            string studentid = Console.ReadLine();

            return studentid;
        }
        static string EmployeeID()
        {
            Console.Write("Employee ID : ");

            string employeeid = Console.ReadLine();

            return employeeid;
        }
    }
}
        