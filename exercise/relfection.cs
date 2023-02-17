using System;
using System.Reflection;
[AttributeUsage(
      AttributeTargets.Class |
      AttributeTargets.Constructor |
      AttributeTargets.Field |
      AttributeTargets.Method |
      AttributeTargets.Property,
      AllowMultiple = true)]

public class StudentInfo : System.Attribute
{
    // public string FirstName , LastName ;
    // private string FullName;
    // public string RollNumber , Standard ;

    public bool IsValid(object value)
    {
         if (value == null || string.IsNullOrEmpty(value.ToString()))
        {
            return false;
            }
        return true;
    
    }

   /* public StudentInfo(string FirstName, string LastName, string RollNumber, string Standard)
    {
        FirstName = " ";
        LastName = " ";
        FullName = FirstName +" "+ LastName;
        RollNumber = " ";
        Standard = " ";
    }
    public StudentInfo(string s,string s1)
      {
            if(s1=="First_Name")
            {
               FirstName=s.ToString();
            }
            else if(s1=="Last_Name")
            {
               LastName=s.ToString();
            }
            else if(s1=="Roll_Number")
            {
               
              RollNumber=s.ToString(); 
            }
            else if(s1=="Standrad_")
            {
               Standard=s.ToString();
            }

      }
     
       public string  First_Name
       {get
       {
            return FirstName;
       }
       }
       
       public string Last_Name
       {get
       {
        return LastName;
       }
       }
     
    //    public string FullName
    //    {get 
    //         {
    //             return FirstName + " " + LastName;
    //         }
    //     }
     
       public string Roll_Number
       {get
       {
        return RollNumber;
       }}
    
       public string Standard_{get
       {
            return Standard;
       }
       }
    
    // public void display ()
    
    // {
    //     Console.WriteLine("First Name : {0}",FirstName);
    //     Console.WriteLine("Last Name : {0}",LastName);
    //     Console.WriteLine("Full Name : {0}",FullName);
    //     Console.WriteLine("Roll Number : {0}",RollNumber);
    //     Console.WriteLine("Standard : {0}",Standard);
    // }

    }
      
//  [StudentDetails(fn,ln,FullName,RollNumber,Standarad)]  
*/
}
class StudentDetails
    {
        
        [StudentInfo]
       public string  First_Name{get;set;}
      
       
       
       [StudentInfo]
       public string Last_Name{get;set;}
      
      
            public string Full_Name
       {get 
            {
                return First_Name + " " + Last_Name;
            }
        }
        
         [StudentInfo]
       public string Roll_Number{get;set;}
      
      [StudentInfo]
       public string Standard_{get;set;}
      
     
       public void display ()
    {
        Console.WriteLine("Full Name : {0}",Full_Name);
        Console.WriteLine("Roll Number : {0}",Roll_Number);
        Console.WriteLine("Standard : {0}",Standard_);
    }
    public void getdetails()
    {
        
        Type type = typeof(StudentDetails);
       PropertyInfo[] properties=type.GetProperties();

        foreach (PropertyInfo p in properties)

        {

            foreach (Attribute a in p.GetCustomAttributes(true))
            {
                StudentInfo SI = (StudentInfo)a;

                if (null != SI)
                {
                   
                    while (true)
                    {
                        Console.WriteLine("Enter {0}",p.Name);
                        var value = Console.ReadLine();
                        if (SI.IsValid(value)){
                            p.SetValue(this,value);
                            break;}
                        else
                            Console.WriteLine("{0} Cannot be empty",p.Name);
                    }
    }}}}



    
    }

    
    