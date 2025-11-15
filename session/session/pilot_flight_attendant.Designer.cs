
namespace session
{
    partial class pilot_and_flight_attendant
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
            this.flight_attendantbtn = new System.Windows.Forms.Button();
            this.pilotbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flight_attendantbtn
            // 
            this.flight_attendantbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight_attendantbtn.Location = new System.Drawing.Point(418, 121);
            this.flight_attendantbtn.Name = "flight_attendantbtn";
            this.flight_attendantbtn.Size = new System.Drawing.Size(296, 172);
            this.flight_attendantbtn.TabIndex = 0;
            this.flight_attendantbtn.Text = "مهماندار";
            this.flight_attendantbtn.UseVisualStyleBackColor = true;
            this.flight_attendantbtn.Click += new System.EventHandler(this.flight_attendantbtn_Click);
            // 
            // pilotbtn
            // 
            this.pilotbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilotbtn.Location = new System.Drawing.Point(67, 121);
            this.pilotbtn.Name = "pilotbtn";
            this.pilotbtn.Size = new System.Drawing.Size(296, 181);
            this.pilotbtn.TabIndex = 1;
            this.pilotbtn.Text = "خلبان";
            this.pilotbtn.UseVisualStyleBackColor = true;
            this.pilotbtn.Click += new System.EventHandler(this.pilotbtn_Click);
            // 
            // pilot_and_flight_attendant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pilotbtn);
            this.Controls.Add(this.flight_attendantbtn);
            this.Name = "pilot_and_flight_attendant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pilot_and_flight_attendant";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button flight_attendantbtn;
        private System.Windows.Forms.Button pilotbtn;
    }
}