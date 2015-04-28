using System;
using System.Collections.Generic;
using System.Web.Services;
 

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

     [WebMethod]
    public static List<Data> GetData()
    {
        List<Data> dataList = new List<Data>();
 
        dataList.Add(new Data("Enero", 100,121));
        dataList.Add(new Data("Febrero", 200,121));
        dataList.Add(new Data("Marzo", 300,121));
        dataList.Add(new Data("Abril", 400,121));
        dataList.Add(new Data("CMayo", 100, 121));
        dataList.Add(new Data("Junio", 200, 121));
        dataList.Add(new Data("Julio", 300, 121));
        dataList.Add(new Data("Agosto", 400, 121));
        dataList.Add(new Data("Septiembre", 100, 121));
        dataList.Add(new Data("Octubre", 200, 121));
        dataList.Add(new Data("Noviembre", 300, 121));
        dataList.Add(new Data("Diciembre", 400, 121));

 
        return dataList;       
    }
}
 
public class Data
{
    public string ColumnName = "";
    public int ValorP = 0;
    public int ValorN = 0;
    public Data(string columnName, int valueP,int valueN)
    {
        ColumnName = columnName;
        ValorP = valueP ; 
        ValorN = valueN ; 
    }
}
