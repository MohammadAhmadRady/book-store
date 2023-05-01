namespace Database
{
    partial class Form7
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTHOR_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUB_YEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uniLibraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uniLibraryDataSet = new Database.UniLibraryDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.uniLibraryDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new Database.UniLibraryDataSetTableAdapters.BOOKTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOANTableAdapter = new Database.UniLibraryDataSetTableAdapters.LOANTableAdapter();
            this.bOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniLibraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniLibraryDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 150);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 461);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 197);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 247);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Book Author";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(175, 304);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Category";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIDDataGridViewTextBoxColumn,
            this.TITLE,
            this.CATEGORY,
            this.AUTHOR_NAME,
            this.PUB_YEAR,
            this.PRICE});
            this.dataGridView1.DataSource = this.bOOKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(487, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(857, 382);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "B_ID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "B_ID";
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            // 
            // TITLE
            // 
            this.TITLE.DataPropertyName = "TITLE";
            this.TITLE.HeaderText = "TITLE";
            this.TITLE.Name = "TITLE";
            // 
            // CATEGORY
            // 
            this.CATEGORY.DataPropertyName = "CATEGORY";
            this.CATEGORY.HeaderText = "CATEGORY";
            this.CATEGORY.Name = "CATEGORY";
            // 
            // AUTHOR_NAME
            // 
            this.AUTHOR_NAME.DataPropertyName = "AUTHOR_NAME";
            this.AUTHOR_NAME.HeaderText = "AUTHOR_NAME";
            this.AUTHOR_NAME.Name = "AUTHOR_NAME";
            // 
            // PUB_YEAR
            // 
            this.PUB_YEAR.DataPropertyName = "PUB_YEAR";
            this.PUB_YEAR.HeaderText = "PUB_YEAR";
            this.PUB_YEAR.Name = "PUB_YEAR";
            // 
            // PRICE
            // 
            this.PRICE.DataPropertyName = "PRICE";
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.Name = "PRICE";
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.uniLibraryDataSetBindingSource;
            // 
            // uniLibraryDataSetBindingSource
            // 
            this.uniLibraryDataSetBindingSource.DataSource = this.uniLibraryDataSet;
            this.uniLibraryDataSetBindingSource.Position = 0;
            // 
            // uniLibraryDataSet
            // 
            this.uniLibraryDataSet.DataSetName = "UniLibraryDataSet";
            this.uniLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(487, 461);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "My loan List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uniLibraryDataSetBindingSource1
            // 
            this.uniLibraryDataSetBindingSource1.DataSource = this.uniLibraryDataSet;
            this.uniLibraryDataSetBindingSource1.Position = 0;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1079, 497);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "Refersh ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(620, 461);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 41);
            this.button4.TabIndex = 14;
            this.button4.Text = "Borrow";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(866, 461);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 41);
            this.button5.TabIndex = 15;
            this.button5.Text = "Return";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(743, 461);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 41);
            this.button6.TabIndex = 16;
            this.button6.Text = "Renew";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(175, 347);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(203, 22);
            this.textBox5.TabIndex = 19;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "PUB_Year";
            // 
            // lOANBindingSource
            // 
            this.lOANBindingSource.DataMember = "LOAN";
            this.lOANBindingSource.DataSource = this.uniLibraryDataSetBindingSource;
            // 
            // lOANTableAdapter
            // 
            this.lOANTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKBindingSource1
            // 
            this.bOOKBindingSource1.DataMember = "BOOK";
            this.bOOKBindingSource1.DataSource = this.uniLibraryDataSetBindingSource1;
            // 
            // bOOKBindingSource2
            // 
            this.bOOKBindingSource2.DataMember = "BOOK";
            this.bOOKBindingSource2.DataSource = this.uniLibraryDataSetBindingSource1;
            // 
            // bOOKBindingSource3
            // 
            this.bOOKBindingSource3.DataMember = "BOOK";
            this.bOOKBindingSource3.DataSource = this.uniLibraryDataSetBindingSource1;
            // 
            // bOOKBindingSource4
            // 
            this.bOOKBindingSource4.DataMember = "BOOK";
            this.bOOKBindingSource4.DataSource = this.uniLibraryDataSetBindingSource;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1208, 497);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 38);
            this.button7.TabIndex = 21;
            this.button7.Text = "Log out";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 549);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form7";
            this.Text = "STUDENT";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniLibraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniLibraryDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource uniLibraryDataSetBindingSource1;
        private UniLibraryDataSet uniLibraryDataSet;
        private System.Windows.Forms.BindingSource uniLibraryDataSetBindingSource;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private UniLibraryDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource lOANBindingSource;
        private UniLibraryDataSetTableAdapters.LOANTableAdapter lOANTableAdapter;
        private System.Windows.Forms.BindingSource bOOKBindingSource2;
        private System.Windows.Forms.BindingSource bOOKBindingSource1;
        private System.Windows.Forms.BindingSource bOOKBindingSource3;
        private System.Windows.Forms.BindingSource bOOKBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTHOR_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUB_YEAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.Button button7;
    }
}