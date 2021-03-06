﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class Checkin : System.Web.UI.Page
    {
        public string path = null;
        public string name = "";
        public string studentID = "";
        public string bookName = "";
        public string BookID;
        public string takenDate;
        protected void Page_Load(object sender, EventArgs e)
        {
            path = Server.MapPath("~/checkinDetails.txt");
            name = txtName.Text;
            studentID = txtStudentID.Text;
            bookName = drpBookName.SelectedItem.ToString();
            BookID = drpBookID.SelectedItem.ToString();
            takenDate = txtTakenDate.Text;
        }

        protected void BtnCheckin_Click(object sender, EventArgs e)
        {
            string line = Environment.NewLine + "-----------------------------------------------------------" + Environment.NewLine;
            string details = "Name :" + txtName.Text + Environment.NewLine
                + "Student ID: " + txtStudentID.Text + Environment.NewLine
                + "BookName : " + drpBookName.SelectedItem + Environment.NewLine
                + "Book ID:" + drpBookName.SelectedItem + Environment.NewLine
                + "Taken Date:" + txtTakenDate.Text.ToString() + Environment.NewLine;

            string content = line + details.Trim() + line;
            validation checkinObj = new validation();
            checkinObj.writeData(content, path);
            //using (StreamWriter writer = new StreamWriter(path, true)) //// true to append data to the file
            //{
            //    writer.WriteLine(line + details.Trim() + line);
            //}
            //File.WriteAllText(path, details.Trim());
            confirmLabel.Visible = true;
            confirmLabel.Text = "Book check-in noted";
        }
    }
}