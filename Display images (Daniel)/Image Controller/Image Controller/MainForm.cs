using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Controller
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Just a reference variable to the Controller class
        /// </summary>
        private Controller controller;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new Controller class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            controller = new Controller(table, imageCount);
            table.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// Searches through all of the pictures after a specific date 
        /// and only the pictures that matches that exact date gets added to a list
        /// Then we display this list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateButton_Click(object sender, EventArgs e)
        {
            String date = datePicker.Text;
            controller.SearchAfterDate(date);
            controller.UpdateTable();
        }

        /// <summary>
        /// Searches through all of the pictures after a specific date
        /// Thereafter we take the ones that matched the date
        /// and if they DONT match the time too we remove
        /// them from the list that we will display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimeButton_Click(object sender, EventArgs e)
        {
            String date = timeDatePicker.Text;
            String time = timePicker.Text;
            controller.SearchAfterDateAndTime(date, time);
            controller.UpdateTable();
        }

        /// <summary>
        /// Searches through all of the pictures after a specific date
        /// Then we take the ones that matched the date
        /// and if they DONT match the time too we remove
        /// them from the list that we will display
        /// Last we do the same process all over but now with
        /// seconds instead and remove objects from the list
        /// that DONT match our second
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimeSecButton_Click(object sender, EventArgs e)
        {
            String date = secDatePicker.Text;
            String time = secTimePicker.Text;
            String sec = secPicker.Text;
            controller.SearchAfterDateTimeAndSec(date, time, sec);
            controller.UpdateTable();
        }

        /// <summary>
        /// Resets the table and shows all the pictures again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restButton_Click(object sender, EventArgs e)
        {
            controller.ResetTable();
        }

        /// <summary>
        /// Calls upon a method that let's the user pick a folder
        /// from where the images shall be loaded from
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFolder_Click(object sender, EventArgs e)
        {
            controller.SelectFolder();
        }

        /// <summary>
        /// Everyting down is to make it more user friendly
        /// This is done so that if you select the date of any calender that date
        /// will be set in the other two calanders too
        /// The same thing with setting the time
        /// </summary>
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            SetDate(datePicker.Text);
        }

        private void timeDatePicker_ValueChanged(object sender, EventArgs e)
        {
            SetDate(timeDatePicker.Text);
        }

        private void secDatePicker_ValueChanged(object sender, EventArgs e)
        {
            SetDate(secDatePicker.Text);
        }

        private void SetDate(String date)
        {
            datePicker.Text = date;
            timeDatePicker.Text = date;
            secDatePicker.Text = date;
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            SetTime(timePicker.Text);
        }

        private void secTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SetTime(secTimePicker.Text);
        }

        private void SetTime(String time)
        {
            timePicker.Text = time;
            secTimePicker.Text = time;
        }
    }
}
