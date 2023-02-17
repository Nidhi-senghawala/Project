
using System;
using System.Data;
using System.Data.SqlClient;

class Task
{
   SqlConnection Con = new SqlConnection("data source=LP21; database=Librabry; integrated security=SSPI");
        
    public  void GetUserDetail()
    {
         SqlConnection Con = new SqlConnection("data source=LP21; database=Librabry; integrated security=SSPI");

            Con.Open();
            string Query = "Select * From Customer";
            var SqlCommand= new SqlCommand(Query,Con);
            var SqlDataReader  = SqlCommand.ExecuteReader();
            //var SDR = sc.ExecuteReader();


            while (SqlDataReader.Read())
            {
                Console.WriteLine(SqlDataReader["Customer_Name"]);
            }

            //Console.WriteLine(SDR);
            Con.Close();

    }
    public void GetData()
    {   
        SqlConnection Con = new SqlConnection("data source=LP21; database=Librabry; integrated security=SSPI");
        Con.Open();
        Property p = new Property();

        Console.WriteLine("Enter Customer Name :");
        p.Customer_Name = Console.ReadLine();
        Console.WriteLine("Enter PhoneNo :");
        p.PhoneNo = Console.ReadLine();
        
        
        String Query1 = "Insert Into Customer(Customer_Name,PhoneNo) Values(@name,@phoneno)";
        var SqlCommand= new SqlCommand(Query1,Con);

        //SqlCommand.CommandType = CommandType.Text;

        //var sqlCommand=new SqlCommand();

        // sqlCommand.Parameters.Add(new SqlParameter("@name",SqlDbType.VarChar,50));
        // SqlCommand.Parameters["@name"].Value = Customer_Name.Value;
        // sqlCommand.Parameters.Add(new SqlParameter("@phoneno",SqlDbType.VarChar,50));
        // SqlCommand.Parameters["@phoneno"].Value = PhoneNo.Value;

        SqlCommand.Parameters.AddWithValue("@name",p.Customer_Name);
        SqlCommand.Parameters.AddWithValue("@phoneno",p.PhoneNo);

        // SqlCommand.Parameters.Add("@name,",p.Customer_Name);
        //sqlCommand.Parameters.AddWithValue("@phoneno",p.PhoneNo);

        SqlCommand.ExecuteNonQuery();  
        Console.WriteLine("Record Inserted Sucessfully..!!!");
        Con.Close();
    }

    public void DeleteData()
    {
         SqlConnection Con = new SqlConnection("data source=LP21; database=Librabry; integrated security=SSPI");
        //SqlConnection Con = null;

        var SqlCommand =new SqlCommand("Delete From Customer Where Customer_Id = @id",Con);
        Con.Open();

        Console.WriteLine("Enter Id:");
        int A = Convert.ToInt32(Console.ReadLine());
        SqlCommand.Parameters.AddWithValue("@id",A);
        SqlCommand.ExecuteNonQuery();
        Console.WriteLine("Record Deleted Successfully..!!");
        Con.Close();
    }

    
}
