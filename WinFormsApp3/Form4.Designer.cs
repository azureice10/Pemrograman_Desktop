namespace WinFormsApp3
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            toolStripContainer1 = new ToolStripContainer();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            toolStrip2 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripButton1 = new ToolStripButton();
            toolStripSplitButton1 = new ToolStripSplitButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripLabel2 = new ToolStripLabel();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            errorProvider1 = new ErrorProvider(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            helpProvider1 = new HelpProvider();
            imageList1 = new ImageList(components);
            process1 = new System.Diagnostics.Process();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(button2);
            toolStripContainer1.ContentPanel.Controls.Add(pictureBox1);
            toolStripContainer1.ContentPanel.Controls.Add(textBox1);
            toolStripContainer1.ContentPanel.Controls.Add(button1);
            toolStripContainer1.ContentPanel.Controls.Add(progressBar1);
            helpProvider1.SetShowHelp(toolStripContainer1.ContentPanel, true);
            toolStripContainer1.ContentPanel.Size = new Size(818, 395);
            toolStripContainer1.ContentPanel.Load += toolStripContainer1_ContentPanel_Load;
            toolStripContainer1.Dock = DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            toolStripContainer1.LeftToolStripPanel.Controls.Add(toolStrip2);
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(930, 450);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // button2
            // 
            button2.Location = new Point(626, 192);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(300, 209);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 2;
            textBox1.Validating += textBox1_Validating;
            // 
            // button1
            // 
            button1.Location = new Point(467, 70);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(357, 21);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(304, 29);
            progressBar1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripButton1, toolStripSplitButton1, toolStripDropDownButton1 });
            toolStrip2.Location = new Point(0, 4);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(112, 116);
            toolStrip2.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(110, 20);
            toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(110, 24);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(110, 24);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(110, 24);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(930, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripLabel2, toolStripDropDownButton2 });
            toolStrip1.Location = new Point(4, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(187, 27);
            toolStrip1.TabIndex = 0;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(111, 24);
            toolStripLabel2.Text = "toolStripLabel2";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(34, 24);
            toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.Path = "C:\\Users\\raden\\OneDrive\\Documents\\Ok";
            fileSystemWatcher1.SynchronizingObject = this;
            fileSystemWatcher1.Created += fileSystemWatcher1_Created;
            fileSystemWatcher1.Renamed += fileSystemWatcher1_Renamed;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "C:\\Users\\raden\\Downloads\\HELP FILE.html";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth24Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "1.jpg");
            imageList1.Images.SetKeyName(1, "2.jpg");
            imageList1.Images.SetKeyName(2, "3.jpg");
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 450);
            Controls.Add(toolStripContainer1);
            MainMenuStrip = menuStrip1;
            Name = "Form4";
            Text = "Form4";
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            toolStripContainer1.LeftToolStripPanel.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip2;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButton1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
        private ToolStripLabel toolStripLabel2;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private TextBox textBox1;
        private ErrorProvider errorProvider1;
        private FileSystemWatcher fileSystemWatcher1;
        private HelpProvider helpProvider1;
        private Button button2;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Timer timer1;
    }
}