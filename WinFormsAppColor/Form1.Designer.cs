namespace WinFormsAppColor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            colorIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cultureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            meaningDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isPositiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            colorsAndMeaningBindingSource = new BindingSource(components);
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colorsAndMeaningBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colorIdDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, cultureDataGridViewTextBoxColumn, meaningDataGridViewTextBoxColumn, isPositiveDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = colorsAndMeaningBindingSource;
            dataGridView1.Location = new Point(34, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(599, 323);
            dataGridView1.TabIndex = 0;
            // 
            // colorIdDataGridViewTextBoxColumn
            // 
            colorIdDataGridViewTextBoxColumn.DataPropertyName = "ColorId";
            colorIdDataGridViewTextBoxColumn.HeaderText = "ColorId";
            colorIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            colorIdDataGridViewTextBoxColumn.Name = "colorIdDataGridViewTextBoxColumn";
            colorIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            colorDataGridViewTextBoxColumn.HeaderText = "Color";
            colorDataGridViewTextBoxColumn.MinimumWidth = 8;
            colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            colorDataGridViewTextBoxColumn.Width = 150;
            // 
            // cultureDataGridViewTextBoxColumn
            // 
            cultureDataGridViewTextBoxColumn.DataPropertyName = "Culture";
            cultureDataGridViewTextBoxColumn.HeaderText = "Culture";
            cultureDataGridViewTextBoxColumn.MinimumWidth = 8;
            cultureDataGridViewTextBoxColumn.Name = "cultureDataGridViewTextBoxColumn";
            cultureDataGridViewTextBoxColumn.Width = 150;
            // 
            // meaningDataGridViewTextBoxColumn
            // 
            meaningDataGridViewTextBoxColumn.DataPropertyName = "Meaning";
            meaningDataGridViewTextBoxColumn.HeaderText = "Meaning";
            meaningDataGridViewTextBoxColumn.MinimumWidth = 8;
            meaningDataGridViewTextBoxColumn.Name = "meaningDataGridViewTextBoxColumn";
            meaningDataGridViewTextBoxColumn.Width = 150;
            // 
            // isPositiveDataGridViewCheckBoxColumn
            // 
            isPositiveDataGridViewCheckBoxColumn.DataPropertyName = "IsPositive";
            isPositiveDataGridViewCheckBoxColumn.HeaderText = "IsPositive";
            isPositiveDataGridViewCheckBoxColumn.MinimumWidth = 8;
            isPositiveDataGridViewCheckBoxColumn.Name = "isPositiveDataGridViewCheckBoxColumn";
            isPositiveDataGridViewCheckBoxColumn.Width = 150;
            // 
            // colorsAndMeaningBindingSource
            // 
            colorsAndMeaningBindingSource.DataSource = typeof(BookModels.ColorsAndMeaning);
            // 
            // button1
            // 
            button1.Location = new Point(639, 38);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Törlés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", colorsAndMeaningBindingSource, "Color", true));
            textBox1.Location = new Point(639, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", colorsAndMeaningBindingSource, "Culture", true));
            textBox2.Location = new Point(638, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", colorsAndMeaningBindingSource, "Meaning", true));
            textBox3.Location = new Point(638, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", colorsAndMeaningBindingSource, "IsPositive", true));
            textBox4.Location = new Point(638, 246);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 397);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)colorsAndMeaningBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn colorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cultureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn meaningDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isPositiveDataGridViewCheckBoxColumn;
        private BindingSource colorsAndMeaningBindingSource;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
