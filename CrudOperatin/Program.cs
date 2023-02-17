// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Organization O = new Organization();

int No ;
Console.WriteLine("Get No Details....");
Console.WriteLine("                                                              ");
Console.WriteLine("1 Get Details.");
Console.WriteLine("2 Insert Record");
Console.WriteLine("3 Update Organization Record");
Console.WriteLine("4 Update Employee Record");
Console.WriteLine("5 Delete Employee Record");
Console.WriteLine("6 Delete Organization Record");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("                                                              ");

Console.WriteLine("Enter No:");
No = Convert.ToInt32(Console.ReadLine());

switch(No)
{
    case 1 :
        Console.WriteLine("Retrieved Record...");
         Console.WriteLine("                                                              ");
        O.GetData();
        break;

    case 2 :
        Console.WriteLine("Record Inserted Here...");
        Console.WriteLine("                                                              ");
        O.GetDetails();
        break;

    case 3 :
        Console.WriteLine("Update Ogranization Record Here...");
         Console.WriteLine("                                                              ");
        O.UpdateOrganization();
        break;

    case 4 :
        Console.WriteLine("Update Employee Record Here...");
        Console.WriteLine("                                                              ");
        O.Updateemployee();
        break;

    case 5 :
        Console.WriteLine("Delete  Employee Record ...");
        Console.WriteLine("                                                              ");
        O.RemoveEmployee();
        break;

    case 6 :
        Console.WriteLine("Delete Organization Record ...");
        Console.WriteLine("                                                              ");
        O.RemoveOrganization();
        break;
}