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
        public string path = null;
        public string name = "";
        public string studentID = "";
        public string bookName = "";
        public string BookID;
        public string returnDate;
        protected void Page_Load(object sender, EventArgs e)
        {
            path = Server.MapPath("~/checkoutDetails.txt");
            name = txtName.Text;
            studentID = txtStudentID.Text;
            bookName = drpBookName.SelectedItem.ToString();
            BookID = drpBookID.SelectedItem.ToString();
            returnDate = TxtReturnDate.Text;
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            string line = Environment.NewLine + "-----------------------------------------------------------" + Environment.NewLine;
            string details = "Name :" + txtName.Text + Environment.NewLine
                + "Student ID: " + txtStudentID.Text + Environment.NewLine
                + "BookName : " + drpBookName.SelectedItem + Environment.NewLine
                + "Book ID:" + drpBookID.SelectedItem + Environment.NewLine
                + "Return Date:" + TxtReturnDate.Text.ToString() + Environment.NewLine;
            string content = line + details.Trim() + line;
            validation checkoutObj = new validation();
            checkoutObj.writeData(content, path);
            
            confirmLabel.Visible = true;
            confirmLabel.Text = "Book check-out noted";
        }
    }
}