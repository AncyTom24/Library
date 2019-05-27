using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class Checkout : System.Web.UI.Page
    {
        private string path = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            path = Server.MapPath("~/checkoutDetails.txt");
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            string line = Environment.NewLine + "-----------------------------------------------------------" + Environment.NewLine;
            string details = "Name :" + txtName.Text + Environment.NewLine
                + "Student ID: " + txtStudentID.Text + Environment.NewLine
                + "BookName : " + drpBookName.SelectedItem + Environment.NewLine
                + "Book ID:" + drpBookID.SelectedItem + Environment.NewLine
                + "Return Date:" + TxtReturnDate.Text.ToString() + Environment.NewLine;

            using (StreamWriter writer = new StreamWriter(path, true)) //// true to append data to the file
            {
                writer.WriteLine(line + details.Trim() + line);
            }
            //File.WriteAllText(path, details.Trim());
            confirmLabel.Visible = true;
            confirmLabel.Text = "Book check-out noted";
        }
    }
}