using System;
using System.Web;
public class Connect
{
    const string FILENAME = "shop.mdb";

    public static string getConnectionString()
    {
        //string location = HttpContext.Current.Server.MapPath("@../../App_Data/" + FILENAME);
        string location = HttpContext.Current.Server.MapPath("~/App_Data/" + FILENAME);
        string ConnectionString = @"Provider=Microsoft.Ace.OLEDB.12.0; data source=" + location; ;
        return ConnectionString;
    }
}

