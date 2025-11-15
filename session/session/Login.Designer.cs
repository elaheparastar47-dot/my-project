
namespace session
{
    partial class Login
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
            this.UsrTXT = new System.Windows.Forms.TextBox();
            this.CodeTXT = new System.Windows.Forms.TextBox();
            this.PassTXT = new System.Windows.Forms.TextBox();
            this.EmailTXT = new System.Windows.Forms.TextBox();
            this.logbtn = new System.Windows.Forms.Button();
            this.CodeP = new System.Windows.Forms.Panel();
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.PassWordlbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Codelbl = new System.Windows.Forms.Label();
            this.codebtn = new System.Windows.Forms.Button();
            this.timer_login = new System.Windows.Forms.Timer(this.components);
            this.seclbl = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UsrTXT
            // 
            this.UsrTXT.Location = new System.Drawing.Point(445, 37);
            this.UsrTXT.Name = "UsrTXT";
            this.UsrTXT.Size = new System.Drawing.Size(195, 22);
            this.UsrTXT.TabIndex = 0;
            this.UsrTXT.TextChanged += new System.EventHandler(this.UsrTXT_TextChanged);
            // 
            // CodeTXT
            // 
            this.CodeTXT.Location = new System.Drawing.Point(445, 164);
            this.CodeTXT.Name = "CodeTXT";
            this.CodeTXT.Size = new System.Drawing.Size(195, 22);
            this.CodeTXT.TabIndex = 1;
            // 
            // PassTXT
            // 
            this.PassTXT.Location = new System.Drawing.Point(445, 77);
            this.PassTXT.Name = "PassTXT";
            this.PassTXT.PasswordChar = '*';
            this.PassTXT.Size = new System.Drawing.Size(195, 22);
            this.PassTXT.TabIndex = 2;
            // 
            // EmailTXT
            // 
            this.EmailTXT.Location = new System.Drawing.Point(445, 116);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(195, 22);
            this.EmailTXT.TabIndex = 3;
            // 
            // logbtn
            // 
            this.logbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.Location = new System.Drawing.Point(214, 270);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(360, 117);
            this.logbtn.TabIndex = 4;
            this.logbtn.Text = "ورود";
            this.logbtn.UseVisualStyleBackColor = true;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // CodeP
            // 
            this.CodeP.Location = new System.Drawing.Point(12, 12);
            this.CodeP.Name = "CodeP";
            this.CodeP.Size = new System.Drawing.Size(250, 190);
            this.CodeP.TabIndex = 5;
            this.CodeP.Paint += new System.Windows.Forms.PaintEventHandler(this.CodeP_Paint);
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.AutoSize = true;
            this.UserNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamelbl.Location = new System.Drawing.Point(645, 33);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(95, 25);
            this.UserNamelbl.TabIndex = 6;
            this.UserNamelbl.Text = "نام کاربری";
            // 
            // PassWordlbl
            // 
            this.PassWordlbl.AutoSize = true;
            this.PassWordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordlbl.Location = new System.Drawing.Point(659, 77);
            this.PassWordlbl.Name = "PassWordlbl";
            this.PassWordlbl.Size = new System.Drawing.Size(81, 25);
            this.PassWordlbl.TabIndex = 7;
            this.PassWordlbl.Text = "رمزعبور";
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.Location = new System.Drawing.Point(659, 116);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(49, 25);
            this.Emaillbl.TabIndex = 8;
            this.Emaillbl.Text = "ایمیل";
            // 
            // Codelbl
            // 
            this.Codelbl.AutoSize = true;
            this.Codelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codelbl.Location = new System.Drawing.Point(646, 164);
            this.Codelbl.Name = "Codelbl";
            this.Codelbl.Size = new System.Drawing.Size(80, 25);
            this.Codelbl.TabIndex = 9;
            this.Codelbl.Text = "کد امنیتی";
            this.Codelbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // codebtn
            // 
            this.codebtn.Location = new System.Drawing.Point(268, 13);
            this.codebtn.Name = "codebtn";
            this.codebtn.Size = new System.Drawing.Size(125, 46);
            this.codebtn.TabIndex = 0;
            this.codebtn.Text = "تغییر کد";
            this.codebtn.UseVisualStyleBackColor = true;
            this.codebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer_login
            // 
            this.timer_login.Interval = 1000;
            this.timer_login.Tick += new System.EventHandler(this.timer_login_Tick);
            // 
            // seclbl
            // 
            this.seclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seclbl.Location = new System.Drawing.Point(30, 219);
            this.seclbl.Name = "seclbl";
            this.seclbl.Size = new System.Drawing.Size(139, 67);
            this.seclbl.TabIndex = 11;
            this.seclbl.Text = "00";
            this.seclbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(623, 297);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(148, 71);
            this.logout.TabIndex = 12;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.Location = new System.Drawing.Point(330, 79);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(79, 21);
            this.show.TabIndex = 13;
            this.show.Text = "نمایش رمز";
            this.show.UseVisualStyleBackColor = true;
            this.show.CheckedChanged += new System.EventHandler(this.show_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.seclbl);
            this.Controls.Add(this.codebtn);
            this.Controls.Add(this.PassWordlbl);
            this.Controls.Add(this.Codelbl);
            this.Controls.Add(this.Emaillbl);
            this.Controls.Add(this.UserNamelbl);
            this.Controls.Add(this.CodeP);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.EmailTXT);
            this.Controls.Add(this.PassTXT);
            this.Controls.Add(this.CodeTXT);
            this.Controls.Add(this.UsrTXT);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsrTXT;
        private System.Windows.Forms.TextBox CodeTXT;
        private System.Windows.Forms.TextBox PassTXT;
        private System.Windows.Forms.TextBox EmailTXT;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Panel CodeP;
        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.Label PassWordlbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label Codelbl;
        private System.Windows.Forms.Button codebtn;
        private System.Windows.Forms.Timer timer_login;
        private System.Windows.Forms.Label seclbl;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.CheckBox show;
    }
}