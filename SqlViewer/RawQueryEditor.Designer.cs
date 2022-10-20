namespace Zadatak0102
{
    partial class RawQueryEditor
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
            this.tbQueryEditor = new System.Windows.Forms.TextBox();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbError = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQueryEditor
            // 
            this.tbQueryEditor.Location = new System.Drawing.Point(57, 70);
            this.tbQueryEditor.MinimumSize = new System.Drawing.Size(100, 100);
            this.tbQueryEditor.Multiline = true;
            this.tbQueryEditor.Name = "tbQueryEditor";
            this.tbQueryEditor.Size = new System.Drawing.Size(652, 100);
            this.tbQueryEditor.TabIndex = 0;
            this.tbQueryEditor.TabStop = false;
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Location = new System.Drawing.Point(273, 211);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(229, 50);
            this.btnRunQuery.TabIndex = 1;
            this.btnRunQuery.Text = "Run query";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(286, 23);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(195, 24);
            this.cbDatabases.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 264);
            this.dataGridView1.TabIndex = 3;
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(12, 689);
            this.tbError.Multiline = true;
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(827, 220);
            this.tbError.TabIndex = 4;
            // 
            // RawQueryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 1043);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.btnRunQuery);
            this.Controls.Add(this.tbQueryEditor);
            this.Name = "RawQueryEditor";
            this.Text = "RawQueryEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQueryEditor;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbError;
    }
}