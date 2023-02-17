//  Console.WriteLine("Fill Student Details");

//         /*string fn, ln;
//         int rn,std;*/



//         //Console.WriteLine("Please enter first name.");
//         /*
//         Console.WriteLine("Enter First Name: ");
//         fn = Console.ReadLine();
//         */

//         /*
//         while (true)
//                 {
//                     Console.WriteLine("Enter First Name: ");
//                     fn = Console.ReadLine();
//                     if (!String.IsNullOrEmpty(fn))
//                         break;
//                     else
//                         Console.WriteLine("Please Enter First Name.");
//                 }

//                 */

//         // Console.WriteLine("Please enter last name.");
//         /*
//         Console.WriteLine("Enter Last Name: ");
//         ln = Console.ReadLine();
//         */

//         /*while (true)
//                 {
//                     Console.WriteLine("Enter Last Name: ");
//                     ln = Console.ReadLine();
//                     if (!String.IsNullOrEmpty(ln))
//                         break;
//                     else
//                         Console.WriteLine("Please Enter Last Name.");
//                 }*/

//         //Console.WriteLine(" please enter roll number.");
//         /*
//         Console.WriteLine("Enter Roll Number: ");
//         rn = Convert.ToInt32(Console.ReadLine());
//         */

//         /*while (true)
//                 {
//                     Console.WriteLine("Enter Roll Number: ");
//                     rn = Convert.ToInt32(Console.ReadLine());
//                     if (!String.IsNullOrEmpty(rn.ToString()))
//                         break;
//                     else
//                         Console.WriteLine("Please Enter Roll No.");
//                 }*/

//         //Console.WriteLine("Please enter standard.");
//         /*
//         Console.WriteLine("Enter Standard:");
//         std = Convert.ToInt32(Console.ReadLine());
//         */

//         /*while (true)
//                 {
//                     Console.WriteLine("Enter Standard:");
//                    std = Convert.ToInt32(Console.ReadLine());
//                     if (!String.IsNullOrEmpty(std.ToString()))
//                         break;
//                     else
//                         Console.WriteLine("Please Enter Standard.");
//                 }*/



//         //StudentInfo si = new StudentInfo(fn,ln,rn,std);

//         //display();



//         Type type = typeof(StudentDetails);

//         foreach (PropertyInfo p in type.GetProperties())

//         {

//             foreach (Attribute a in p.GetCustomAttributes(true))
//             {
//                 StudentInfo SI = (StudentInfo)a;

//                 if (null != SI)
//                 {
//                     //while (true)
//                     //      {
//                     //         Console.WriteLine("Enter {0}: ", p.Name);
//                     //         var value = Console.ReadLine();

//                     //         if (SI.IsValid(value))
//                     //         {
//                     //             p.SetValue(SI, value);
//                     //             break;
//                     //         }
//                     //         else
//                     //         {
//                     //             Console.WriteLine("{0} cannot be empty.", p.Name);
//                     //         }
//                     /*Console.WriteLine("Enter First Name: {0}",SI.FirstName,p.Name);
//                     Console.ReadLine();*/
//                     while (true)
//                     {
//                         Console.WriteLine("Enter First Name: {0}",p.Name);
//                         var value = Console.ReadLine();
//                         if (!string.IsNullOrEmpty(value)){
//                             p.SetValue(this,value);
//                             break;}
//                         elsei8
//                             Console.WriteLine("Please Enter First Name.");
//                     }
//                     /*Console.WriteLine("Enter Last Name: {0}",SI.LastName);
//                     // Console.ReadLine();*/
//                     // while (true)
//                     // {
//                     //     Console.WriteLine("Enter Last Name: {0}", SI.LastName);
//                     //     Console.ReadLine();
//                     //     if (!string.IsNullOrEmpty(SI.LastName))
//                     //         break;
//                     //     else
//                     //         Console.WriteLine("Please Enter Last Name.");
//                     // }
//                     // while (true)
//                     // {
//                     //     Console.WriteLine("Full Name: {0}", SI.FirstName + " " + SI.LastName );
//                     //     /*Console.WriteLine("RollNumber: {0}", SI.RollNumber);
//                     //     Console.ReadLine();*/
//                     // }
//                     // while (true)
//                     // {
//                     //     Console.WriteLine("RollNumber: {0}", SI.RollNumber);
//                     //     Console.ReadLine();
//                     //     if (!string.IsNullOrEmpty(SI.RollNumber))
//                     //         break;
//                     //     else
//                     //         Console.WriteLine("Please Enter Roll No.");
//                     // }
//                     // /*Console.WriteLine("Standard: {0}",SI.Standard);
//                     // Console.ReadLine();*/
//                     // while (true)
//                     // {
//                     //     Console.WriteLine("Standard: {0}", SI.Standard);
//                     //     Console.ReadLine();
//                     //     if (!string.IsNullOrEmpty(SI.Standard))
//                     //         break;
//                     //     else
//                     //         Console.WriteLine("Please Enter Standard.");
//                     // }

//                     //  StudentDetails sd = new StudentDetails();
//                     //  sd.display();
//                 }
//             }
//         }
//     }
// }