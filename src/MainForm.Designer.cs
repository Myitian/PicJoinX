namespace PicJoinX
{
    partial class MainForm
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
            GROUPBOX_Setting = new GroupBox();
            NUD_SizeY = new NumericUpDown();
            NUD_SizeX = new NumericUpDown();
            LABEL_Msg = new Label();
            LINKLABEL_Inf = new LinkLabel();
            LABEL_Inf = new Label();
            BTN_Preview = new Button();
            BTN_Save = new Button();
            LABEL_X = new Label();
            LABEL_Size = new Label();
            GROUPBOX_SrcPic = new GroupBox();
            BTN_Clr = new Button();
            BTN_Del = new Button();
            BTN_Add = new Button();
            LISTVIEW_SrcPicList = new ListView();
            GROUPBOX_Preview = new GroupBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            GROUPBOX_Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_SizeY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_SizeX).BeginInit();
            GROUPBOX_SrcPic.SuspendLayout();
            GROUPBOX_Preview.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GROUPBOX_Setting
            // 
            GROUPBOX_Setting.Controls.Add(NUD_SizeY);
            GROUPBOX_Setting.Controls.Add(NUD_SizeX);
            GROUPBOX_Setting.Controls.Add(LABEL_Msg);
            GROUPBOX_Setting.Controls.Add(LINKLABEL_Inf);
            GROUPBOX_Setting.Controls.Add(LABEL_Inf);
            GROUPBOX_Setting.Controls.Add(BTN_Preview);
            GROUPBOX_Setting.Controls.Add(BTN_Save);
            GROUPBOX_Setting.Controls.Add(LABEL_X);
            GROUPBOX_Setting.Controls.Add(LABEL_Size);
            GROUPBOX_Setting.Dock = DockStyle.Right;
            GROUPBOX_Setting.Location = new Point(842, 0);
            GROUPBOX_Setting.Margin = new Padding(4);
            GROUPBOX_Setting.Name = "GROUPBOX_Setting";
            GROUPBOX_Setting.Padding = new Padding(4);
            GROUPBOX_Setting.Size = new Size(206, 581);
            GROUPBOX_Setting.TabIndex = 7;
            GROUPBOX_Setting.TabStop = false;
            GROUPBOX_Setting.Text = "参数设置";
            // 
            // NUD_SizeY
            // 
            NUD_SizeY.Location = new Point(141, 28);
            NUD_SizeY.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            NUD_SizeY.Name = "NUD_SizeY";
            NUD_SizeY.Size = new Size(58, 23);
            NUD_SizeY.TabIndex = 18;
            // 
            // NUD_SizeX
            // 
            NUD_SizeX.Location = new Point(63, 28);
            NUD_SizeX.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            NUD_SizeX.Name = "NUD_SizeX";
            NUD_SizeX.Size = new Size(58, 23);
            NUD_SizeX.TabIndex = 17;
            // 
            // LABEL_Msg
            // 
            LABEL_Msg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LABEL_Msg.ForeColor = Color.Red;
            LABEL_Msg.Location = new Point(9, 101);
            LABEL_Msg.Margin = new Padding(4, 0, 4, 0);
            LABEL_Msg.Name = "LABEL_Msg";
            LABEL_Msg.Size = new Size(190, 392);
            LABEL_Msg.TabIndex = 14;
            // 
            // LINKLABEL_Inf
            // 
            LINKLABEL_Inf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LINKLABEL_Inf.Location = new Point(7, 526);
            LINKLABEL_Inf.Margin = new Padding(4, 0, 4, 0);
            LINKLABEL_Inf.Name = "LINKLABEL_Inf";
            LINKLABEL_Inf.Size = new Size(192, 50);
            LINKLABEL_Inf.TabIndex = 16;
            LINKLABEL_Inf.TabStop = true;
            LINKLABEL_Inf.Text = "https://www.cnblogs.com/fwindpeak/p/3822259.html";
            LINKLABEL_Inf.LinkClicked += LINKLABEL_Inf_LinkClicked;
            // 
            // LABEL_Inf
            // 
            LABEL_Inf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LABEL_Inf.Location = new Point(9, 500);
            LABEL_Inf.Margin = new Padding(4, 0, 4, 0);
            LABEL_Inf.Name = "LABEL_Inf";
            LABEL_Inf.Size = new Size(190, 26);
            LABEL_Inf.TabIndex = 15;
            LABEL_Inf.Text = "C#的图片拼接 -  fwindpeak ";
            // 
            // BTN_Preview
            // 
            BTN_Preview.Location = new Point(37, 64);
            BTN_Preview.Margin = new Padding(4);
            BTN_Preview.Name = "BTN_Preview";
            BTN_Preview.Size = new Size(58, 33);
            BTN_Preview.TabIndex = 12;
            BTN_Preview.Text = "预览";
            BTN_Preview.UseVisualStyleBackColor = true;
            BTN_Preview.Click += BTN_Preview_Click;
            // 
            // BTN_Save
            // 
            BTN_Save.Location = new Point(108, 64);
            BTN_Save.Margin = new Padding(4);
            BTN_Save.Name = "BTN_Save";
            BTN_Save.Size = new Size(58, 33);
            BTN_Save.TabIndex = 13;
            BTN_Save.Text = "保存";
            BTN_Save.UseVisualStyleBackColor = true;
            BTN_Save.Click += BTN_Save_Click;
            // 
            // LABEL_X
            // 
            LABEL_X.AutoSize = true;
            LABEL_X.Location = new Point(124, 30);
            LABEL_X.Margin = new Padding(4, 0, 4, 0);
            LABEL_X.Name = "LABEL_X";
            LABEL_X.Size = new Size(17, 17);
            LABEL_X.TabIndex = 10;
            LABEL_X.Text = "×";
            // 
            // LABEL_Size
            // 
            LABEL_Size.AutoSize = true;
            LABEL_Size.Location = new Point(5, 30);
            LABEL_Size.Margin = new Padding(4, 0, 4, 0);
            LABEL_Size.Name = "LABEL_Size";
            LABEL_Size.Size = new Size(56, 17);
            LABEL_Size.TabIndex = 8;
            LABEL_Size.Text = "画布尺寸";
            // 
            // GROUPBOX_SrcPic
            // 
            GROUPBOX_SrcPic.Controls.Add(BTN_Clr);
            GROUPBOX_SrcPic.Controls.Add(BTN_Del);
            GROUPBOX_SrcPic.Controls.Add(BTN_Add);
            GROUPBOX_SrcPic.Controls.Add(LISTVIEW_SrcPicList);
            GROUPBOX_SrcPic.Dock = DockStyle.Left;
            GROUPBOX_SrcPic.Location = new Point(0, 0);
            GROUPBOX_SrcPic.Margin = new Padding(4);
            GROUPBOX_SrcPic.Name = "GROUPBOX_SrcPic";
            GROUPBOX_SrcPic.Padding = new Padding(4);
            GROUPBOX_SrcPic.Size = new Size(174, 581);
            GROUPBOX_SrcPic.TabIndex = 0;
            GROUPBOX_SrcPic.TabStop = false;
            GROUPBOX_SrcPic.Text = "原始图片";
            // 
            // BTN_Clr
            // 
            BTN_Clr.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_Clr.Location = new Point(118, 540);
            BTN_Clr.Margin = new Padding(4);
            BTN_Clr.Name = "BTN_Clr";
            BTN_Clr.Size = new Size(48, 33);
            BTN_Clr.TabIndex = 4;
            BTN_Clr.Text = "清空";
            BTN_Clr.UseVisualStyleBackColor = true;
            BTN_Clr.Click += BTN_Clr_Click;
            // 
            // BTN_Del
            // 
            BTN_Del.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_Del.Location = new Point(63, 540);
            BTN_Del.Margin = new Padding(4);
            BTN_Del.Name = "BTN_Del";
            BTN_Del.Size = new Size(48, 33);
            BTN_Del.TabIndex = 3;
            BTN_Del.Text = "删除";
            BTN_Del.UseVisualStyleBackColor = true;
            // 
            // BTN_Add
            // 
            BTN_Add.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_Add.Location = new Point(8, 540);
            BTN_Add.Margin = new Padding(4);
            BTN_Add.Name = "BTN_Add";
            BTN_Add.Size = new Size(48, 33);
            BTN_Add.TabIndex = 2;
            BTN_Add.Text = "添加";
            BTN_Add.UseVisualStyleBackColor = true;
            BTN_Add.Click += BTN_Add_Click;
            // 
            // LISTVIEW_SrcPicList
            // 
            LISTVIEW_SrcPicList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LISTVIEW_SrcPicList.HeaderStyle = ColumnHeaderStyle.None;
            LISTVIEW_SrcPicList.ImeMode = ImeMode.NoControl;
            LISTVIEW_SrcPicList.Location = new Point(8, 24);
            LISTVIEW_SrcPicList.Margin = new Padding(4);
            LISTVIEW_SrcPicList.Name = "LISTVIEW_SrcPicList";
            LISTVIEW_SrcPicList.Size = new Size(157, 506);
            LISTVIEW_SrcPicList.TabIndex = 1;
            LISTVIEW_SrcPicList.UseCompatibleStateImageBehavior = false;
            // 
            // GROUPBOX_Preview
            // 
            GROUPBOX_Preview.Controls.Add(panel1);
            GROUPBOX_Preview.Dock = DockStyle.Fill;
            GROUPBOX_Preview.Location = new Point(174, 0);
            GROUPBOX_Preview.Margin = new Padding(4);
            GROUPBOX_Preview.Name = "GROUPBOX_Preview";
            GROUPBOX_Preview.Padding = new Padding(4);
            GROUPBOX_Preview.Size = new Size(668, 581);
            GROUPBOX_Preview.TabIndex = 5;
            GROUPBOX_Preview.TabStop = false;
            GROUPBOX_Preview.Text = "拼接预览";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 20);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 557);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 581);
            Controls.Add(GROUPBOX_Preview);
            Controls.Add(GROUPBOX_SrcPic);
            Controls.Add(GROUPBOX_Setting);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "图片拼接";
            Load += MainForm_Load;
            GROUPBOX_Setting.ResumeLayout(false);
            GROUPBOX_Setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_SizeY).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_SizeX).EndInit();
            GROUPBOX_SrcPic.ResumeLayout(false);
            GROUPBOX_Preview.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox GROUPBOX_Setting;
        private System.Windows.Forms.Label LABEL_X;
        private System.Windows.Forms.Label LABEL_Size;
        private System.Windows.Forms.GroupBox GROUPBOX_SrcPic;
        private System.Windows.Forms.Button BTN_Clr;
        private System.Windows.Forms.Button BTN_Del;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.ListView LISTVIEW_SrcPicList;
        private System.Windows.Forms.GroupBox GROUPBOX_Preview;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Preview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel LINKLABEL_Inf;
        private System.Windows.Forms.Label LABEL_Inf;
        private System.Windows.Forms.Label LABEL_Msg;
        private NumericUpDown NUD_SizeY;
        private NumericUpDown NUD_SizeX;
    }
}

