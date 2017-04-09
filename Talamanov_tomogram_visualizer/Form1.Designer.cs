namespace Talamanov_tomogram_visualizer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glControl1 = new OpenTK.GLControl();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.rdBtnQuads = new System.Windows.Forms.RadioButton();
            this.rdBtnTexture = new System.Windows.Forms.RadioButton();
            this.tbMin = new System.Windows.Forms.TrackBar();
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1443, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(13, 152);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(1394, 528);
            this.glControl1.TabIndex = 1;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 27);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1333, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // rdBtnQuads
            // 
            this.rdBtnQuads.AutoSize = true;
            this.rdBtnQuads.Checked = true;
            this.rdBtnQuads.Location = new System.Drawing.Point(1375, 41);
            this.rdBtnQuads.Name = "rdBtnQuads";
            this.rdBtnQuads.Size = new System.Drawing.Size(56, 17);
            this.rdBtnQuads.TabIndex = 3;
            this.rdBtnQuads.TabStop = true;
            this.rdBtnQuads.Text = "Quads";
            this.rdBtnQuads.UseVisualStyleBackColor = true;
            // 
            // rdBtnTexture
            // 
            this.rdBtnTexture.AutoSize = true;
            this.rdBtnTexture.Location = new System.Drawing.Point(1370, 64);
            this.rdBtnTexture.Name = "rdBtnTexture";
            this.rdBtnTexture.Size = new System.Drawing.Size(61, 17);
            this.rdBtnTexture.TabIndex = 4;
            this.rdBtnTexture.Text = "Texture";
            this.rdBtnTexture.UseVisualStyleBackColor = true;
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(13, 64);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(1333, 45);
            this.tbMin.TabIndex = 5;
            this.tbMin.Scroll += new System.EventHandler(this.tbMin_Scroll);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(13, 101);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(1332, 45);
            this.tbWidth.TabIndex = 6;
            this.tbWidth.Scroll += new System.EventHandler(this.tbWidth_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 747);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.rdBtnTexture);
            this.Controls.Add(this.rdBtnQuads);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton rdBtnQuads;
        private System.Windows.Forms.RadioButton rdBtnTexture;
        private System.Windows.Forms.TrackBar tbMin;
        private System.Windows.Forms.TrackBar tbWidth;
    }
}

