namespace Deepak_Xerox
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
            this.dgv_practice = new System.Windows.Forms.DataGridView();
            this.deepakXeroxDataSource = new Deepak_Xerox.DeepakXeroxDataSource();
            this.deepakXeroxDataSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_practice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deepakXeroxDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deepakXeroxDataSourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_practice
            // 
            this.dgv_practice.AutoGenerateColumns = false;
            this.dgv_practice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_practice.DataSource = this.deepakXeroxDataSourceBindingSource;
            this.dgv_practice.Location = new System.Drawing.Point(12, 76);
            this.dgv_practice.Name = "dgv_practice";
            this.dgv_practice.Size = new System.Drawing.Size(546, 184);
            this.dgv_practice.TabIndex = 0;
            // 
            // deepakXeroxDataSource
            // 
            this.deepakXeroxDataSource.DataSetName = "DeepakXeroxDataSource";
            this.deepakXeroxDataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deepakXeroxDataSourceBindingSource
            // 
            this.deepakXeroxDataSourceBindingSource.DataSource = this.deepakXeroxDataSource;
            this.deepakXeroxDataSourceBindingSource.Position = 0;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(248, 29);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Find";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 381);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dgv_practice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_practice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deepakXeroxDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deepakXeroxDataSourceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_practice;
        private System.Windows.Forms.BindingSource deepakXeroxDataSourceBindingSource;
        private DeepakXeroxDataSource deepakXeroxDataSource;
        private System.Windows.Forms.Button Search;
    }
}