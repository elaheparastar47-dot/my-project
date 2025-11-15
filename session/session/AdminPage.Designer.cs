
namespace session
{
    partial class AdminPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.familytxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.flbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(728, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // familytxt
            // 
            this.familytxt.Location = new System.Drawing.Point(228, 30);
            this.familytxt.Name = "familytxt";
            this.familytxt.Size = new System.Drawing.Size(100, 22);
            this.familytxt.TabIndex = 1;
            this.familytxt.TextChanged += new System.EventHandler(this.familytxt_TextChanged);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(423, 30);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 22);
            this.nametxt.TabIndex = 2;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(557, 30);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(19, 17);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "نام";
            // 
            // flbl
            // 
            this.flbl.AutoSize = true;
            this.flbl.Location = new System.Drawing.Point(349, 35);
            this.flbl.Name = "flbl";
            this.flbl.Size = new System.Drawing.Size(34, 17);
            this.flbl.TabIndex = 4;
            this.flbl.Text = "فامیلی";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "جست و جو";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.familytxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox familytxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label flbl;
        private System.Windows.Forms.Button button1;
    }
}