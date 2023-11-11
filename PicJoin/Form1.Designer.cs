namespace PicJoin
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.GROUPBOX_Setting = new System.Windows.Forms.GroupBox();
            this.LABEL_Msg = new System.Windows.Forms.Label();
            this.LINKLABEL_Inf = new System.Windows.Forms.LinkLabel();
            this.LABEL_Inf = new System.Windows.Forms.Label();
            this.BTN_Preview = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.TEXTBOX_SizeY = new System.Windows.Forms.TextBox();
            this.LABEL_X = new System.Windows.Forms.Label();
            this.LABEL_Size = new System.Windows.Forms.Label();
            this.TEXTBOX_SizeX = new System.Windows.Forms.TextBox();
            this.GROUPBOX_SrcPic = new System.Windows.Forms.GroupBox();
            this.BTN_Clr = new System.Windows.Forms.Button();
            this.BTN_Del = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.LISTVIEW_SrcPicList = new System.Windows.Forms.ListView();
            this.GROUPBOX_Preview = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.GROUPBOX_Setting.SuspendLayout();
            this.GROUPBOX_SrcPic.SuspendLayout();
            this.GROUPBOX_Preview.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GROUPBOX_Setting
            // 
            this.GROUPBOX_Setting.Controls.Add(this.LABEL_Msg);
            this.GROUPBOX_Setting.Controls.Add(this.LINKLABEL_Inf);
            this.GROUPBOX_Setting.Controls.Add(this.LABEL_Inf);
            this.GROUPBOX_Setting.Controls.Add(this.BTN_Preview);
            this.GROUPBOX_Setting.Controls.Add(this.BTN_Save);
            this.GROUPBOX_Setting.Controls.Add(this.TEXTBOX_SizeY);
            this.GROUPBOX_Setting.Controls.Add(this.LABEL_X);
            this.GROUPBOX_Setting.Controls.Add(this.LABEL_Size);
            this.GROUPBOX_Setting.Controls.Add(this.TEXTBOX_SizeX);
            this.GROUPBOX_Setting.Dock = System.Windows.Forms.DockStyle.Right;
            this.GROUPBOX_Setting.Location = new System.Drawing.Point(721, 0);
            this.GROUPBOX_Setting.Name = "GROUPBOX_Setting";
            this.GROUPBOX_Setting.Size = new System.Drawing.Size(177, 410);
            this.GROUPBOX_Setting.TabIndex = 7;
            this.GROUPBOX_Setting.TabStop = false;
            this.GROUPBOX_Setting.Text = "参数设置";
            // 
            // LABEL_Msg
            // 
            this.LABEL_Msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LABEL_Msg.ForeColor = System.Drawing.Color.Red;
            this.LABEL_Msg.Location = new System.Drawing.Point(8, 71);
            this.LABEL_Msg.Name = "LABEL_Msg";
            this.LABEL_Msg.Size = new System.Drawing.Size(163, 277);
            this.LABEL_Msg.TabIndex = 14;
            // 
            // LINKLABEL_Inf
            // 
            this.LINKLABEL_Inf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LINKLABEL_Inf.Location = new System.Drawing.Point(6, 371);
            this.LINKLABEL_Inf.Name = "LINKLABEL_Inf";
            this.LINKLABEL_Inf.Size = new System.Drawing.Size(165, 35);
            this.LINKLABEL_Inf.TabIndex = 16;
            this.LINKLABEL_Inf.TabStop = true;
            this.LINKLABEL_Inf.Text = "https://www.cnblogs.com/fwindpeak/p/3822259.html";
            this.LINKLABEL_Inf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LINKLABEL_Inf_LinkClicked);
            // 
            // LABEL_Inf
            // 
            this.LABEL_Inf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LABEL_Inf.Location = new System.Drawing.Point(8, 353);
            this.LABEL_Inf.Name = "LABEL_Inf";
            this.LABEL_Inf.Size = new System.Drawing.Size(163, 18);
            this.LABEL_Inf.TabIndex = 15;
            this.LABEL_Inf.Text = "C#的图片拼接 -  fwindpeak ";
            // 
            // BTN_Preview
            // 
            this.BTN_Preview.Location = new System.Drawing.Point(32, 45);
            this.BTN_Preview.Name = "BTN_Preview";
            this.BTN_Preview.Size = new System.Drawing.Size(50, 23);
            this.BTN_Preview.TabIndex = 12;
            this.BTN_Preview.Text = "预览";
            this.BTN_Preview.UseVisualStyleBackColor = true;
            this.BTN_Preview.Click += new System.EventHandler(this.BTN_Preview_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(93, 45);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(50, 23);
            this.BTN_Save.TabIndex = 13;
            this.BTN_Save.Text = "保存";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // TEXTBOX_SizeY
            // 
            this.TEXTBOX_SizeY.Location = new System.Drawing.Point(123, 18);
            this.TEXTBOX_SizeY.MaxLength = 10;
            this.TEXTBOX_SizeY.Name = "TEXTBOX_SizeY";
            this.TEXTBOX_SizeY.Size = new System.Drawing.Size(50, 21);
            this.TEXTBOX_SizeY.TabIndex = 11;
            // 
            // LABEL_X
            // 
            this.LABEL_X.AutoSize = true;
            this.LABEL_X.Location = new System.Drawing.Point(110, 21);
            this.LABEL_X.Name = "LABEL_X";
            this.LABEL_X.Size = new System.Drawing.Size(11, 12);
            this.LABEL_X.TabIndex = 10;
            this.LABEL_X.Text = "X";
            // 
            // LABEL_Size
            // 
            this.LABEL_Size.AutoSize = true;
            this.LABEL_Size.Location = new System.Drawing.Point(4, 21);
            this.LABEL_Size.Name = "LABEL_Size";
            this.LABEL_Size.Size = new System.Drawing.Size(53, 12);
            this.LABEL_Size.TabIndex = 8;
            this.LABEL_Size.Text = "画布尺寸";
            // 
            // TEXTBOX_SizeX
            // 
            this.TEXTBOX_SizeX.Location = new System.Drawing.Point(57, 18);
            this.TEXTBOX_SizeX.MaxLength = 10;
            this.TEXTBOX_SizeX.Name = "TEXTBOX_SizeX";
            this.TEXTBOX_SizeX.Size = new System.Drawing.Size(50, 21);
            this.TEXTBOX_SizeX.TabIndex = 9;
            this.TEXTBOX_SizeX.Leave += new System.EventHandler(this.TEXTBOX_SizeX_Leave);
            // 
            // GROUPBOX_SrcPic
            // 
            this.GROUPBOX_SrcPic.Controls.Add(this.BTN_Clr);
            this.GROUPBOX_SrcPic.Controls.Add(this.BTN_Del);
            this.GROUPBOX_SrcPic.Controls.Add(this.BTN_Add);
            this.GROUPBOX_SrcPic.Controls.Add(this.LISTVIEW_SrcPicList);
            this.GROUPBOX_SrcPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.GROUPBOX_SrcPic.Location = new System.Drawing.Point(0, 0);
            this.GROUPBOX_SrcPic.Name = "GROUPBOX_SrcPic";
            this.GROUPBOX_SrcPic.Size = new System.Drawing.Size(149, 410);
            this.GROUPBOX_SrcPic.TabIndex = 0;
            this.GROUPBOX_SrcPic.TabStop = false;
            this.GROUPBOX_SrcPic.Text = "原始图片";
            // 
            // BTN_Clr
            // 
            this.BTN_Clr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Clr.Location = new System.Drawing.Point(101, 381);
            this.BTN_Clr.Name = "BTN_Clr";
            this.BTN_Clr.Size = new System.Drawing.Size(41, 23);
            this.BTN_Clr.TabIndex = 4;
            this.BTN_Clr.Text = "清空";
            this.BTN_Clr.UseVisualStyleBackColor = true;
            this.BTN_Clr.Click += new System.EventHandler(this.BTN_Clr_Click);
            // 
            // BTN_Del
            // 
            this.BTN_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Del.Location = new System.Drawing.Point(54, 381);
            this.BTN_Del.Name = "BTN_Del";
            this.BTN_Del.Size = new System.Drawing.Size(41, 23);
            this.BTN_Del.TabIndex = 3;
            this.BTN_Del.Text = "删除";
            this.BTN_Del.UseVisualStyleBackColor = true;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Add.Location = new System.Drawing.Point(7, 381);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(41, 23);
            this.BTN_Add.TabIndex = 2;
            this.BTN_Add.Text = "添加";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // LISTVIEW_SrcPicList
            // 
            this.LISTVIEW_SrcPicList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LISTVIEW_SrcPicList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LISTVIEW_SrcPicList.HideSelection = false;
            this.LISTVIEW_SrcPicList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LISTVIEW_SrcPicList.Location = new System.Drawing.Point(7, 17);
            this.LISTVIEW_SrcPicList.Name = "LISTVIEW_SrcPicList";
            this.LISTVIEW_SrcPicList.Size = new System.Drawing.Size(135, 358);
            this.LISTVIEW_SrcPicList.TabIndex = 1;
            this.LISTVIEW_SrcPicList.UseCompatibleStateImageBehavior = false;
            // 
            // GROUPBOX_Preview
            // 
            this.GROUPBOX_Preview.Controls.Add(this.panel1);
            this.GROUPBOX_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GROUPBOX_Preview.Location = new System.Drawing.Point(149, 0);
            this.GROUPBOX_Preview.Name = "GROUPBOX_Preview";
            this.GROUPBOX_Preview.Size = new System.Drawing.Size(572, 410);
            this.GROUPBOX_Preview.TabIndex = 5;
            this.GROUPBOX_Preview.TabStop = false;
            this.GROUPBOX_Preview.Text = "拼接预览";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 390);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.Filter = "图片文件(*.bmp,*.jpg,*.png,*.gif）|*.bmp;*.jpg;*.png;*.gif|所有文件(*.*)|*.*";
            this.OpenFileDialog1.Multiselect = true;
            this.OpenFileDialog1.Title = "选择图片";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 410);
            this.Controls.Add(this.GROUPBOX_Preview);
            this.Controls.Add(this.GROUPBOX_SrcPic);
            this.Controls.Add(this.GROUPBOX_Setting);
            this.Name = "MainForm";
            this.Text = "图片拼接";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GROUPBOX_Setting.ResumeLayout(false);
            this.GROUPBOX_Setting.PerformLayout();
            this.GROUPBOX_SrcPic.ResumeLayout(false);
            this.GROUPBOX_Preview.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GROUPBOX_Setting;
        private System.Windows.Forms.TextBox TEXTBOX_SizeY;
        private System.Windows.Forms.Label LABEL_X;
        private System.Windows.Forms.Label LABEL_Size;
        private System.Windows.Forms.TextBox TEXTBOX_SizeX;
        private System.Windows.Forms.GroupBox GROUPBOX_SrcPic;
        private System.Windows.Forms.Button BTN_Clr;
        private System.Windows.Forms.Button BTN_Del;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.ListView LISTVIEW_SrcPicList;
        private System.Windows.Forms.GroupBox GROUPBOX_Preview;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.Button BTN_Preview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel LINKLABEL_Inf;
        private System.Windows.Forms.Label LABEL_Inf;
        private System.Windows.Forms.Label LABEL_Msg;
    }
}

