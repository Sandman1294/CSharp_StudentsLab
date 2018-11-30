/*
 * File Name: Lab3
 * Author: Christopher Leipfert
 * Purpose: Take input from a student about his/her schooling Then outputting it to a file
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void ResidentFunction(object sender, EventArgs e)
        {
            //Pre: Click Off Campus button
            //Post: Shows input screen
            //Purpose: Shows the input screen so a student can input their information

            grpInfo.Visible = true;                 //Displaying the Info box
            grpStudents.Visible = false;            //Hiding the selection box
            grpSubmit.Visible = true;               //Displaying the submit box
            btnSubmitRes.Visible = true;            //Displaying the Resident Submit Button
            lblAddress.Text = "Please Enter Your Room Number:";
            lblDaysOnCampus.Text = "Credits This Semester:";
            ;
        }
        private void OffCampusFunction(object sender, EventArgs e)
        {
            //Pre: Click Off Campus button
            //Post: Shows input screen
            //Purpose: Shows the input screen so a student can input their information

            grpInfo.Visible = true;                 //Displaying the Info box
            grpStudents.Visible = false;            //Hiding the selection box
            grpSubmit.Visible = true;               //Displaying the submit box
            btnSubmitOff.Visible = true;            //Displaying the Off Campus Submit Button
            lblAddress.Text = "Please Enter Your Address:";
            lblDaysOnCampus.Text = "Days/Week on Campus:";
        }
        private void SubmitRes(object sender, EventArgs e)
        {
            //Pre: Click Submit Button For Residential
            //Post: Submits Data
            //Purpose: Takes in entered Data and submits it to an external data file

            ResidentStruct resStu;

            bool roomNumGood = true;

            resStu.name = txtName.Text;                                 //taking input for name
            resStu.roomNumber = Convert.ToInt32(txtAddress.Text);       //Taking input for room num
            if(resStu.roomNumber > 500 || resStu.roomNumber <100)
            {       //Testing for a good room number
                roomNumGood = false;
                txtAddress.Text = "Please Enter a room number between 100 and 500";
            }
            resStu.major = txtMajor.Text;                               //Taking input for major
            resStu.credits = Convert.ToInt32(txtDaysOnCampus.Text);     //Taking input for credits

            if(roomNumGood)
            {
                using (var dout = new StreamWriter("ResidentStudent.txt", true))
                {   //Outputting Student Information to a text file
                    dout.WriteLine("Student Name: {0}", resStu.name);
                    dout.WriteLine("Residence Hall Room #: {0}", resStu.roomNumber);
                    dout.WriteLine("Major: {0}", resStu.major);
                    dout.WriteLine("Credits This Semester: {0}", resStu.credits);
                    dout.WriteLine("");
                }
                //Clears Text Boxes in event of successfull submission
                txtAddress.Text = "";
                txtDaysOnCampus.Text = "";
                txtMajor.Text = "";
                txtName.Text = "";
            }
         }

        private void OffSubmit(object sender, EventArgs e)
        {
            //Pre: Click Submit Button For Off Campus
            //Post: Submits Data
            //Purpose: Takes in entered Data and submits it to an external data file
           OffCampusStruct offStu;

            bool dayNumGood = true;

            offStu.name = txtName.Text;                                     //Taking input for the name
            offStu.address =txtAddress.Text;                                //Taking input for address
            offStu.major = txtMajor.Text;                                   //Taking input for major
            offStu.daysPerWeek = Convert.ToInt32(txtDaysOnCampus.Text);     //Taking input for days per week on campus
            if(offStu.daysPerWeek < 1 || offStu.daysPerWeek > 7)
            {   //Testing for good days
                dayNumGood = false;
                txtDaysOnCampus.Text = "Invalid Day Number. Enter a number between 1 and 7";
            }
           
            if (dayNumGood)
            {
                using (var dout = new StreamWriter("OffCampusStudent.txt", true))
                {   //Outputting Student Information to a text file
                    dout.WriteLine("Student Name: {0}", offStu.name);
                    dout.WriteLine("Address: {0}", offStu.address);
                    dout.WriteLine("Major: {0}", offStu.major);
                    dout.WriteLine("Days Per Week On Campus: {0}", offStu.daysPerWeek);
                    dout.WriteLine("");
                }
                //Clears Text Boxes in event of successfull submission
                txtAddress.Text = "";
                txtDaysOnCampus.Text = "";
                txtMajor.Text = "";
                txtName.Text = "";
            }
        }       
        
        
        private void ResetFunction(object sender, EventArgs e)
        {
            //Pre: Click Reset Button
            //Post: Resets to default screen
            //Purpose: Resets the Form
            grpInfo.Visible = false;
            grpSubmit.Visible = false;
            grpStudents.Visible = true;
            btnSubmitOff.Visible = false;
            btnSubmitRes.Visible = false;   
            txtAddress.Text = "";
            txtDaysOnCampus.Text = "";
            txtMajor.Text = "";
            txtName.Text = "";
        }
        private void ExitFunction(object sender, EventArgs e)
        {
            //Pre: Click Exit Button
            //Purpose: Exits Form
            this.Close();
        }



        

        
    }
}
