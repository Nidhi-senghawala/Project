class OrganizationModel
{
    public int Organization_Id {get;set;}
    public String Organization_Name{get;set;}
    public Organization_Type Organization_Type{get;set;}
    public String Organization_Address {get;set;}
}

public enum Organization_Type
{
    ProductBase,
    ServiceBase
}