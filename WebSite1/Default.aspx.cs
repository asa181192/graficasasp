using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


public partial class _Default : System.Web.UI.Page


{
    static int[] vectorP = new int[5];
    static int[] vectorN = new int[5];

    protected void Page_Load(object sender, EventArgs e)
    {
      
        bool aux = true; 

        string consulta = Query.consulta(34); //Se envia el transmisdor del cual se requiere obtener la grafica 

        SqlConnection cn = new SqlConnection("Data Source=LAB-SQL1;Initial Catalog=TNC;Integrated Security=True;Connection Timeout=0");
        cn.Open();
        SqlCommand cmd = new SqlCommand(consulta, cn);
        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read()) { //Recuperamos informacion de la base de datos las primeras dos son año y nombre de transmisor 
           for (int i = 0; i < vectorP.Length; i++) //cualquiera de los dos vectores son validos 
                {
                    
                    if (i==1) {
                        Label1.Text = (string) reader.GetValue(i);

                    }
                    else if (aux)
                    {
                        vectorP[i] = (int)reader.GetValue(i);
                    }
                    else
                    {
                        vectorN[i] = (int)reader.GetValue(i);
                    }
                }//fin for 
           aux = false;

              }//fin while 
     
          }

   


    [WebMethod]
    public static List<Data> GetData()
    {
        string [] meses= new string [12]{"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"} ;
        List<Data> dataList = new List<Data>();
        
         for(int i = 0; i < vectorP.Length-2; i++ ) {

             dataList.Add(new Data(meses[i], vectorP[i+2], vectorN[i+2]));
        }  // Se agregan datos a la lista para mandarlos a la vista de la pagina 
        
        
      /*  dataList.Add(new Data("Enero", vectorP[2],vectorN[2]));
        dataList.Add(new Data("Febrero", vectorP[3], vectorN[3]));
        dataList.Add(new Data("Marzo", vectorP[4], vectorN[4]));
        dataList.Add(new Data("Abril", vectorP[5], vectorN[5]));
        dataList.Add(new Data("CMayo", vectorP[6], vectorN[6]));
        dataList.Add(new Data("Junio", vectorP[7], vectorN[7]));
        dataList.Add(new Data("Julio", vectorP[8], vectorN[8]));
        dataList.Add(new Data("Agosto", vectorP[9], vectorN[9]));
        dataList.Add(new Data("Septiembre", vectorP[10], vectorN[10]));
        dataList.Add(new Data("Octubre", vectorP[11], vectorN[11]));
        dataList.Add(new Data("Noviembre", vectorP[12], vectorN[12]));
        dataList.Add(new Data("Diciembre", vectorP[13], vectorN[13]));

        */
        return dataList;
    }
   
}

public class Data
{
    public string ColumnName = "";
    public int ValorP = 0;
    public int ValorN = 0;
    public Data(string columnName, int valueP, int valueN)
    {
        ColumnName = columnName;
        ValorP = valueP;
        ValorN = valueN;
    }
}