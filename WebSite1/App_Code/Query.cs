using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for query
/// </summary>
public class Query
{

    public static String consulta()
    {
        string conecction = "SELECT"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 1 then Count(t.TransferId) end as ENERO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 3 then Count(t.TransferId) end as MARZO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 2 then Count(t.TransferId) end as FEBRERO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 4 then Count(t.TransferId) end as ABRIL,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 5 then Count(t.TransferId) end as MAYO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 6 then Count(t.TransferId) end as JUNIO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 7 then Count(t.TransferId) end as JULIO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 8 then Count(t.TransferId) end as AGOSTO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 9 then Count(t.TransferId) end as SEPTIEMBRE,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 10 then Count(t.TransferId) end as OCTUBRE,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 11 then Count(t.TransferId) end as NOVIEMBRE,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 12 then Count(t.TransferId) end as DICIEMBRE,"
+ " YEAR(t.DateOfTransfer) as año,"
+ " i.InstitutionRoleXrefName  as Name"
+ " INTO #temp"
+ " FROM [Production].[Transfer] t (nolock)"
+ " JOIN [Production].[TransferPaymentInfo] tt (nolock) ON (t.TransferId=TT.TransferId)"
+ " join [Production].[InstitutionRoleXref] i (nolock) on (t.InstitutionRoleXrefTransmitterId=i.InstitutionRoleXrefId)"
+ " WHERE"
+ " t.DateOfTransfer >= '20140101' AND t.InstitutionRoleXrefTransmitterId=38"
+ " GROUP BY t.DateOfTransfer, i.InstitutionRoleXrefName"
+ " INSERT INTO #temp"
+ " SELECT"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 1 then Count(t.TransferId) end as ENERO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 2 then Count(t.TransferId) end as FEBRERO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 3 then Count(t.TransferId) end as MARZO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 4 then Count(t.TransferId) end as ABRIL,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 5 then Count(t.TransferId) end as MAYO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 6 then Count(t.TransferId) end as JUNIO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 7 then Count(t.TransferId) end as JULIO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 8 then Count(t.TransferId) end as AGOSTO,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 9 then Count(t.TransferId) end as SEPTIEMBRE,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 10 then Count(t.TransferId) end as OCTUBRE,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 11 then Count(t.TransferId) end as NOVIEMBRE,"
+ " CASE WHEN MONTH(t.DateOfTransfer)= 12 then Count(t.TransferId) end as DICIEMBRE,"
+ " YEAR(t.DateOfTransfer) as año,"
+ " i.InstitutionRoleXrefName as Name"
+ " FROM [Production].[TransferClosed] t (nolock)"
+ " JOIN [Production].[TransferPaymentInfoClosed] tt (nolock) ON (t.TransferId=TT.TransferId)"
+ " join [Production].[InstitutionRoleXref] i (nolock) on (t.InstitutionRoleXrefTransmitterId=i.InstitutionRoleXrefId)"
+ " WHERE"
+ " t.DateOfTransfer >= '20140101' AND t.InstitutionRoleXrefTransmitterId=38"
+ " GROUP BY t.DateOfTransfer,i.InstitutionRoleXrefName"
+ " Select"
+ " año,"
+ " Name,"
+ " SUM(ISNULL(ENERO,0)) AS [ENERO],"
+ " SUM(ISNULL(FEBRERO,0)) AS [FEBRERO],"
+ " SUM(ISNULL(MARZO,0)) AS [MARZO],"
+ " SUM(ISNULL(ABRIL,0)) AS [ABRIL],"
+ " SUM(ISNULL(MAYO,0)) AS [MAYO],"
+ " SUM(ISNULL(JUNIO,0)) AS [JUNIO],"
+ " SUM(ISNULL(JULIO,0)) AS [JULIO],"
+ " SUM(ISNULL(AGOSTO,0)) AS [AGOSTO],"
+ " SUM(ISNULL(SEPTIEMBRE,0)) AS [SEPTIEMBRE],"
+ " SUM(ISNULL(OCTUBRE,0)) AS [OCTUBRE],"
+ " SUM(ISNULL(NOVIEMBRE,0)) AS [NOVIEMBRE],"
+ " SUM(ISNULL(DICIEMBRE,0)) AS [DICIEMBRE]"
+ " FROM #temp"
+ " GROUP BY año, Name"
+ " ORDER BY año, Name"


+ " DROP TABLE #temp";
        return conecction;



    }
}