using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Configuration;

namespace CRUDtutorial
{
    public partial class webform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        SqlConnection con = new SqlConnection("Data Source=192.168.0.109;Initial Catalog=pawan;Integrated Security=True");

        protected void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[Student1]
            ([StudentID]
           ,[StudentName]
           ,[Address]
           ,[Age]
           ,[Contact])
        VALUES
           ('" + txtstudentid.Text + "','" + txtstudentname.Text + "','" + txtaddress.Text + "','" + txtage.Text + "','" + txtcontact.Text + "')", con);
            cmd.ExecuteNonQuery();
            Response.Write("data inserted successfully");
            con.Close();
        }        
        protected void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Student1]
        SET[StudentID] = '" + txtstudentid.Text + "',[StudentName] = '" + txtstudentname.Text + "',[Address]='" + txtaddress.Text + "',[Age]='" + txtage.Text + "',[Contact]='" + txtcontact.Text + "'Where [StudentID]= '" + txtstudentid.Text + "'", con);
            cmd.ExecuteNonQuery();
            Response.Write("data updated successfully");
            con.Close();
        }
        protected void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[Student1]
        WHERE [StudentID]= '" + txtstudentid.Text + "'", con);
            cmd.ExecuteNonQuery();
            Response.Write("data deleted successfully");
            con.Close();  
        }
        protected void btnsearchh_Click(object sender, EventArgs e)
        {

        }

        
    }
}