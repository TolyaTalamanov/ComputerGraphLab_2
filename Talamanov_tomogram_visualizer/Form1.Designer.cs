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
            this.tbMax = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMax)).BeginInit();
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
            this.glControl1.Location = new System.Drawing.Point(18, 191);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(1413, 544);
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
            this.rdBtnQuads.Location = new System.Drawing.Point(1351, 27);
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
            this.rdBtnTexture.Location = new System.Drawing.Point(1351, 50);
            this.rdBtnTexture.Name = "rdBtnTexture";
            this.rdBtnTexture.Size = new System.Drawing.Size(61, 17);
            this.rdBtnTexture.TabIndex = 4;
            this.rdBtnTexture.Text = "Texture";
            this.rdBtnTexture.UseVisualStyleBackColor = true;
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(14, 89);
            this.tbMin.Maximum = 2096;
            this.tbMin.Minimum = -1000;
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(1333, 45);
            this.tbMin.TabIndex = 5;
            this.tbMin.Value = -1000;
            this.tbMin.Scroll += new System.EventHandler(this.tbMin_Scroll);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(14, 140);
            this.tbMax.Maximum = 2096;
            this.tbMax.Minimum = -1000;
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(1332, 45);
            this.tbMax.TabIndex = 6;
            this.tbMax.Value = 2096;
            this.tbMax.Scroll += new System.EventHandler(this.tbMax_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1343, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Min value";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1343, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Max value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1337, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Switch view";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 747);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbMax);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbMax)).EndInit();
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
        private System.Windows.Forms.TrackBar tbMax;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

