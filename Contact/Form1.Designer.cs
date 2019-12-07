namespace Contact
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bds1 = new System.Windows.Forms.BindingSource(this.components);
            this.bds2 = new System.Windows.Forms.BindingSource(this.components);
            this.bd3 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddNhom = new System.Windows.Forms.Button();
            this.btnDeleteNhom = new System.Windows.Forms.Button();
            this.btnAddLienLac = new System.Windows.Forms.Button();
            this.btnDeleteLienLac = new System.Windows.Forms.Button();
            this.btnEditLienLac = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripLabel5,
            this.toolStripTextBox2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(793, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(226, 25);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.ToolStripTextBox1_TextChanged);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel5.Text = "Nhập từ tìm kiếm";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 26);
            this.panel1.TabIndex = 1;
            // 
            // dvg1
            // 
            this.dvg1.AllowUserToAddRows = false;
            this.dvg1.AllowUserToDeleteRows = false;
            this.dvg1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dvg1.Location = new System.Drawing.Point(3, 31);
            this.dvg1.Margin = new System.Windows.Forms.Padding(2);
            this.dvg1.Name = "dvg1";
            this.dvg1.ReadOnly = true;
            this.dvg1.RowHeadersWidth = 51;
            this.dvg1.RowTemplate.Height = 24;
            this.dvg1.Size = new System.Drawing.Size(228, 502);
            this.dvg1.TabIndex = 2;
            this.dvg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "TenNhom";
            this.Column1.HeaderText = "Tên nhóm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 175;
            // 
            // dvg2
            // 
            this.dvg2.AllowUserToAddRows = false;
            this.dvg2.AllowUserToDeleteRows = false;
            this.dvg2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Email,
            this.Column3,
            this.Column2});
            this.dvg2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dvg2.Location = new System.Drawing.Point(237, 31);
            this.dvg2.Margin = new System.Windows.Forms.Padding(2);
            this.dvg2.Name = "dvg2";
            this.dvg2.ReadOnly = true;
            this.dvg2.RowHeadersWidth = 51;
            this.dvg2.RowTemplate.Height = 24;
            this.dvg2.Size = new System.Drawing.Size(560, 284);
            this.dvg2.TabIndex = 3;
            this.dvg2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg2_CellClick);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tengoi";
            this.Column4.HeaderText = "Tên gọi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "SDT";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenNhom";
            this.Column2.HeaderText = "Tên nhóm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên gọi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "................................................................................." +
    "......................................................................";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 405);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 449);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 488);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 362);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 31);
            this.label6.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(402, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(402, 449);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(402, 488);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 12;
            // 
            // btnAddNhom
            // 
            this.btnAddNhom.Location = new System.Drawing.Point(3, 538);
            this.btnAddNhom.Name = "btnAddNhom";
            this.btnAddNhom.Size = new System.Drawing.Size(75, 23);
            this.btnAddNhom.TabIndex = 13;
            this.btnAddNhom.Text = "Thêm nhóm";
            this.btnAddNhom.UseVisualStyleBackColor = true;
            this.btnAddNhom.Click += new System.EventHandler(this.btnAddNhom_Click);
            // 
            // btnDeleteNhom
            // 
            this.btnDeleteNhom.Location = new System.Drawing.Point(100, 537);
            this.btnDeleteNhom.Name = "btnDeleteNhom";
            this.btnDeleteNhom.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteNhom.TabIndex = 14;
            this.btnDeleteNhom.Text = "Xóa nhóm";
            this.btnDeleteNhom.UseVisualStyleBackColor = true;
            this.btnDeleteNhom.Click += new System.EventHandler(this.btnDeleteNhom_Click);
            // 
            // btnAddLienLac
            // 
            this.btnAddLienLac.Location = new System.Drawing.Point(2, 567);
            this.btnAddLienLac.Name = "btnAddLienLac";
            this.btnAddLienLac.Size = new System.Drawing.Size(90, 23);
            this.btnAddLienLac.TabIndex = 15;
            this.btnAddLienLac.Text = "Thêm liên lạc";
            this.btnAddLienLac.UseVisualStyleBackColor = true;
            this.btnAddLienLac.Click += new System.EventHandler(this.btnAddLienLac_Click);
            // 
            // btnDeleteLienLac
            // 
            this.btnDeleteLienLac.Location = new System.Drawing.Point(100, 567);
            this.btnDeleteLienLac.Name = "btnDeleteLienLac";
            this.btnDeleteLienLac.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLienLac.TabIndex = 16;
            this.btnDeleteLienLac.Text = "Xóa liên lạc";
            this.btnDeleteLienLac.UseVisualStyleBackColor = true;
            this.btnDeleteLienLac.Click += new System.EventHandler(this.btnDeleteLienLac_Click);
            // 
            // btnEditLienLac
            // 
            this.btnEditLienLac.Location = new System.Drawing.Point(181, 567);
            this.btnEditLienLac.Name = "btnEditLienLac";
            this.btnEditLienLac.Size = new System.Drawing.Size(75, 23);
            this.btnEditLienLac.TabIndex = 17;
            this.btnEditLienLac.Text = "Sửa liên lạc";
            this.btnEditLienLac.UseVisualStyleBackColor = true;
            this.btnEditLienLac.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 599);
            this.Controls.Add(this.btnEditLienLac);
            this.Controls.Add(this.btnDeleteLienLac);
            this.Controls.Add(this.btnAddLienLac);
            this.Controls.Add(this.btnDeleteNhom);
            this.Controls.Add(this.btnAddNhom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvg2);
            this.Controls.Add(this.dvg1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.DataGridView dvg2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bds1;
        private System.Windows.Forms.BindingSource bds2;
        private System.Windows.Forms.BindingSource bd3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnAddNhom;
        private System.Windows.Forms.Button btnDeleteNhom;
        private System.Windows.Forms.Button btnAddLienLac;
        private System.Windows.Forms.Button btnDeleteLienLac;
        private System.Windows.Forms.Button btnEditLienLac;
    }
}

