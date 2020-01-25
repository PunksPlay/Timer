namespace Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_m = new System.Windows.Forms.TextBox();
            this.t_h = new System.Windows.Forms.TextBox();
            this.b_add = new System.Windows.Forms.Button();
            this.b_start = new System.Windows.Forms.Button();
            this.b_reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.t_add = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_end = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьКФайлуВыводаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьКФайлуМузыкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.задатьГромкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "M";
            // 
            // t_m
            // 
            this.t_m.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.t_m.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_m.Location = new System.Drawing.Point(44, 82);
            this.t_m.Name = "t_m";
            this.t_m.Size = new System.Drawing.Size(48, 33);
            this.t_m.TabIndex = 2;
            this.t_m.Text = "1";
            // 
            // t_h
            // 
            this.t_h.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.t_h.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_h.Location = new System.Drawing.Point(44, 37);
            this.t_h.Name = "t_h";
            this.t_h.Size = new System.Drawing.Size(48, 33);
            this.t_h.TabIndex = 3;
            this.t_h.Text = "0";
            // 
            // b_add
            // 
            this.b_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.b_add.FlatAppearance.BorderSize = 0;
            this.b_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_add.Location = new System.Drawing.Point(98, 33);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(74, 38);
            this.b_add.TabIndex = 4;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = false;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // b_start
            // 
            this.b_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(200)))), ((int)(((byte)(45)))));
            this.b_start.FlatAppearance.BorderSize = 0;
            this.b_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_start.Font = new System.Drawing.Font("Nexa Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_start.Location = new System.Drawing.Point(18, 124);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(154, 38);
            this.b_start.TabIndex = 5;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = false;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // b_reset
            // 
            this.b_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.b_reset.FlatAppearance.BorderSize = 0;
            this.b_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_reset.Font = new System.Drawing.Font("Nexa Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_reset.Location = new System.Drawing.Point(98, 78);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(74, 38);
            this.b_reset.TabIndex = 6;
            this.b_reset.Text = "Reset";
            this.b_reset.UseVisualStyleBackColor = false;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total added time";
            // 
            // t_add
            // 
            this.t_add.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.t_add.Font = new System.Drawing.Font("Open Sans Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_add.Location = new System.Drawing.Point(18, 196);
            this.t_add.Name = "t_add";
            this.t_add.Size = new System.Drawing.Size(154, 36);
            this.t_add.TabIndex = 9;
            this.t_add.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(14, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "After time\'s up";
            // 
            // t_end
            // 
            this.t_end.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.t_end.Font = new System.Drawing.Font("Open Sans Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_end.Location = new System.Drawing.Point(18, 263);
            this.t_end.Name = "t_end";
            this.t_end.Size = new System.Drawing.Size(154, 36);
            this.t_end.TabIndex = 11;
            this.t_end.Text = "Time\'s up!";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(188, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.путьКФайлуВыводаToolStripMenuItem,
            this.путьКФайлуМузыкиToolStripMenuItem,
            this.задатьГромкостьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // путьКФайлуВыводаToolStripMenuItem
            // 
            this.путьКФайлуВыводаToolStripMenuItem.Name = "путьКФайлуВыводаToolStripMenuItem";
            this.путьКФайлуВыводаToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.путьКФайлуВыводаToolStripMenuItem.Text = "Путь к папке вывода";
            this.путьКФайлуВыводаToolStripMenuItem.Click += new System.EventHandler(this.путьКФайлуВыводаToolStripMenuItem_Click);
            // 
            // путьКФайлуМузыкиToolStripMenuItem
            // 
            this.путьКФайлуМузыкиToolStripMenuItem.Name = "путьКФайлуМузыкиToolStripMenuItem";
            this.путьКФайлуМузыкиToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.путьКФайлуМузыкиToolStripMenuItem.Text = "Путь к файлу музыки";
            this.путьКФайлуМузыкиToolStripMenuItem.Click += new System.EventHandler(this.путьКФайлуМузыкиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инфоToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // инфоToolStripMenuItem
            // 
            this.инфоToolStripMenuItem.Name = "инфоToolStripMenuItem";
            this.инфоToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.инфоToolStripMenuItem.Text = "Инфо";
            this.инфоToolStripMenuItem.Click += new System.EventHandler(this.инфоToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // задатьГромкостьToolStripMenuItem
            // 
            this.задатьГромкостьToolStripMenuItem.Name = "задатьГромкостьToolStripMenuItem";
            this.задатьГромкостьToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.задатьГромкостьToolStripMenuItem.Text = "Задать громкость";
            this.задатьГромкостьToolStripMenuItem.Click += new System.EventHandler(this.задатьГромкостьToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(188, 307);
            this.Controls.Add(this.t_end);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_reset);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.t_h);
            this.Controls.Add(this.t_m);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_m;
        private System.Windows.Forms.TextBox t_h;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_end;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путьКФайлуВыводаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путьКФайлуМузыкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инфоToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьГромкостьToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
    }
}

