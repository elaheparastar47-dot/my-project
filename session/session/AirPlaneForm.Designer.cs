
namespace session
{
    partial class AirPlaneForm
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
            this.airName1 = new System.Windows.Forms.Label();
            this.AirPlaneName1 = new System.Windows.Forms.Label();
            this.Capacitylbl = new System.Windows.Forms.Label();
            this.YearMadelbl = new System.Windows.Forms.Label();
            this.SeriesNumberlbl = new System.Windows.Forms.Label();
            this.AirPic1 = new System.Windows.Forms.Label();
            this.airpicP = new System.Windows.Forms.PictureBox();
            this.picsearch = new System.Windows.Forms.Button();
            this.subairbtn = new System.Windows.Forms.Button();
            this.airName1txt = new System.Windows.Forms.TextBox();
            this.Capacitytxt = new System.Windows.Forms.TextBox();
            this.YearMadetxt = new System.Windows.Forms.TextBox();
            this.SeriesNumbertxt = new System.Windows.Forms.TextBox();
            this.AirPlaneNametxt = new System.Windows.Forms.TextBox();
            this.AirPlaneNamelist = new System.Windows.Forms.ListBox();
            this.airim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.airpicP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airim)).BeginInit();
            this.SuspendLayout();
            // 
            // airName1
            // 
            this.airName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airName1.Location = new System.Drawing.Point(566, 37);
            this.airName1.Name = "airName1";
            this.airName1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.airName1.Size = new System.Drawing.Size(203, 23);
            this.airName1.TabIndex = 0;
            this.airName1.Text = "نام هواپیما به لاتین:";
            // 
            // AirPlaneName1
            // 
            this.AirPlaneName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirPlaneName1.Location = new System.Drawing.Point(547, 92);
            this.AirPlaneName1.Name = "AirPlaneName1";
            this.AirPlaneName1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AirPlaneName1.Size = new System.Drawing.Size(222, 23);
            this.AirPlaneName1.TabIndex = 1;
            this.AirPlaneName1.Text = "نام شرکت هواپیمایی:";
            // 
            // Capacitylbl
            // 
            this.Capacitylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capacitylbl.Location = new System.Drawing.Point(639, 151);
            this.Capacitylbl.Name = "Capacitylbl";
            this.Capacitylbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Capacitylbl.Size = new System.Drawing.Size(130, 23);
            this.Capacitylbl.TabIndex = 2;
            this.Capacitylbl.Text = "ظرفیت هواپیما:";
            // 
            // YearMadelbl
            // 
            this.YearMadelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearMadelbl.Location = new System.Drawing.Point(639, 213);
            this.YearMadelbl.Name = "YearMadelbl";
            this.YearMadelbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.YearMadelbl.Size = new System.Drawing.Size(130, 23);
            this.YearMadelbl.TabIndex = 3;
            this.YearMadelbl.Text = "سال ساخت:";
            // 
            // SeriesNumberlbl
            // 
            this.SeriesNumberlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeriesNumberlbl.Location = new System.Drawing.Point(639, 263);
            this.SeriesNumberlbl.Name = "SeriesNumberlbl";
            this.SeriesNumberlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SeriesNumberlbl.Size = new System.Drawing.Size(130, 23);
            this.SeriesNumberlbl.TabIndex = 4;
            this.SeriesNumberlbl.Text = "شماره سریال:";
            // 
            // AirPic1
            // 
            this.AirPic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirPic1.Location = new System.Drawing.Point(284, 37);
            this.AirPic1.Name = "AirPic1";
            this.AirPic1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AirPic1.Size = new System.Drawing.Size(130, 23);
            this.AirPic1.TabIndex = 5;
            this.AirPic1.Text = "عکس هواپیما:";
            // 
            // airpicP
            // 
            this.airpicP.Location = new System.Drawing.Point(42, 14);
            this.airpicP.Name = "airpicP";
            this.airpicP.Size = new System.Drawing.Size(249, 222);
            this.airpicP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.airpicP.TabIndex = 6;
            this.airpicP.TabStop = false;
            // 
            // picsearch
            // 
            this.picsearch.Location = new System.Drawing.Point(83, 242);
            this.picsearch.Name = "picsearch";
            this.picsearch.Size = new System.Drawing.Size(156, 67);
            this.picsearch.TabIndex = 7;
            this.picsearch.Text = "جست و جو";
            this.picsearch.UseVisualStyleBackColor = true;
            this.picsearch.Click += new System.EventHandler(this.picsearch_Click);
            // 
            // subairbtn
            // 
            this.subairbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subairbtn.Location = new System.Drawing.Point(284, 329);
            this.subairbtn.Name = "subairbtn";
            this.subairbtn.Size = new System.Drawing.Size(276, 94);
            this.subairbtn.TabIndex = 8;
            this.subairbtn.Text = "ثبت";
            this.subairbtn.UseVisualStyleBackColor = true;
            this.subairbtn.Click += new System.EventHandler(this.subairbtn_Click);
            // 
            // airName1txt
            // 
            this.airName1txt.Location = new System.Drawing.Point(442, 37);
            this.airName1txt.Name = "airName1txt";
            this.airName1txt.Size = new System.Drawing.Size(118, 22);
            this.airName1txt.TabIndex = 9;
            this.airName1txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.airName1txt_KeyDown);
            this.airName1txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.airName1txt_KeyPress);
            // 
            // Capacitytxt
            // 
            this.Capacitytxt.Location = new System.Drawing.Point(479, 153);
            this.Capacitytxt.Name = "Capacitytxt";
            this.Capacitytxt.Size = new System.Drawing.Size(118, 22);
            this.Capacitytxt.TabIndex = 11;
            this.Capacitytxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Capacitytxt_KeyDown);
            // 
            // YearMadetxt
            // 
            this.YearMadetxt.Location = new System.Drawing.Point(479, 215);
            this.YearMadetxt.Name = "YearMadetxt";
            this.YearMadetxt.Size = new System.Drawing.Size(118, 22);
            this.YearMadetxt.TabIndex = 12;
            // 
            // SeriesNumbertxt
            // 
            this.SeriesNumbertxt.Location = new System.Drawing.Point(479, 265);
            this.SeriesNumbertxt.Name = "SeriesNumbertxt";
            this.SeriesNumbertxt.Size = new System.Drawing.Size(118, 22);
            this.SeriesNumbertxt.TabIndex = 13;
            // 
            // AirPlaneNametxt
            // 
            this.AirPlaneNametxt.Location = new System.Drawing.Point(504, 94);
            this.AirPlaneNametxt.Name = "AirPlaneNametxt";
            this.AirPlaneNametxt.ReadOnly = true;
            this.AirPlaneNametxt.Size = new System.Drawing.Size(93, 22);
            this.AirPlaneNametxt.TabIndex = 10;
            // 
            // AirPlaneNamelist
            // 
            this.AirPlaneNamelist.FormattingEnabled = true;
            this.AirPlaneNamelist.ItemHeight = 16;
            this.AirPlaneNamelist.Location = new System.Drawing.Point(414, 96);
            this.AirPlaneNamelist.Name = "AirPlaneNamelist";
            this.AirPlaneNamelist.Size = new System.Drawing.Size(84, 20);
            this.AirPlaneNamelist.TabIndex = 14;
            this.AirPlaneNamelist.SelectedIndexChanged += new System.EventHandler(this.AirPlaneNamelist_SelectedIndexChanged);
            // 
            // airim
            // 
            this.airim.Location = new System.Drawing.Point(308, 77);
            this.airim.Name = "airim";
            this.airim.Size = new System.Drawing.Size(100, 65);
            this.airim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.airim.TabIndex = 15;
            this.airim.TabStop = false;
            this.airim.Click += new System.EventHandler(this.airim_Click);
            // 
            // AirPlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.airim);
            this.Controls.Add(this.AirPlaneNamelist);
            this.Controls.Add(this.SeriesNumbertxt);
            this.Controls.Add(this.YearMadetxt);
            this.Controls.Add(this.Capacitytxt);
            this.Controls.Add(this.AirPlaneNametxt);
            this.Controls.Add(this.airName1txt);
            this.Controls.Add(this.subairbtn);
            this.Controls.Add(this.picsearch);
            this.Controls.Add(this.airpicP);
            this.Controls.Add(this.AirPic1);
            this.Controls.Add(this.SeriesNumberlbl);
            this.Controls.Add(this.YearMadelbl);
            this.Controls.Add(this.Capacitylbl);
            this.Controls.Add(this.AirPlaneName1);
            this.Controls.Add(this.airName1);
            this.Name = "AirPlaneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AirPlaneForm";
            this.Load += new System.EventHandler(this.AirPlaneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airpicP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label airName1;
        private System.Windows.Forms.Label AirPlaneName1;
        private System.Windows.Forms.Label Capacitylbl;
        private System.Windows.Forms.Label YearMadelbl;
        private System.Windows.Forms.Label SeriesNumberlbl;
        private System.Windows.Forms.Label AirPic1;
        private System.Windows.Forms.PictureBox airpicP;
        private System.Windows.Forms.Button picsearch;
        private System.Windows.Forms.Button subairbtn;
        private System.Windows.Forms.TextBox airName1txt;
        private System.Windows.Forms.TextBox Capacitytxt;
        private System.Windows.Forms.TextBox YearMadetxt;
        private System.Windows.Forms.TextBox SeriesNumbertxt;
        private System.Windows.Forms.TextBox AirPlaneNametxt;
        private System.Windows.Forms.ListBox AirPlaneNamelist;
        private System.Windows.Forms.PictureBox airim;
    }
}