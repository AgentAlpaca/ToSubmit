using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

/// <summary>
/// Summary description for productservice
/// </summary>
public class productservice
{
  
    protected OleDbConnection myconnection;
    public productservice()
    {

        string connectionsting = connectionsting = Connect.getConnectionString();
        myconnection = new OleDbConnection(connectionsting);
    }
    public DataSet getData()
    {
        OleDbCommand myCmd = new OleDbCommand("q1", myconnection);
        myCmd.CommandType = CommandType.StoredProcedure;

        OleDbDataAdapter adapter = new OleDbDataAdapter();
        adapter.SelectCommand = myCmd;

        DataSet dataset = new DataSet();

        try
        {
            myconnection.Open();
            adapter.Fill(dataset, "ProductTable");
            dataset.Tables["ProductTable"].PrimaryKey = new DataColumn[] { dataset.Tables["ProductTable"].Columns["num"] };
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
    public void addData(string ProductName, double Price, int SupplierNum, string Picture)
    {
        OleDbCommand myCmd = new OleDbCommand("q2", myconnection);
        myCmd.CommandType = CommandType.StoredProcedure;

        OleDbParameter objParam;

        objParam = myCmd.Parameters.Add("@ProductName", OleDbType.BSTR);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = ProductName;

        objParam = myCmd.Parameters.Add("@Price", OleDbType.BSTR);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = Price;

        objParam = myCmd.Parameters.Add("@SupplierNum", OleDbType.Integer);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = SupplierNum;

        objParam = myCmd.Parameters.Add("@Picture", OleDbType.BSTR);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = Picture;

        try
        {
            myconnection.Open();
            int n = myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            myconnection.Close();
        }
    }
}