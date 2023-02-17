using System;
using System.Data;
using System.Data.SqlClient;

class Organization
{
    public void GetDetails()
    {
       using (SqlConnection Con = new SqlConnection("data source=LP21; database = OrganizationManagement; integrated security=SSPI"))
        {
            Con.Open();

            OrganizationModel OM = new OrganizationModel();

            Console.WriteLine("Enter Organization Name:");
            OM.Organization_Name = Console.ReadLine();
            Console.WriteLine("Enter Organization Type:");
            OM.Organization_Type = (Organization_Type) Enum.Parse(typeof(Organization_Type),Console.ReadLine());
            Console.WriteLine("Enter Organization Address:");
            OM.Organization_Address = Console.ReadLine();


            String Insert = "GetOrganizationDeatils";
            var SqlCommand = new SqlCommand(Insert,Con);
            SqlCommand.CommandType = CommandType.StoredProcedure;

            SqlCommand.Parameters.AddWithValue("@Organization_Name",OM.Organization_Name);
            SqlCommand.Parameters.AddWithValue("@Organization_Type",OM.Organization_Type);
            SqlCommand.Parameters.AddWithValue("@Organization_Address",OM.Organization_Address);

            Object Id = SqlCommand.ExecuteScalar();

            for (int i=0 ; i<=1; i++)
            {
            
                    EmployeeModel EM = new EmployeeModel();

                    Console.WriteLine("Enter Employee Name:");
                    EM.Employee_Name = Console.ReadLine();
                    Console.WriteLine("Enter Employee Email Id:");
                    EM.Email_Id = Console.ReadLine();


                    String InsertData = "GetEmployeeDeatils";
                    var sqlCommand = new SqlCommand(InsertData,Con);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@Employee_Name",EM.Employee_Name);
                    sqlCommand.Parameters.AddWithValue("@Email_Id",EM.Email_Id);
                    sqlCommand.Parameters.AddWithValue("@Organization_Id ",Id);


                    sqlCommand.ExecuteNonQuery();
            }
             Console.WriteLine("                                                              ");
             Console.WriteLine("Record Inserted Successfully...!!!");
             Console.WriteLine("                                                              ");
            Con.Close();
        }
    }

    public void GetData()
    {
        using(SqlConnection Con = new SqlConnection("data source=LP21; database = OrganizationManagement; integrated security=SSPI"))
        {
            Con.Open();

            String Select = "GetOrganization";

            var SqlCommand= new SqlCommand(Select,Con);

            SqlCommand.CommandType = CommandType.StoredProcedure;
            
            var SqlDataReader  = SqlCommand.ExecuteReader();

            while (SqlDataReader.Read())
                {
                    //Console.WriteLine("Organization_Id = "+ SqlDataReader["Organization_Id"]+"   Organization_Name =" +SqlDataReader["Organization_Name"]+"   Organization_Type = "+SqlDataReader["Organization_Type"]+"   Organization_Address = "+SqlDataReader["Organization_Address"]);
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("Organization_Id : "+ SqlDataReader["Organization_Id"]);
                    Console.WriteLine("Organization_Name : "+SqlDataReader["Organization_Name"]);
                    Console.WriteLine("Organization_Type : "+SqlDataReader["Organization_Type"]);
                    Console.WriteLine("Organization_Address : "+SqlDataReader["Organization_Address"]);
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("                                                              ");
                }

            SqlDataReader.Close();

            String Select1 = "GetEmployee";

            var sqlCommand= new SqlCommand(Select1,Con);

            sqlCommand.CommandType = CommandType.StoredProcedure;

                var sqlDataReader  = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
                {
                    //Console.WriteLine("Employee_Id = "+ sqlDataReader["Employee_Id"]+"   Organization_Id = "+ sqlDataReader["Organization_Id"]+"   Employee_Name = "+sqlDataReader["Employee_Name"]+"   Email_Id = "+sqlDataReader["Email_Id"]);
                    Console.WriteLine("                                                              ");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("Employee_Id : "+ sqlDataReader["Employee_Id"]);
                    Console.WriteLine("Organization_Id : "+ sqlDataReader["Organization_Id"]);
                    Console.WriteLine("Employee_Name : "+sqlDataReader["Employee_Name"]);
                    Console.WriteLine("Email_Id : "+sqlDataReader["Email_Id"]);
                    Console.WriteLine("--------------------------------------------------------------");
                } 
                
                sqlDataReader.Close();
            
             Console.WriteLine("                                                              ");
            Console.WriteLine("Record Retrievd Successfully...!!!");
            Console.WriteLine("                                                              ");
            Con.Close();  
    }
    }

    public void UpdateOrganization()
    {
        using(SqlConnection Con = new SqlConnection("data source=LP21; database = OrganizationManagement; integrated security=SSPI"))
        {
          Con.Open();

            OrganizationModel OM = new OrganizationModel();

            Console.WriteLine("Enter Organization Id:");
            OM.Organization_Id =Convert.ToInt32(Console.ReadLine());
            String Update = "UpdateOrganization";
            var SqlCommand = new SqlCommand(Update,Con);
            SqlCommand.CommandType = CommandType.StoredProcedure;
            SqlCommand.Parameters.AddWithValue("@Organization_Id",OM.Organization_Id);


            Console.WriteLine("Enter Organization Name:");
            OM.Organization_Name = Console.ReadLine();
            Console.WriteLine("Enter Organization Type:");
            OM.Organization_Type = (Organization_Type) Enum.Parse(typeof(Organization_Type),Console.ReadLine());
            Console.WriteLine("Enter Organization Address:");
            OM.Organization_Address = Console.ReadLine();
  

            
            SqlCommand.Parameters.AddWithValue("@Organization_Name",OM.Organization_Name);
            SqlCommand.Parameters.AddWithValue("@Organization_Type",OM.Organization_Type);
            SqlCommand.Parameters.AddWithValue("@Organization_Address",OM.Organization_Address);

            SqlCommand.ExecuteNonQuery();

            Console.WriteLine("                                                              ");
            Console.WriteLine("Organization Record Update Sucessfully");
            Console.WriteLine("                                                              ");
            Con.Close();
        }
    }

    public void Updateemployee()

    {
        using(SqlConnection Con = new SqlConnection("data source=LP21; database = OrganizationManagement; integrated security=SSPI"))
        {

            Con.Open();

            EmployeeModel EM = new EmployeeModel();

            Console.WriteLine("Enter Employee Id:");
            EM.Employee_Id =Convert.ToInt32(Console.ReadLine());
            String Update1 = "UpdateEmployee";
            var sqlCommand = new SqlCommand(Update1,Con);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Employee_Id",EM.Employee_Id);


            Console.WriteLine("Enter Employee Name:");
            EM.Employee_Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Email Id:");
            EM.Email_Id = Console.ReadLine();
            Console.WriteLine("Enter Organization Id:");
            EM.Organization_Id = Convert.ToInt32(Console.ReadLine());


            sqlCommand.Parameters.AddWithValue("@Employee_Name",EM.Employee_Name);
            sqlCommand.Parameters.AddWithValue("@Email_Id",EM.Email_Id);
            sqlCommand.Parameters.AddWithValue("@Organization_Id ",EM.Organization_Id);

            sqlCommand.ExecuteNonQuery();

            Console.WriteLine("                                                              ");
            Console.WriteLine(" Employee Record Update Sucessfully");
            Console.WriteLine("                                                              ");
            Con.Close();
        }  
    }  

    public void RemoveEmployee()
    {
        using(SqlConnection Con = new SqlConnection("data source=LP21; database = OrganizationManagement; integrated security=SSPI"))
        {
            Con.Open();
            EmployeeModel EM = new EmployeeModel();

            Console.WriteLine("Enter Employee Id:");
            EM.Employee_Id =Convert.ToInt32(Console.ReadLine());

            String Remove = "DeleteEmployee";
            var sqlCommand = new SqlCommand(Remove,Con);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Employee_Id",EM.Employee_Id);

            sqlCommand.ExecuteNonQuery();

            Console.WriteLine("                                                              ");
            Console.WriteLine("Employee Record Delete Sucessfully");
            Console.WriteLine("                                                              ");
            Con.Close();
        }
    }

    public void RemoveOrganization()
    {
        using(SqlConnection Con = new SqlConnection("data source=LP21; database = OrganizationManagement; integrated security=SSPI"))
        {
            Con.Open();

            OrganizationModel OM = new OrganizationModel();
            EmployeeModel EM = new EmployeeModel();

             Console.WriteLine("Enter Organization Id:");
             OM.Organization_Id =Convert.ToInt32(Console.ReadLine());

            if (OM.Organization_Id == EM.Organization_Id)
            {
                Console.WriteLine("Please Delete first Employee which REgrence of Organization...");
            }
            else
            {
                
                String Delete = "DeleteOrganization";

                var SqlCommand= new SqlCommand(Delete,Con);

                SqlCommand.CommandType = CommandType.StoredProcedure;

                 SqlCommand.Parameters.AddWithValue("@Organization_Id",OM.Organization_Id);
                
                SqlCommand.ExecuteNonQuery();

            }
            Console.WriteLine("                                                              ");
            Console.WriteLine("Organization Record Remove Sucessfully");
            Console.WriteLine("                                                              ");
            Con.Close();
        }
    }
}