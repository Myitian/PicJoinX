using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PicJoin
{
    public partial class Form1 : Form
    {
        int pic_sizeX, pic_sizeY;
        ImageList imageList;
        Image imageResult = null;
        List<Image> picList = new List<Image>();

        /// <summary>
        /// 获取画布大小
        /// </summary>
        private void GetPicSize()
        {
            try
            {
                pic_sizeX = Convert.ToInt16(textBox_sizeX.Text);
                pic_sizeY = Convert.ToInt16(textBox_sizeY.Text);
            }
            catch (System.Exception ex)
            {
                textBox_sizeX.Text = pic_sizeX.ToString();
                textBox_sizeY.Text = pic_sizeY.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
            pic_sizeX = 512;
            pic_sizeY = 512;
            imageList = new ImageList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_sizeX.Text = "512";
            textBox_sizeY.Text = "512";


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "图片文件(*.bmp,*.jpg,*.png,*.gif）|*.bmp;*.jpg;*.png;*.gif|所有文件(*.*)|*.*";
            openFileDialog1.Title = "选择图片";
            openFileDialog1.Multiselect = true;
            string picNames = string.Empty;
            //imageList.ImageSize = new Size(64, 64);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listView1.LargeImageList = imageList;
                foreach (string fileName in openFileDialog1.FileNames)
                {
                    picNames += fileName + Environment.NewLine;
                    Image image = Image.FromFile(fileName);
                    Size isize = image.Size;
                    imageList.ImageSize = new Size(64,64);
                    imageList.Images.Add(image);
                    picList.Add(image);
                    ListViewItem myitem = new ListViewItem(Path.GetFileName(fileName));
                    myitem.ImageIndex = imageList.Images.Count - 1;
                    listView1.Items.Add(myitem);



                }

                // MessageBox.Show(picNames);
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            imageList.Images.Clear();
            listView1.Items.Clear();
            picList.Clear();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            GetPicSize();
            //pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Size = new Size(pic_sizeX, pic_sizeY);
            imageResult = JoinImage(picList, pic_sizeX, pic_sizeY);
            pictureBox1.Image = imageResult;

        }


        private Image JoinImage(List<Image> imageList, int maxX, int maxY)
        {
            //图片列表
            if (imageList.Count <= 0)
                return null;
            //构造最终的图片白板
            Bitmap tableChartImage = new Bitmap(maxX, maxY);
            Graphics graph = Graphics.FromImage(tableChartImage);
            //初始化这个大图
            graph.DrawImage(tableChartImage, 0, 0);
            //初始化当前宽
            int currentWidth = 0;
            int currentHeight = 0;
            int maxHeightLine = 0;//一行中最大高度
            foreach (Image i in imageList)
            {
                if (maxHeightLine < i.Height)
                {
                    maxHeightLine = i.Height;
                }
                if (currentWidth + i.Width > maxX)
                {
                    currentWidth = 0;
                    currentHeight += maxHeightLine;
                    if (currentHeight >= maxY)
                    {
                        break;
                    }
                }
                if (currentHeight + maxHeightLine >= maxY)
                {
                    break;
                }

                //拼图
                graph.DrawImage(i, currentWidth, currentHeight);
                //拼接改图后，当前宽度
                currentWidth += i.Width;

            }
            return tableChartImage;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            btn_preview_Click(sender, e);
            saveFileDialog1.Filter = "PNG图片(*.png)|*.png";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageResult.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

    }
}

