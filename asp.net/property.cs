
class employee
{
    public employee()
    {
        name = new employee_details();
    }
    public int id {get; set;}
    public employee_details name{get;set;}
}

class employee_details
{
    public string name{get; set;} 
}
