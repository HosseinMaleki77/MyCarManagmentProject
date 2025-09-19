using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCarManagmentProject.Forms
{
    public partial class AddNewCar : Form
    {
        public AddNewCar()
        {
            InitializeComponent();
            picBoxNewCar.AllowDrop = true;
            picBoxNewCar.DragEnter += picBoxNewCar_DragEnter;
            picBoxNewCar.DragDrop += picBoxNewCar_DragDrop;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void AddNewCar_Load(object sender, EventArgs e)
        {
    
        }

        private void picBoxNewCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string ext = System.IO.Path.GetExtension(files[0]).ToLower();
                    if (ext == ".png")
                    {
                        e.Effect = DragDropEffects.Copy; // فقط اگه عکس بود
                        return;
                    }
                }
            }
            e.Effect = DragDropEffects.None; // در غیر این صورت اجازه نده
        }


        private void picBoxNewCar_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files != null && files.Length > 0)
            {
                string ext = System.IO.Path.GetExtension(files[0]).ToLower();
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif")
                {
                    // عکس قبلی رو آزاد کن
                    if (picBoxNewCar.Image != null)
                        picBoxNewCar.Image.Dispose();

                    // عکس جدید رو لود کن
                    picBoxNewCar.Image = Image.FromFile(files[0]);
                }
                else
                {
                    MessageBox.Show("فقط فایل عکس مجاز است (jpg, png, bmp, gif)");
                }
            }
        }
    }
}
