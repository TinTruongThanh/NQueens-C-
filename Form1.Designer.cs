namespace NQueens
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lableTitle = new System.Windows.Forms.Label();
            this.noQueen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTitleTime = new System.Windows.Forms.Label();
            this.pictureBoxStarting = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnShowResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noQueen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStarting)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lableTitle
            // 
            this.lableTitle.AutoSize = true;
            this.lableTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTitle.ForeColor = System.Drawing.Color.Chocolate;
            this.lableTitle.Location = new System.Drawing.Point(154, 19);
            this.lableTitle.Name = "lableTitle";
            this.lableTitle.Size = new System.Drawing.Size(338, 31);
            this.lableTitle.TabIndex = 0;
            this.lableTitle.Text = "BÀI TOÁN N QUÂN HẬU";
            this.lableTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // noQueen
            // 
            this.noQueen.Location = new System.Drawing.Point(489, 106);
            this.noQueen.Name = "noQueen";
            this.noQueen.Size = new System.Drawing.Size(86, 20);
            this.noQueen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số quân hậu:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(514, 304);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 17);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "3:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(495, 149);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // lblTitleTime
            // 
            this.lblTitleTime.AutoSize = true;
            this.lblTitleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTime.ForeColor = System.Drawing.Color.Red;
            this.lblTitleTime.Location = new System.Drawing.Point(504, 284);
            this.lblTitleTime.Name = "lblTitleTime";
            this.lblTitleTime.Size = new System.Drawing.Size(60, 13);
            this.lblTitleTime.TabIndex = 6;
            this.lblTitleTime.Text = "Thời gian";
            // 
            // pictureBoxStarting
            // 
            this.pictureBoxStarting.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStarting.Image")));
            this.pictureBoxStarting.InitialImage = null;
            this.pictureBoxStarting.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxStarting.Name = "pictureBoxStarting";
            this.pictureBoxStarting.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxStarting.TabIndex = 7;
            this.pictureBoxStarting.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxStarting);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 400);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnShowResult
            // 
            this.btnShowResult.BackColor = System.Drawing.Color.Black;
            this.btnShowResult.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowResult.FlatAppearance.BorderSize = 0;
            this.btnShowResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResult.ForeColor = System.Drawing.Color.White;
            this.btnShowResult.Location = new System.Drawing.Point(495, 398);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(75, 23);
            this.btnShowResult.TabIndex = 5;
            this.btnShowResult.Text = "ĐÁP ÁN";
            this.btnShowResult.UseVisualStyleBackColor = false;
            this.btnShowResult.Click += new System.EventHandler(this.btnStart_Click);
            this.btnShowResult.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnShowResult.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(620, 487);
            this.Controls.Add(this.lblTitleTime);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noQueen);
            this.Controls.Add(this.lableTitle);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noQueen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStarting)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableTitle;
        private System.Windows.Forms.NumericUpDown noQueen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTitleTime;
        private System.Windows.Forms.PictureBox pictureBoxStarting;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnShowResult;
    }
}

