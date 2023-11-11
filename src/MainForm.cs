using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace PicJoin
{
    public partial class MainForm : Form
    {
        int pic_sizeX = 512, pic_sizeY = 512;
        ImageList imageList = new ImageList();
        Image imageResult = null;
        List<Image> picList = new List<Image>();

        private void Success(string msg)
        {
            LABEL_Msg.ForeColor = Color.Green;
            LABEL_Msg.Text = msg;
        }
        private void Error(string msg)
        {
            LABEL_Msg.ForeColor = Color.Red;
            LABEL_Msg.Text = msg;
        }

        /// <summary>
        /// 获取画布大小
        /// </summary>
        private void GetPicSize()
        {
            try
            {
                pic_sizeX = Convert.ToInt32(TEXTBOX_SizeX.Text);
                pic_sizeY = Convert.ToInt32(TEXTBOX_SizeY.Text);
                Success("");
            }
            catch (Exception ex)
            {
                Error(ex.Message + Environment.NewLine + ex.StackTrace);
                TEXTBOX_SizeX.Text = pic_sizeX.ToString();
                TEXTBOX_SizeY.Text = pic_sizeY.ToString();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            TEXTBOX_SizeX.Text = pic_sizeX.ToString();
            TEXTBOX_SizeY.Text = pic_sizeY.ToString();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            string picNames = string.Empty;
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LISTVIEW_SrcPicList.LargeImageList = imageList;
                foreach (string fileName in OpenFileDialog1.FileNames)
                {
                    picNames += fileName + Environment.NewLine;
                    Image image = Image.FromFile(fileName);
                    Size isize = image.Size;
                    imageList.ImageSize = new Size(64, 64);
                    imageList.Images.Add(image);
                    picList.Add(image);
                    ListViewItem myitem = new ListViewItem(Path.GetFileName(fileName))
                    {
                        ImageIndex = imageList.Images.Count - 1
                    };
                    LISTVIEW_SrcPicList.Items.Add(myitem);
                }
            }
        }

        private void BTN_Clr_Click(object sender, EventArgs e)
        {
            imageList.Images.Clear();
            LISTVIEW_SrcPicList.Items.Clear();
            picList.Clear();
            Success("");
        }

        private void BTN_Preview_Click(object sender, EventArgs e)
        {
            GetPicSize();
            pictureBox1.Size = new Size(pic_sizeX, pic_sizeY);
            imageResult = JoinImage(picList, pic_sizeX, pic_sizeY);
            pictureBox1.Image = imageResult;
            Success("");
        }


        private Image JoinImage(List<Image> imageList, int maxX, int maxY, bool closest=false)
        {
            //图片列表
            if (imageList.Count <= 0)
                return null;
            //构造最终的图片白板
            Bitmap tableChartImage = new Bitmap(maxX, maxY);
            try
            {
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
                        if (currentHeight > maxY)
                        {
                            break;
                        }
                    }
                    if (currentHeight + maxHeightLine > maxY)
                    {
                        break;
                    }

                    //拼图
                    graph.DrawImage(i, currentWidth, currentHeight);
                    //拼接改图后，当前宽度
                    currentWidth += i.Width;
                }
                Success("");
            }
            catch (Exception ex)
            {
                Error(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return tableChartImage;
        }

        private void LINKLABEL_Inf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start((sender as LinkLabel).Text);
        }

        private void TEXTBOX_SizeX_Leave(object sender, EventArgs e)
        {
            GetPicSize();
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            BTN_Preview_Click(sender, e);
            SaveFileDialog1.Filter = "PNG图片(*.png)|*.png";
            SaveFileDialog1.AddExtension = true;
            SaveFileDialog1.DefaultExt = "png";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageResult.Save(SaveFileDialog1.FileName, ImageFormat.Png);
            }
            Success($"保存成功！保存至{SaveFileDialog1.FileName}");
        }

    }
}

