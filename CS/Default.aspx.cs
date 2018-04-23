using DevExpress.Web.ASPxEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void ASPxComboBox1_Init(object sender, EventArgs e)
    {
        ASPxComboBox cmb = sender as ASPxComboBox;
        SqlDataSource sqlDs = FindControl(ASPxComboBox1.DataSourceID) as SqlDataSource;
        if (sqlDs == null) return;

        DataView dv = (DataView)sqlDs.Select(DataSourceSelectArguments.Empty);
        
        foreach (DataColumn dc in dv.Table.Columns)
        {
            cmb.Columns.Add(dc.ColumnName, SplitPascalCaseString(dc.ColumnName));
        }
    }

    private String SplitPascalCaseString(String value)
    {
        value = Regex.Replace(value, "(\\p{Ll})(\\p{Lu})", "$1 $2");
        value = Regex.Replace(value, "(\\p{Lu}{2})(\\p{Lu}\\p{Ll}{2})", "$1 $2");
        return value;
    }
}