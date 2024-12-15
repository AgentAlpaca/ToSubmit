using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.OleDb;
/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    [WebMethod]
    public string HelloWorld2(string name)
    {
        return "Hello World "+ name;
    }
    [WebMethod]
    public double Multiply(double num, double num2)
    {
        return num*num2;
    }
    [WebMethod]
    public double Div(double num, double num2)
    {
        if (num2 != 0)
        {
            return num / num2;
        }
        return 0;
    }
    [WebMethod]
    public double add(double num1, double num2)
    {
        return num1 + num2;
    }
   
    [WebMethod]
    public DataSet getAnimals()
    {
        animalService user = new animalService();
        DataSet ds = user.getAnimals();
        return ds;
    }
    [WebMethod]
    public double sub(double num1, double num2)
    {
        return num1 - num2;
    }


}
