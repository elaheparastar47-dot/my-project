
namespace session
{
    partial class AirlineRegister
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
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.passA = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.passAlbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.SHOWB1 = new System.Windows.Forms.CheckBox();
            this.SHOWB2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AirNameF = new System.Windows.Forms.TextBox();
            this.backbtnair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).BeginInit();
            this.SuspendLayout();
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(410, 147);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(100, 22);
            this.usertxt.TabIndex = 1;
            this.usertxt.TextChanged += new System.EventHandler(this.usertxt_TextChanged);
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(410, 220);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(100, 22);
            this.passtxt.TabIndex = 2;
            this.passtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passtxt_KeyDown);
            // 
            // passA
            // 
            this.passA.Location = new System.Drawing.Point(410, 287);
            this.passA.Name = "passA";
            this.passA.PasswordChar = '*';
            this.passA.Size = new System.Drawing.Size(100, 22);
            this.passA.TabIndex = 3;
            this.passA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passA_KeyDown);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(410, 353);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(100, 22);
            this.emailtxt.TabIndex = 4;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 147);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(243, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "نام کاربری:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passlbl
            // 
            this.passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(546, 217);
            this.passlbl.Name = "passlbl";
            this.passlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passlbl.Size = new System.Drawing.Size(243, 23);
            this.passlbl.TabIndex = 7;
            this.passlbl.Text = "رمزعبور:";
            this.passlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passAlbl
            // 
            this.passAlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passAlbl.Location = new System.Drawing.Point(536, 284);
            this.passAlbl.Name = "passAlbl";
            this.passAlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passAlbl.Size = new System.Drawing.Size(243, 23);
            this.passAlbl.TabIndex = 8;
            this.passAlbl.Text = "تکرار رمز عبور:";
            this.passAlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emaillbl
            // 
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(536, 353);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.emaillbl.Size = new System.Drawing.Size(243, 23);
            this.emaillbl.TabIndex = 9;
            this.emaillbl.Text = "ایمیل:";
            this.emaillbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logopic
            // 
            this.logopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logopic.Location = new System.Drawing.Point(55, 49);
            this.logopic.Name = "logopic";
            this.logopic.Size = new System.Drawing.Size(237, 201);
            this.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logopic.TabIndex = 10;
            this.logopic.TabStop = false;
            this.logopic.Click += new System.EventHandler(this.logopic_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(243, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "اپلود لوگوی شرکت:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // subbtn
            // 
            this.subbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subbtn.Location = new System.Drawing.Point(-1, 338);
            this.subbtn.Name = "subbtn";
            this.subbtn.Size = new System.Drawing.Size(252, 110);
            this.subbtn.TabIndex = 12;
            this.subbtn.Text = "ثبت";
            this.subbtn.UseVisualStyleBackColor = true;
            this.subbtn.Click += new System.EventHandler(this.subbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(92, 256);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(159, 48);
            this.searchbtn.TabIndex = 13;
            this.searchbtn.Text = "جست و جو";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // SHOWB1
            // 
            this.SHOWB1.AutoSize = true;
            this.SHOWB1.Location = new System.Drawing.Point(315, 220);
            this.SHOWB1.Name = "SHOWB1";
            this.SHOWB1.Size = new System.Drawing.Size(79, 21);
            this.SHOWB1.TabIndex = 14;
            this.SHOWB1.Text = "نمایش رمز";
            this.SHOWB1.UseVisualStyleBackColor = true;
            this.SHOWB1.CheckedChanged += new System.EventHandler(this.SHOWB1_CheckedChanged);
            // 
            // SHOWB2
            // 
            this.SHOWB2.AutoSize = true;
            this.SHOWB2.Location = new System.Drawing.Point(315, 287);
            this.SHOWB2.Name = "SHOWB2";
            this.SHOWB2.Size = new System.Drawing.Size(79, 21);
            this.SHOWB2.TabIndex = 15;
            this.SHOWB2.Text = "نمایش رمز";
            this.SHOWB2.UseVisualStyleBackColor = true;
            this.SHOWB2.CheckedChanged += new System.EventHandler(this.SHOWB2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 73);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(301, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "نام شرکت هواپیمایی به فارسی:\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AirNameF
            // 
            this.AirNameF.Location = new System.Drawing.Point(372, 76);
            this.AirNameF.Name = "AirNameF";
            this.AirNameF.Size = new System.Drawing.Size(100, 22);
            this.AirNameF.TabIndex = 16;
            this.AirNameF.TextChanged += new System.EventHandler(this.AirNameF_TextChanged);
            // 
            // backbtnair
            // 
            this.backbtnair.Location = new System.Drawing.Point(260, 381);
            this.backbtnair.Name = "backbtnair";
            this.backbtnair.Size = new System.Drawing.Size(212, 51);
            this.backbtnair.TabIndex = 18;
            this.backbtnair.Text = "بازگشت ";
            this.backbtnair.UseVisualStyleBackColor = true;
            this.backbtnair.Click += new System.EventHandler(this.backbtnair_Click);
            // 
            // AirlineRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtnair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AirNameF);
            this.Controls.Add(this.SHOWB2);
            this.Controls.Add(this.SHOWB1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.subbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logopic);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.passAlbl);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.passA);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AirlineRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirlineRegister";
            this.Load += new System.EventHandler(this.AirlineRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox passA;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label passAlbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.PictureBox logopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button subbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.CheckBox SHOWB1;
        private System.Windows.Forms.CheckBox SHOWB2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AirNameF;
        private System.Windows.Forms.Button backbtnair;
    }
}