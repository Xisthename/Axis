using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Controller
{
    class Controller
    {
        /// <summary>
        /// Instance variables
        /// </summary>
        private List<Picture> pictureList = new List<Picture>();
        private List<Picture> tableList = new List<Picture>();
        private DataGridView table;
        private Label imageCount;
        private String path = @"\Users\xisth\Desktop\Skola\Inbyggda system och signaler\Examinationsprojekt\Axis\Images\";
        //private String path = @"C:\Users\Michael\Desktop\Axis\image\";

        /// <summary>
        /// Constructor that takes in an argument and sets the instance variable to that paramter value
        /// Calls upon the method ReadInImages which will read in images and add them to pictureList
        /// Calls upon the method InitialTable which will add all images from pictureList to the table
        /// </summary>
        /// <param name="table"></param>
        /// <param name="imageCount"></param>
        public Controller(DataGridView table, Label imageCount)
        {
            this.table = table;
            this.imageCount = imageCount;
            ReadInImages();
            InitialTable();
        }

        /// <summary>
        /// Tries to read in all images from a specific folder
        /// If the folder can't be find the user are requested to pick a new folder
        /// If the folder is empty the user will get a warning about it
        /// If the folder contains images we try to create a Picture object for every image
        /// Last we add the picture objects to a list called pictureList
        /// </summary>
        private void ReadInImages()
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(path);
                FileInfo[] files = d.GetFiles();
                Image image;

                if (files.Length > 0)
                {
                    foreach (FileInfo file in files)
                    {
                        try
                        {
                            string name = file.Name.Substring(0, file.Name.Length - 4);
                            String date = name.Substring(0, 10);
                            String time = name.Substring(11, 5);
                            time = time.Replace("-", ":");
                            String second = name.Substring(name.Length - 2, 2);

                            using (FileStream stream = new FileStream(path + file.Name, FileMode.Open, FileAccess.Read))
                            {
                                image = Image.FromStream(stream);
                            }
                            image = Picture.ResizeImage(image, 250, 250);

                            Picture pic = new Picture(date, time, second, image);
                            pictureList.Add(pic);
                        }
                        catch (Exception ex) { }
                    }

                    if (pictureList.Count == 0)
                    {
                        MessageBox.Show("No images found in " + path, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Please select a new folder!", "Folder not found!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SelectFolder();
            }
            imageCount.Text = "(" + pictureList.Count + ")";
        }

        /// <summary>
        /// Lets the user select a new folder to read in images from
        /// When the images has been loaded we display them
        /// </summary>
        public void SelectFolder()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    for (int i = 0; i < pictureList.Count; i++)
                    {
                        pictureList[i].ClearImage();
                    }
                    pictureList.Clear();
                    path = fbd.SelectedPath + @"\";
                    ReadInImages();
                    ResetTable();
                }
            }
        }

        /// <summary>
        /// Takes alla pictures and adds them to the table
        /// </summary>
        private void InitialTable()
        {
            for (int i = 0; i < pictureList.Count; i++)
            {
                addTableRow(pictureList[i]);
            }
            imageCount.Text = "(" + pictureList.Count + ")";
        }

        /// <summary>
        /// Takes in a picture and adds it to the table
        /// </summary>
        /// <param name="pic">The picture that will be put into the table</param>
        private void addTableRow(Picture pic)
        {
            table.Rows.Add(pic.GetDate(), pic.GetTime(), pic.GetSecond(), pic.GetImage());
        }

        /// <summary>
        /// Clears all objects from tableList
        /// </summary>
        private void ClearTableList()
        {
            tableList.Clear();
        }

        /// <summary>
        /// First we clear the tableList
        /// When that's we look through the date of every Picture object inside the list pictureList
        /// If the date that we are looking for matches any object we add them to the tableList
        /// </summary>
        /// <param name="date">The date we are looking for</param>
        public void SearchAfterDate(String date)
        {
            ClearTableList();

            for (int i = 0; i < pictureList.Count; i++)
            {
                if (date.Equals(pictureList[i].GetDate()))
                {
                    tableList.Add(pictureList[i]);
                }
            }
        }

        /// <summary>
        /// Calls upon the method SearchAfterDate which will do the first part of the job
        /// The second part is about looking through the matches from the first search method (SearchAfterDate)
        /// Looks through all objects in tableList and if we DONT have a match we remove that index!
        /// 
        /// We only need to increment variable i when we have a match because when we remove an index from
        /// tableList the size will decrement by one and all index will also decrement by one
        /// </summary>
        /// <param name="date">The date we are looking for</param>
        /// <param name="time">The time we are looking for</param>
        public void SearchAfterDateAndTime(String date, String time)
        {
            SearchAfterDate(date);

            for (int i = 0; i < tableList.Count;)
            {
                if (!time.Equals(tableList[i].GetTime()))
                {
                    tableList.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        /// <summary>
        /// Calls upon the method SearchAfterDateAndTime which will do 2/3 part of the job
        /// The third part is pretty much the same as the second part in SearchAfterDateAndTime
        /// </summary>
        /// <param name="date">The date we are looking for</param>
        /// <param name="time">The time we are looking for</param>
        /// <param name="sec">The second we are looking for</param>
        public void SearchAfterDateTimeAndSec(String date, String time, String sec)
        {
            SearchAfterDateAndTime(date, time);

            for (int i = 0; i < tableList.Count;)
            {
                if (!sec.Equals(tableList[i].GetSecond()))
                {
                    tableList.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        /// <summary>
        /// Clears the table
        /// </summary>
        private void ClearTable()
        {
            table.Rows.Clear();
        }

        /// <summary>
        /// Clears the table and adds only the pictures from tableList to the table
        /// </summary>
        public void UpdateTable()
        {
            ClearTable();

            for (int i = 0; i < tableList.Count; i++)
            {
                addTableRow(tableList[i]);
            }
            imageCount.Text = "(" + tableList.Count + ")";
        }

        /// <summary>
        /// Clears the table and adds all pictures to the table
        /// </summary>
        public void ResetTable()
        {
            ClearTable();
            InitialTable();
        }
    }
}
