namespace Image_Processor
{
    partial class Form1
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
            this.picOG = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrighten = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDarken = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRotateHoriz = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreyscale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPencil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.Pic_OG = new System.Windows.Forms.PictureBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFlipVert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRot90 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScale50 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScale200 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picOG)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_OG)).BeginInit();
            this.SuspendLayout();
            // 
            // picOG
            // 
            this.picOG.Location = new System.Drawing.Point(28, 45);
            this.picOG.MaximumSize = new System.Drawing.Size(800, 600);
            this.picOG.Name = "picOG";
            this.picOG.Size = new System.Drawing.Size(800, 600);
            this.picOG.TabIndex = 0;
            this.picOG.TabStop = false;
            this.picOG.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSaveAs});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(180, 22);
            this.mnuSaveAs.Text = "Save As";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBlur,
            this.mnuBrighten,
            this.mnuDarken,
            this.mnuFlipVert,
            this.mnuRotateHoriz,
            this.mnuGreyscale,
            this.mnuInvert,
            this.mnuPencil,
            this.mnuRot90,
            this.mnuScale50,
            this.mnuScale200,
            this.toolStripSeparator1,
            this.mnuReset});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // mnuBlur
            // 
            this.mnuBlur.Name = "mnuBlur";
            this.mnuBlur.Size = new System.Drawing.Size(180, 22);
            this.mnuBlur.Text = "Blur";
            this.mnuBlur.Click += new System.EventHandler(this.mnuBlur_Click);
            // 
            // mnuBrighten
            // 
            this.mnuBrighten.Name = "mnuBrighten";
            this.mnuBrighten.Size = new System.Drawing.Size(180, 22);
            this.mnuBrighten.Text = "Brighten";
            this.mnuBrighten.Click += new System.EventHandler(this.mnuBrighten_Click_1);
            // 
            // mnuDarken
            // 
            this.mnuDarken.Name = "mnuDarken";
            this.mnuDarken.Size = new System.Drawing.Size(180, 22);
            this.mnuDarken.Text = "Darken";
            this.mnuDarken.Click += new System.EventHandler(this.mnuBrighten_Click);
            // 
            // mnuRotateHoriz
            // 
            this.mnuRotateHoriz.Name = "mnuRotateHoriz";
            this.mnuRotateHoriz.Size = new System.Drawing.Size(180, 22);
            this.mnuRotateHoriz.Text = "Flip Horizontally";
            this.mnuRotateHoriz.Click += new System.EventHandler(this.mnuRotateHoriz_click);
            // 
            // mnuGreyscale
            // 
            this.mnuGreyscale.Name = "mnuGreyscale";
            this.mnuGreyscale.Size = new System.Drawing.Size(180, 22);
            this.mnuGreyscale.Text = "Greyscale";
            this.mnuGreyscale.Click += new System.EventHandler(this.mnuGreyscale_Click);
            // 
            // mnuInvert
            // 
            this.mnuInvert.Name = "mnuInvert";
            this.mnuInvert.Size = new System.Drawing.Size(180, 22);
            this.mnuInvert.Text = "Invert";
            this.mnuInvert.Click += new System.EventHandler(this.mnuInvert_Click);
            // 
            // mnuPencil
            // 
            this.mnuPencil.Name = "mnuPencil";
            this.mnuPencil.Size = new System.Drawing.Size(180, 22);
            this.mnuPencil.Text = "Pencil";
            this.mnuPencil.Click += new System.EventHandler(this.mnuPencil_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuReset
            // 
            this.mnuReset.Name = "mnuReset";
            this.mnuReset.Size = new System.Drawing.Size(180, 22);
            this.mnuReset.Text = "Reset";
            this.mnuReset.Click += new System.EventHandler(this.mnuReset_Click);
            // 
            // Pic_OG
            // 
            this.Pic_OG.Location = new System.Drawing.Point(360, 186);
            this.Pic_OG.Name = "Pic_OG";
            this.Pic_OG.Size = new System.Drawing.Size(100, 50);
            this.Pic_OG.TabIndex = 6;
            this.Pic_OG.TabStop = false;
            this.Pic_OG.Click += new System.EventHandler(this.Pic_OG_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuFlipVert
            // 
            this.mnuFlipVert.Name = "mnuFlipVert";
            this.mnuFlipVert.Size = new System.Drawing.Size(180, 22);
            this.mnuFlipVert.Text = "Flip Vertically";
            this.mnuFlipVert.Click += new System.EventHandler(this.mnuFlipVert_Click);
            // 
            // mnuRot90
            // 
            this.mnuRot90.Name = "mnuRot90";
            this.mnuRot90.Size = new System.Drawing.Size(180, 22);
            this.mnuRot90.Text = "Rotate 90";
            this.mnuRot90.Click += new System.EventHandler(this.mnuRot90_Click);
            // 
            // mnuScale50
            // 
            this.mnuScale50.Name = "mnuScale50";
            this.mnuScale50.Size = new System.Drawing.Size(180, 22);
            this.mnuScale50.Text = "Scale 50";
            this.mnuScale50.Click += new System.EventHandler(this.mnuScale50_Click);
            // 
            // mnuScale200
            // 
            this.mnuScale200.Name = "mnuScale200";
            this.mnuScale200.Size = new System.Drawing.Size(180, 22);
            this.mnuScale200.Text = "Scale 200";
            this.mnuScale200.Click += new System.EventHandler(this.mnuScale200_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 670);
            this.Controls.Add(this.Pic_OG);
            this.Controls.Add(this.picOG);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Processing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOG)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_OG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOG;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDarken;
        private System.Windows.Forms.ToolStripMenuItem mnuBrighten;
        private System.Windows.Forms.ToolStripMenuItem mnuInvert;
        private System.Windows.Forms.ToolStripMenuItem mnuGreyscale;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuReset;
        private System.Windows.Forms.ToolStripMenuItem mnuBlur;
        private System.Windows.Forms.ToolStripMenuItem mnuPencil;
        private System.Windows.Forms.ToolStripMenuItem mnuRotateHoriz;
        private System.Windows.Forms.PictureBox Pic_OG;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuFlipVert;
        private System.Windows.Forms.ToolStripMenuItem mnuRot90;
        private System.Windows.Forms.ToolStripMenuItem mnuScale50;
        private System.Windows.Forms.ToolStripMenuItem mnuScale200;
    }
}

