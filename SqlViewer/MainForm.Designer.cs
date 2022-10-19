
namespace Zadatak
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbTables = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LbViews = new System.Windows.Forms.ListBox();
            this.LbTableColums = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LbViewColumns = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LbProcedures = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbProcedure = new System.Windows.Forms.TextBox();
            this.LbProcedureParameters = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnXMLTable = new System.Windows.Forms.Button();
            this.BtnSelectTable = new System.Windows.Forms.Button();
            this.BtnSelectView = new System.Windows.Forms.Button();
            this.BtnXMLView = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases:";
            // 
            // CbDatabases
            // 
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(99, 38);
            this.CbDatabases.Margin = new System.Windows.Forms.Padding(4);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(188, 24);
            this.CbDatabases.TabIndex = 1;
            this.CbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tables:";
            // 
            // LbTables
            // 
            this.LbTables.FormattingEnabled = true;
            this.LbTables.ItemHeight = 16;
            this.LbTables.Location = new System.Drawing.Point(99, 97);
            this.LbTables.Name = "LbTables";
            this.LbTables.Size = new System.Drawing.Size(317, 308);
            this.LbTables.TabIndex = 3;
            this.LbTables.SelectedIndexChanged += new System.EventHandler(this.LbTables_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(820, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Views:";
            // 
            // LbViews
            // 
            this.LbViews.FormattingEnabled = true;
            this.LbViews.ItemHeight = 16;
            this.LbViews.Location = new System.Drawing.Point(874, 97);
            this.LbViews.Name = "LbViews";
            this.LbViews.Size = new System.Drawing.Size(245, 308);
            this.LbViews.TabIndex = 5;
            this.LbViews.SelectedIndexChanged += new System.EventHandler(this.LbViews_SelectedIndexChanged);
            // 
            // LbTableColums
            // 
            this.LbTableColums.FormattingEnabled = true;
            this.LbTableColums.ItemHeight = 16;
            this.LbTableColums.Location = new System.Drawing.Point(593, 97);
            this.LbTableColums.Name = "LbTableColums";
            this.LbTableColums.Size = new System.Drawing.Size(188, 308);
            this.LbTableColums.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Table Columns:";
            // 
            // LbViewColumns
            // 
            this.LbViewColumns.FormattingEnabled = true;
            this.LbViewColumns.ItemHeight = 16;
            this.LbViewColumns.Location = new System.Drawing.Point(1307, 97);
            this.LbViewColumns.Name = "LbViewColumns";
            this.LbViewColumns.Size = new System.Drawing.Size(188, 308);
            this.LbViewColumns.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1202, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "View Columns:";
            // 
            // LbProcedures
            // 
            this.LbProcedures.FormattingEnabled = true;
            this.LbProcedures.ItemHeight = 16;
            this.LbProcedures.Location = new System.Drawing.Point(99, 464);
            this.LbProcedures.Name = "LbProcedures";
            this.LbProcedures.Size = new System.Drawing.Size(317, 308);
            this.LbProcedures.TabIndex = 11;
            this.LbProcedures.SelectedIndexChanged += new System.EventHandler(this.LbProcedures_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Procedures:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Procedure definition:";
            // 
            // TbProcedure
            // 
            this.TbProcedure.Location = new System.Drawing.Point(593, 464);
            this.TbProcedure.Multiline = true;
            this.TbProcedure.Name = "TbProcedure";
            this.TbProcedure.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbProcedure.Size = new System.Drawing.Size(526, 308);
            this.TbProcedure.TabIndex = 13;
            // 
            // LbProcedureParameters
            // 
            this.LbProcedureParameters.FormattingEnabled = true;
            this.LbProcedureParameters.ItemHeight = 16;
            this.LbProcedureParameters.Location = new System.Drawing.Point(1307, 464);
            this.LbProcedureParameters.Name = "LbProcedureParameters";
            this.LbProcedureParameters.Size = new System.Drawing.Size(188, 308);
            this.LbProcedureParameters.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1147, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Procedure parameters:";
            // 
            // BtnXMLTable
            // 
            this.BtnXMLTable.Location = new System.Drawing.Point(434, 299);
            this.BtnXMLTable.Name = "BtnXMLTable";
            this.BtnXMLTable.Size = new System.Drawing.Size(98, 50);
            this.BtnXMLTable.TabIndex = 16;
            this.BtnXMLTable.Text = "XML";
            this.BtnXMLTable.UseVisualStyleBackColor = true;
            this.BtnXMLTable.Click += new System.EventHandler(this.BtnXml_Click);
            // 
            // BtnSelectTable
            // 
            this.BtnSelectTable.Location = new System.Drawing.Point(434, 355);
            this.BtnSelectTable.Name = "BtnSelectTable";
            this.BtnSelectTable.Size = new System.Drawing.Size(98, 50);
            this.BtnSelectTable.TabIndex = 17;
            this.BtnSelectTable.Text = "Select";
            this.BtnSelectTable.UseVisualStyleBackColor = true;
            this.BtnSelectTable.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnSelectView
            // 
            this.BtnSelectView.Location = new System.Drawing.Point(1141, 355);
            this.BtnSelectView.Name = "BtnSelectView";
            this.BtnSelectView.Size = new System.Drawing.Size(98, 50);
            this.BtnSelectView.TabIndex = 18;
            this.BtnSelectView.Text = "Select";
            this.BtnSelectView.UseVisualStyleBackColor = true;
            this.BtnSelectView.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnXMLView
            // 
            this.BtnXMLView.Location = new System.Drawing.Point(1141, 299);
            this.BtnXMLView.Name = "BtnXMLView";
            this.BtnXMLView.Size = new System.Drawing.Size(98, 50);
            this.BtnXMLView.TabIndex = 19;
            this.BtnXMLView.Text = "XML";
            this.BtnXMLView.UseVisualStyleBackColor = true;
            this.BtnXMLView.Click += new System.EventHandler(this.BtnXml_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Raw query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1571, 836);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnXMLView);
            this.Controls.Add(this.BtnSelectView);
            this.Controls.Add(this.BtnSelectTable);
            this.Controls.Add(this.BtnXMLTable);
            this.Controls.Add(this.LbProcedureParameters);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbProcedure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LbProcedures);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LbViewColumns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbTableColums);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbViews);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbDatabases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LbTables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LbViews;
        private System.Windows.Forms.ListBox LbTableColums;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LbViewColumns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LbProcedures;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbProcedure;
        private System.Windows.Forms.ListBox LbProcedureParameters;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnXMLTable;
        private System.Windows.Forms.Button BtnSelectTable;
        private System.Windows.Forms.Button BtnSelectView;
        private System.Windows.Forms.Button BtnXMLView;
        private System.Windows.Forms.Button button1;
    }
}

