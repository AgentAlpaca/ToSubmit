using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for animalService
/// </summary>
public class animalService
{
    protected OleDbConnection myconnection;
    public animalService()
    {
        string connectionstring = Connect.getConnectionString();
        myconnection = new OleDbConnection(connectionstring);
    }
    public DataSet getAnimals()
    {
        OleDbCommand myCmd = new OleDbCommand("select1", myconnection);
        myCmd.CommandType = CommandType.StoredProcedure;
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        adapter.SelectCommand = myCmd;
        DataSet dataset = new DataSet();
        try
        {
            myconnection.Open();
            adapter.Fill(dataset, "shop");
            dataset.Tables["shop"].PrimaryKey = new DataColumn[] { dataset.Tables["shop"].Columns["num"] };

        }
        catch (Exception ex)
        {
            throw ex;
        }
            finally
        {
            myconnection.Close();
        }
            return dataset;
    }

    public void addAnimal(string name1, string family1,int age1, string picture)
    {
        OleDbCommand myCmd = new OleDbCommand("insert1", myconnection);
        myCmd.CommandType = CommandType.StoredProcedure;

        OleDbParameter objParam;
        objParam = myCmd.Parameters.Add("@name", OleDbType.BSTR);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = name1;
        objParam = myCmd.Parameters.Add("@family", OleDbType.BSTR);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = family1;
        objParam = myCmd.Parameters.Add("@age", OleDbType.BSTR);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = age1;
        objParam = myCmd.Parameters.Add("@picture", OleDbType.BSTR);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = picture;
        try
        {
            myconnection.Open();
            int n = myCmd.ExecuteNonQuery();
        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally
        {
            myconnection.Close();
        }
    }
    //delete from animals where (code )
    public void deleteAnimal(int codea)
    {
        OleDbCommand myCmd = new OleDbCommand("delete1", myconnection);
        myCmd.CommandType = CommandType.StoredProcedure;

        OleDbParameter objParam = new OleDbParameter();
        objParam.ParameterName = "@codea";
        objParam.Value = codea;

        objParam.Direction = ParameterDirection.Input;
        myCmd.Parameters.Add(objParam);

        try
        {
            myconnection.Open();
            int n = myCmd.ExecuteNonQuery();

        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally
        {
            myconnection.Close();
        }
    }
}