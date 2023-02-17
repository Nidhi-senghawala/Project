// // See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
//using GenericApplication;

// Student g = new Student();
// {
//     Console.WriteLine(g.GetFullName());
// }

// Student s = new Student();
// Student std = new Student();
// Console.WriteLine("Student saved successfully");

// StudentRepository str = new StudentRepository();
// Console.WriteLine("Student does not exist.");

//stingconnectination.cs
// string name = "Mr." + "Johan." +"bond" + ", code: 001";

// string FirstName = "Johan.";
// string LastName = "bond";
// string code = "001";

// string angent = "Mr." + FirstName + LastName +","+" "+"code:"+ code;

// Console.WriteLine (name);
// Console.WriteLine(angent);

// int i = 0;
// while (i < 10)
// {
//     Console.WriteLine("i={0}",i);
//     i++;
// }

// int i = 0 , j = 0;
// while (i < 2)
// {
//     Console.WriteLine("i="+i);
//     i++;

//     while (j < 2)
//     {
//         Console.WriteLine("j="+j);
//         j++;
//     }
// }

// <summary> Get working days between two dates (Excluding a list of dates - Holidays) </summary>
// <param name="dtmCurrent">Current date time</param>
// <param name="dtmFinishDate">Finish date time</param>
// <param name="lstExcludedDates">List of dates to exclude (Holidays)</param> 
// static int fwGetWorkingDays(this DateTime dtmCurrent, DateTime dtmFinishDate, List<DateTime> lstExcludedDates)
// {
//     Func<DateTime, bool> workDay = currentDate =>
//             (
//                 currentDate.DayOfWeek == DayOfWeek.Saturday ||
//                 currentDate.DayOfWeek == DayOfWeek.Sunday ||
//                 lstExcludedDates.Exists(evalDate => evalDate.Date.Equals(currentDate.Date))
//             );

//     return Enumerable.Range(0, 1 + (dtmFinishDate - dtmCurrent).Days).Count(intDay => workDay(dtmCurrent.AddDays(intDay)));
// }


// public string month;
// public int year;
// {
// var holidays = new List<DateTime>
// {/* list of observed holidays */};
//     DateTime lastBusinessDay = new DateTime();
//     var i = DateTime.DaysInMonth(year, month);
//     while (i > 0)
//     {
//         var dtCurrent = new DateTime(year, month, i);
//         if(dtCurrent.DayOfWeek < DayOfWeek.Saturday && dtCurrent.DayOfWeek > DayOfWeek.Sunday && !holidays.Contains(dtCurrent))
//         {
//             lastBusinessDay = dtCurrent;
//             i = 0;
//         }
//         else
//         {
//             i = i - 1;
//         }
// }
// }

// using System;
// using System.Globalization;



// class Program
// {
//     static int year = new int();
//     static int month = new int();
//     static int[,] calendar = new int[6, 7];
//     private static DateTime date;

//     static void Main(string[] args)
//     {
//         Console.Write("Enter the year? ");
//         year = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter the month (January = 1, etc): ");
//         month = Convert.ToInt32(Console.ReadLine());

//         date = new DateTime(year, month, 1);//gives you a datetime object for the first day of the month
//         DrawHeader();
//         FillCalendar();
//         DrawCalendar();
//         Console.ReadLine();
//     }

//     static void DrawHeader()
//     {
//         Console.Write("\n\n");
//         //gives you the month and year at the top of the calendar
//         Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month) + " " + year);
//         Console.WriteLine("Mo Tu We Th Fr Sa Su");
//     }

//     static void FillCalendar()
//     {
//         int days = DateTime.DaysInMonth(year, month);
//         int currentDay = 1;
//         var dayOfWeek = (int) date.DayOfWeek;
//         for (int i = 0; i < calendar.GetLength(0); i++)
//         {
//             for (int j = 0; j < calendar.GetLength(1) && currentDay - dayOfWeek + 1 <= days; j++)
//             {
//                 if (i == 0 && month > j)
//                 {
//                     calendar[i, j] = 0;
//                 }
//                 else
//                 {
//                     calendar[i, j] = currentDay - dayOfWeek + 1;
//                     currentDay++;
//                 }
//             }
//         }
//     }

//     static void DrawCalendar()
//     {
//         for (int i = 0; i < calendar.GetLength(0); i++)
//         {
//             for (int j = 0; j < calendar.GetLength(1); j++)
//             {
//                 if (calendar[i, j] > 0)
//                 {
//                     if (calendar[i, j] < 10)
//                     {
//                         Console.Write(" " + calendar[i, j] + " ");
//                     }
//                     else
//                     {
//                         Console.Write(calendar[i, j] + " ");
//                     }
//                 }
//                 else
//                 {
//                     Console.Write("   ");
//                 }
//             }
//             Console.WriteLine("");
//         }
//     }
// }


// List<DateTime> mydate = new List<DateTime> ();


//LIST TO weekend day and working day//


/*DateTime start = new DateTime(2023,01,01);
DateTime end = new DateTime(2023,02,28);

List<DateTime> weekend = new List<DateTime> ();
    for (DateTime date = start; date <= end; date = date.AddDays(1))
    {
        if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
            weekend.Add(date);
    }
foreach(var item in weekend)
{
    System.Console.WriteLine("The following date is " + item  + " and day is " + item.DayOfWeek);
}
System.Console.WriteLine("\n");
List<DateTime> workingdays = new List<DateTime> ();
    for (DateTime date = start; date <= end; date = date.AddDays(1))
    {
        if (date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Saturday)
            workingdays.Add(date);
    }
    foreach(var item in workingdays)
    {
        System.Console.WriteLine("The following date is " + item + " and day is " + item.DayOfWeek);
    }
*/

//sum of 2 numbers
//  student s = new student();
//  Console.WriteLine ("sum of 2 interger num :{0}",s.Sum(20,30));

// var i = 10;
// Console.WriteLine("Type of i is {0}", i.GetType());

// var str = "Hello World!!";
// Console.WriteLine("Type of str is {0}", str.GetType());

// var dbl = 100.50d;
// Console.WriteLine("Type of dbl is {0}", dbl.GetType());

// var isValid = true;
// Console.WriteLine("Type of isValid is {0}", isValid.GetType());

// var ano = new { name = "Steve" };
// Console.WriteLine("Type of ano is {0}", ano.GetType());

// var arr = new[] { 1, 10, 20, 30 };
// Console.WriteLine("Type of arr is {0}", arr.GetType());

// var file = new FileInfo("MyFile");
// Console.WriteLine("Type of file is {0}", file.GetType());

/*{
		// string collection
		IList<string> stringList = new List<string>() { 
			"C# Tutorials",
			"VB.NET Tutorials",
			"Learn C++",
			"MVC Tutorials" ,
			"Java" 
		};
		
		// LINQ Query Syntax
		// var result = from s in stringList
		// 			where s.Contains("Tutorials") 
		// 			select s;
		
		foreach (var str in stringList)
		{
			Console.WriteLine(str);
		}
}*/


//DICTIONARY TO WORKING DAY AND WEEKEND//

/*DateTime start = new DateTime(2023,01,01);
DateTime end = new DateTime(2023,02,28);

IDictionary<DateTime,DayOfWeek> weekend = new Dictionary<DateTime,DayOfWeek> ();
    for (DateTime date = start; date <= end; date = date.AddDays(1))
    {
        if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
            weekend.Add(date,date.DayOfWeek);
    }
foreach(var item in weekend)
{
    System.Console.WriteLine("The following date is " + item.Key  + " and day is " + item.Value);
}
System.Console.WriteLine("\n");
List<DateTime> workingdays = new List<DateTime> ();
    for (DateTime date = start; date <= end; date = date.AddDays(1))
    {
        if (date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Saturday)
            workingdays.Add(date);
    }
    foreach(var item in workingdays)
    {
        System.Console.WriteLine("The following date is " + item + " and day is " + item.DayOfWeek);
    }
*/

// ARRAY LIST TO WEEKEND AND WORKING DAY//


/*DateTime start = new DateTime(2023,01,01);
DateTime end = new DateTime(2023,02,28);

ArrayList weekend = new ArrayList();
    for (DateTime date = start; date <= end; date = date.AddDays(1))
    {
        if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
            weekend.Add(date);
    }
foreach(var item in weekend)
{
    System.Console.WriteLine("The following date is " + item  + " and day is " + item);
}
System.Console.WriteLine("\n");

ArrayList workingdays = new ArrayList();
    for (DateTime date = start; date <= end; date = date.AddDays(1))
    {
        if (date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Saturday)
            workingdays.Add(date);
    }
    foreach(var item in workingdays)
    {
        System.Console.WriteLine("The following date is " + item + " and day is " + item);
    }
*/

//ARRAY LIST //

/*ArrayList al = new ArrayList ();
Console.WriteLine ("Adding some numbers:");
al.Add(20);
al.Add(30);
al.Add(45);
al.Add(59);
al.Add(9);
al.Add(15);
al.Add(35);
al.Add(25);
al.Add(85);
al.Add(10);

Console.WriteLine("Capacity:{0}",al.Capacity);
Console.WriteLine("Count:{0}",al.Count);

Console.WriteLine("Content : ");

    foreach(int i in al)
    {
        Console.WriteLine(i + " ");
    }

    Console.WriteLine();
    Console.WriteLine("Sorted content : ");
    al.Sort();
    foreach(int i in al)
    {
        Console.WriteLine(i + " ");
    }
    Console.WriteLine();
    Console.ReadLine();
*/

//USER DEFINE PROPERTIES//

/*

employee emp = new employee ();
// employee_details em1 = new employee_details();

emp.name.name = "j";
Console.WriteLine(emp.name.name);
*/

// HASTABLE //
/*
Hashtable ht = new Hashtable();

ht.Add(001,"aliya");
ht.Add(002,"monika");
ht.Add("003","karina");
ht.Add("004","viki");
ht.Add("006","aha");

if (ht.ContainsValue("era"))
{
    Console.WriteLine("this employee name already in the list .");
}
else 
{
    ht.Add("007","era");
}
ICollection key = ht.Keys;
foreach(var i in key )
{
    Console.WriteLine(i + " : " + ht[i]);
}
// Console.WriteLine();
Console.ReadKey();
*/



//sorted list //
/*
SortedList sl = new SortedList();

sl.Add("001","aliya");
sl.Add("002","monika");
sl.Add("003","karina");
sl.Add("004","viki");
sl.Add("006","aha");

if (sl.ContainsValue("era"))
{
    Console.WriteLine("this employee name already in the list .");
}
else 
{
    sl.Add("007","era");
}
ICollection key = sl.Keys;
foreach(var i in key )
{
    Console.WriteLine(i + " : " + sl[i]);
}
// Console.WriteLine();
Console.ReadKey();
*/


//STACK//
/*
Stack st = new Stack();

st.Push('a');
st.Push('b');
st.Push('h');
st.Push('i');

 Console.WriteLine("Current stack: ");
         foreach (char h in st) 
         {
            Console.WriteLine(h + " ");
         }

Console.WriteLine();

    st.Push('n');
    st.Push('s');
    Console.WriteLine("The next poppable value in stack: ", st.Peek());
    Console.WriteLine("Current stack: ");

foreach(char h in st)
{
Console.WriteLine(h + " ");
}
Console.WriteLine();

Console.WriteLine("removing values : ");
st.Pop();
st.Pop();

Console.WriteLine("curent stack: ");
foreach(char h in st)
{
Console.WriteLine(h + " ");
}
*/

//QUEUE//

/*
Queue q = new Queue();

q.Enqueue('a');
q.Enqueue('b');
q.Enqueue('h');
q.Enqueue('i');

 Console.WriteLine("Current stack: ");
         foreach (char h in q) 
         {
            Console.WriteLine(h + " ");
         }

Console.WriteLine();

    q.Enqueue('n');
    q.Enqueue('s');
    Console.WriteLine("The next poppable value in stack: ", q.Peek());
    Console.WriteLine("Current stack: ");

foreach(char h in q)
{
Console.WriteLine(h + " ");
}
Console.WriteLine();

Console.WriteLine("removing values : ");
q.Dequeue();
q.Dequeue();

Console.WriteLine("curent stack: ");
foreach(char h in q)
{
Console.WriteLine(h + " ");
}
*/

// GENERIC NUM AND CHAR //

/*
{ 
         //declaring an int array
         MyGenericArray<int> intArray = new MyGenericArray<int>(5);
         
         //setting values
         for (int c = 0; c < 5; c++) {
            intArray.setItem(c, c*5);
         }
         
         //retrieving the values
         for (int c = 0; c < 5; c++) {
            Console.Write(intArray.getItem(c) + " ");
         }
         
         Console.WriteLine();
         
         //declaring a character array
         MyGenericArray<char> charArray = new MyGenericArray<char>(5);
         
         //setting values
         for (int c = 0; c < 5; c++) {
            charArray.setItem(c, (char)(c+97));
         }
         
         //retrieving the values
         for (int c = 0; c< 5; c++) {
            Console.Write(charArray.getItem(c) + " ");
         }
         Console.WriteLine();
         
         Console.ReadKey();
}
*/


//SWAPPING TO GENNERIC METHOD//
/*
{
         int a, b;
         char c, d;
         a = 50;
         b = 80;
         c = 'N';
         d = 'P';
         
         //display values before swap:
         Console.WriteLine("Int values before calling swap:");
         Console.WriteLine("a = {0}, b = {1}", a, b);
         Console.WriteLine("Char values before calling swap:");
         Console.WriteLine("c = {0}, d = {1}", c, d);
         
         //call swap
         swapping.Swap<int>(ref a, ref b);
         swapping.Swap<char>(ref c, ref d);
         
         //display values after swap:
         Console.WriteLine("Int values after calling swap:");
         Console.WriteLine("a = {0}, b = {1}", a, b);
         Console.WriteLine("Char values after calling swap:");
         Console.WriteLine("c = {0}, d = {1}", c, d);
         
         Console.ReadKey();
}
*/


//condition//

// #define DEBUG
/*
class Test 
{
   static void function1() 
   {
      Myclass.Message("In Function 1.");
      function2();
   }
   static void function2() 
   {
      Myclass.Message("In Function 2.");
   }
   public static void Main() {
      Myclass.Message("In Main function.");
      function1();
      Console.ReadKey();
   }
}

*/


// obsolete//
/*
public class MyClass {
   [Obsolete("Don't use OldMethod, use NewMethod instead", false)]
   
   static void OldMethod() {
      Console.WriteLine("It is the old method");
   }
   static void NewMethod() {
      Console.WriteLine("It is the new method"); 
   }
   public static void Main() {
      MyClass.NewMethod();
   }
}
*/


////reflection////
/*
class ExecuteRectangle {
      static void Main(string[] args) {
         Rectangle r = new Rectangle(4.5, 7.5);
         r.Display();
         Type type = typeof(Rectangle);
         Console.WriteLine(type);
         
         //iterating through the attribtues of the Rectangle class
         foreach (Object attributes in type.GetCustomAttributes(true)) {
            DeBugInfo dbi = (DeBugInfo)attributes;
            
            if (null != dbi) {
               Console.WriteLine("Bug no: {0}", dbi.BugNo);
               Console.WriteLine("Developer: {0}", dbi.Developer);
               Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
               Console.WriteLine("Remarks: {0}", dbi.Message);
            }
         }
         

         //iterating through the method attribtues
         foreach (MethodInfo m in type.GetMethods())
        { Console.WriteLine("this is a method type "+m); 
            
            foreach (Attribute a in m.GetCustomAttributes(true)) {
                DeBugInfo dbi = (DeBugInfo)a;
               
                if (null != dbi) {
                   Console.WriteLine("Bug no: {0}, for Method: {1}", dbi.BugNo, m.Name);
                   Console.WriteLine("Developer: {0}", dbi.Developer);
                   Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                   Console.WriteLine("Remarks: {0}", dbi.Message);
                }
            }
         }
         Console.ReadLine();
      }
   }
*/

//inderxer//
/*
         IndexedNames names = new IndexedNames();
         names[0] = "Zara";
         names[1] = "Riz";
         names[2] = "Nuha";
         names[3] = "Asif";
         names[4] = "Davinder";
         names[5] = "Sunil";
         names[6] = "Rubic";
         
         for ( int i = 0; i < IndexedNames.size; i++ ) {
            Console.WriteLine(names[i]);
         }

         Console.WriteLine(names["aditi"]);
         Console.ReadKey();
        //  Console.ReadKey();
*/

// unsafe code //

/*unsafe  {
         int var = 20;
         int* p = &var;
         
         Console.WriteLine("Data is: {0} ",  var);
         Console.WriteLine("Data is: {0} " , *p);
         Console.WriteLine("Address is: {0}",  (int)p);
         Console.ReadKey();
      }
      */

// swapping with unsafe code //

/*unsafe {
        TestPointer p = new TestPointer();
        int var1 = 10;
        int var2 = 20;
        int* x = &var1;
        int* y = &var2;

        Console.WriteLine("Before Swap: var1:{0}, var2: {1}", var1, var2);
        p.swap(x, y);

        Console.WriteLine("After Swap: var1:{0}, var2: {1}", var1, var2);
        Console.ReadKey();
     }
   */

/*unsafe{
    int[]  list = {10, 100, 200};



     for ( int i = 0; i < 3; i++)
     fixed(int *ptr = list)
      {
*/
/*user define array*/
/*
Console.WriteLine("Enter array value :");
list[i] = Convert.ToInt32(Console.ReadLine());
*/
/* let us have array address in pointer */
/*
Console.WriteLine("Address of list[{0}]={1}",i,(int)(ptr + i));
Console.WriteLine("Value of list[{0}]={1}", i, (list[i]));
}

Console.ReadKey();
}
*/

//delegrates multicasting//

/*
TestDelegate td = new TestDelegate();
{
     //create delegate instances
     NumberChanger nc;
     NumberChanger nc1 = new NumberChanger(td.AddNum);
     NumberChanger nc2 = new NumberChanger(td.MultNum);

     //calling the methods using the delegate objects
     nc1(35);
     Console.WriteLine("Value of Num: {0}", td.getNum());
      nc2(10);
     Console.WriteLine("Value of Num: {0}", td.getNum());
     //Console.ReadKey();

     nc = nc2;
     nc += nc1;

     //calling multicast
     nc(5);
     Console.WriteLine("Value of Num: {0}", td.getNum());
     Console.ReadKey();

  }
*/

/////// Event ///////
/*
EventProgram obj1 = new EventProgram();
         string result = obj1.MyEvent("Tutorials Point");
         Console.WriteLine(result);
 */        


/*
p.ProcessBusinessLogic bl = new p.ProcessBusinessLogic();
        bl.ProcessCompleted +=  bl_ProcessCompleted; // register with an event

void bl_ProcessCompleted()
{
    throw new NotImplementedException();
}

bl.StartProcess();

        void StartProcess()
    {
        Console.WriteLine("Process Started!");
        // some code here..
        OnProcessCompleted();
    }

void OnProcessCompleted()
{
    throw new NotImplementedException();
}
*/


//// Anonymous ////
/* 
         //create delegate instances using anonymous method
         NumberChanger nc = delegate(int x) {
            Console.WriteLine("Anonymous Method: {0}", x);
         };
         nc(10);

         nc =  new NumberChanger(TestDelegate.AddNum);
          nc(5);
         
          nc =  new NumberChanger(TestDelegate.MultNum);
         nc(2);


         Console.ReadKey();
*/


//////thread//////

/*
 class MainThreadProgram {
      
      static void Main(string[] args) {
         Thread th = Thread.CurrentThread;
         th.Name = "MainThread";
         Console.WriteLine("This is {0}", th.Name);
         Console.ReadKey();
      }
   }
   */

/*
   class ThreadCretionProgram
   {
    public static void CallToChildThread()
    {

        Console.WriteLine("Child thread starts");

        int sleepfor = 50000;

        Console.WriteLine("Child Thread Paused for {0} seconds ",sleepfor/10000);
        Thread.Sleep(sleepfor);
        Console.WriteLine("Child thread resumes");
    }
    static void Main(string[] args) 
    {
        ThreadStart chiledref = new ThreadStart(CallToChildThread);
        Console.WriteLine("In Main : Creating the child thread");

        Thread childThread  = new Thread (chiledref);
        childThread.Start();
        Console.ReadKey();
    }
   }
*/


///////thread///////
/*
class ThreadCretionProgram
   {
    public static void CallToChildThread()
    {
        try
        {
            Console.WriteLine("Child Thread Start");

            for(int counter = 0; counter <= 10; counter++)
            {
                Thread.Sleep(500);
                Console.WriteLine(counter);
            }
            Console.WriteLine("Child Thread Completed");
        }
        catch(ThreadAbortException e)
        {
            Console.WriteLine("Thread Abort Exception");
        }
        finally
        {
            Console.WriteLine("Couldn't Catch Thread Exception");
        }
    }
    static void Main(string[] args) 
    {
        ThreadStart chiledref = new ThreadStart(CallToChildThread);
        Console.WriteLine("In Main : Creating the child thread");

        Thread childThread  = new Thread (chiledref);
        childThread.Start();
       
       Thread.Sleep(2000000000);

       Console.WriteLine("In Mian : Aborting  The Child Thread");

       childThread.Abort();
       Console.ReadKey();
    }
   }
   */

Task T = new Task();
// T.GetUserDetail();
// T.GetData();
int A;
Console.WriteLine("Enter A:");
A= Convert.ToInt32(Console.ReadLine());

switch(A)
{
    case 1 : 
        T.GetUserDetail();
    break;

    case 2: 
        T.GetData();
    break;

    case 3 :
        T.DeleteData();
    break;

}
