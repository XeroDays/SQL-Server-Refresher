namespace MSSQL_Refresher
{
    partial class GetIntoDatabase
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBoxSeelctAll = new System.Windows.Forms.CheckBox();
            this.btnTruncate = new System.Windows.Forms.Button();
            this.btnReseedIdentity = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(225, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 202);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tables";
            // 
            // chkBoxSeelctAll
            // 
            this.chkBoxSeelctAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBoxSeelctAll.AutoSize = true;
            this.chkBoxSeelctAll.Location = new System.Drawing.Point(12, 309);
            this.chkBoxSeelctAll.Name = "chkBoxSeelctAll";
            this.chkBoxSeelctAll.Size = new System.Drawing.Size(70, 17);
            this.chkBoxSeelctAll.TabIndex = 3;
            this.chkBoxSeelctAll.Text = "Select All";
            this.chkBoxSeelctAll.UseVisualStyleBackColor = true;
            this.chkBoxSeelctAll.CheckedChanged += new System.EventHandler(this.chkBoxSeelctAll_CheckedChanged);
            // 
            // btnTruncate
            // 
            this.btnTruncate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruncate.Location = new System.Drawing.Point(185, 91);
            this.btnTruncate.Name = "btnTruncate";
            this.btnTruncate.Size = new System.Drawing.Size(149, 28);
            this.btnTruncate.TabIndex = 4;
            this.btnTruncate.Text = "Truncate Table";
            this.toolTip1.SetToolTip(this.btnTruncate, "This will delete All the Records i the Selected Tables.");
            this.btnTruncate.UseVisualStyleBackColor = true;
            this.btnTruncate.Click += new System.EventHandler(this.btnTruncate_Click);
            // 
            // btnReseedIdentity
            // 
            this.btnReseedIdentity.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReseedIdentity.Location = new System.Drawing.Point(185, 125);
            this.btnReseedIdentity.Name = "btnReseedIdentity";
            this.btnReseedIdentity.Size = new System.Drawing.Size(149, 28);
            this.btnReseedIdentity.TabIndex = 4;
            this.btnReseedIdentity.Text = "Reset Identity Counter";
            this.toolTip1.SetToolTip(this.btnReseedIdentity, "This will restart the Counter of Indentity Column from 1 (Reseed 1)");
            this.btnReseedIdentity.UseVisualStyleBackColor = true;
            this.btnReseedIdentity.Click += new System.EventHandler(this.btnReseedIdentity_Click);
            // 
            // GetIntoDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 338);
            this.Controls.Add(this.btnReseedIdentity);
            this.Controls.Add(this.btnTruncate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkBoxSeelctAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GetIntoDatabase";
            this.Text = "Database Details";
//            this.Deactivate += new System.EventHandler(this.GetIntoDatabase_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetIntoDatabase_FormClosed);
            this.Load += new System.EventHandler(this.GetIntoDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBoxSeelctAll;
        private System.Windows.Forms.Button btnTruncate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnReseedIdentity;
    }
}