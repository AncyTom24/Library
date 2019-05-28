using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class About : Page
    {
        public string path = null;
        public string name = "";
        public string studentID = "";
        public string email = "";
        public string phone;
        public string address;

        protected void Page_Load(object sender, EventArgs e)
        {
            path = Server.MapPath("~/membDetails.txt");
            name = txtName.Text;
            studentID = txtStudentID.Text;
            email = txtemail.Text;
            phone = txtPhone.Text;
            address = txtAddress.Text;
        }

        protected void btnNewMemb_Click(object sender, EventArgs e)
        {
            string line = Environment.NewLine + "-----------------------------------------------------------" + Environment.NewLine;
            string details = "Name :" + txtName.Text + Environment.NewLine
                + "Student ID: " + txtStudentID.Text + Environment.NewLine
                + "Phone: " + txtPhone.Text + Environment.NewLine
                + "Address:" + txtAddress.Text + Environment.NewLine
                + "Email:" + txtemail.Text + Environment.NewLine;
            string content = line + details.Trim() + line;
            validation addMembObj = new validation();
            addMembObj.writeData(content, path);
            //using (StreamWriter writer = new StreamWriter(path, true)) //// true to append data to the file
            //{
            //    writer.WriteLine(line + details.Trim() + line);
            //}
            //File.WriteAllText(path, details.Trim());
            confirmLabel.Visible = true;
            confirmLabel.Text = "Member Added";
        }

       
    }
}