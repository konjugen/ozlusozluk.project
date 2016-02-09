using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace OzluSozlukAPI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonInsert_OnClick(object sender, EventArgs e)
        {
            insert();
        }

        public void insert()
        {
            if (FileUpload1.PostedFile.FileName != "")
            {
                byte[] image;
                Stream s = FileUpload1.PostedFile.InputStream;
                var br = new BinaryReader(s);
                image = br.ReadBytes((Int32) s.Length);

                var sqlconn =
                    new SqlConnection(
                        "data source=beramus.database.windows.net;initial catalog=ContentDB;persist security info=True;user id=aagurbuz;password=159357258aA;MultipleActiveResultSets=True;App=EntityFramework&quot;");
                var sqlcomm = new SqlCommand { CommandText = "select * from WriterTemplate" };

                sqlcomm.Parameters.AddWithValue("@image", image);

                sqlconn.Open();
                //int row = sqlcomm.ExecuteNonQuery();
                sqlconn.Close();

                //if (row>0)
                //{
                //    LabelError.Text = "Success";
                //}

            }
            else
            {
                LabelError.Text = "lütfen image upload edin";

            }
        }
    }
}