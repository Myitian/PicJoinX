using System.Diagnostics;
using System.Drawing.Imaging;

namespace PicJoinX
{
    public partial class MainForm : Form
    {
        private readonly OpenFileDialog OFD = new()
        {
            Filter = "PNG图片|*.png|BMP图片|*.bmp|JPEG图片|*.jpg,*.jpeg|TIFF图片|*.tif,*.tiff|GIF图片|*.gif|任意文件|*.*",
        };
        private readonly SaveFileDialog SFD = new()
        {
            Filter = "PNG图片|*.png|BMP图片|*.bmp|JPEG图片|*.jpg,*.jpeg|TIFF图片|*.tif,*.tiff|GIF图片|*.gif",
            AddExtension = true,
            DefaultExt = "png"
        };

        private const int defaultPicX = 512, defaultPicY = 512;
        private readonly ImageList imageList = new();
        private readonly List<Image> picList = new();

        private void Success(string msg = "")
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
        private Size? GetPicSize()
        {
            try
            {
                Size size = new(Convert.ToInt32(NUD_SizeX.Value), Convert.ToInt32(NUD_SizeY.Value));
                Success();
                return size;
            }
            catch (Exception ex)
            {
                Error(ex.Message + Environment.NewLine + ex.StackTrace);
                return null;
            }
        }

        private Image? GenerateImage()
        {
            Size? size = GetPicSize();
            if (size.HasValue)
            {
                pictureBox1.Size = size.Value;
                Image? imageResult = JoinImage(picList, size.Value.Width, size.Value.Height);
                pictureBox1.Image = imageResult;
                Success();
                return imageResult;
            }
            return null;
        }


        private Image? JoinImage(List<Image> imageList, int maxX, int maxY)
        {
            //图片列表
            if (imageList.Count <= 0)
                return null;
            //构造最终的图片白板
            Bitmap tableChartImage = new(maxX, maxY, PixelFormat.Format32bppArgb);
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
                    if (currentWidth + i.Width > maxX)
                    {
                        currentWidth = 0;
                        currentHeight += maxHeightLine;
                        maxHeightLine = 0;
                    }
                    if (currentHeight + i.Height > maxY)
                    {
                        break;
                    }

                    //拼图
                    graph.DrawImage(i, currentWidth, currentHeight, i.Width, i.Height);
                    if (maxHeightLine < i.Height)
                    {
                        maxHeightLine = i.Height;
                    }
                    //拼接改图后，当前宽度
                    currentWidth += i.Width;
                }
                Success();
            }
            catch (Exception ex)
            {
                Error(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return tableChartImage;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NUD_SizeX.Value = defaultPicX;
            NUD_SizeY.Value = defaultPicY;
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            string picNames = string.Empty;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                LISTVIEW_SrcPicList.LargeImageList = imageList;
                foreach (string fileName in OFD.FileNames)
                {
                    picNames += fileName + Environment.NewLine;
                    Image image = Image.FromFile(fileName);
                    Size imgSize = image.Size;
                    imageList.ImageSize = new Size(64, 64);
                    imageList.Images.Add(image);
                    picList.Add(image);
                    ListViewItem lvi = new(Path.GetFileName(fileName))
                    {
                        ImageIndex = imageList.Images.Count - 1
                    };
                    LISTVIEW_SrcPicList.Items.Add(lvi);
                }
            }
        }

        private void BTN_Clr_Click(object sender, EventArgs e)
        {
            imageList.Images.Clear();
            LISTVIEW_SrcPicList.Items.Clear();
            picList.Clear();
            Success();
        }

        private void BTN_Preview_Click(object sender, EventArgs e)
        {
            GenerateImage();
        }

        private void LINKLABEL_Inf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sender is LinkLabel ll)
                Process.Start(new ProcessStartInfo(ll.Text) { UseShellExecute = true });
        }

        private void TEXTBOX_SizeX_Leave(object sender, EventArgs e)
        {
            GetPicSize();
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            Image? imageResult = GenerateImage();
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imageFormat = SFD.FilterIndex switch
                {
                    1 => ImageFormat.Bmp,
                    2 => ImageFormat.Jpeg,
                    3 => ImageFormat.Tiff,
                    4 => ImageFormat.Gif,
                    _ => ImageFormat.Png,
                };
                imageResult?.Save(SFD.FileName, imageFormat);
                Success($"保存成功！保存至{SFD.FileName}");
            }
        }

    }
}

