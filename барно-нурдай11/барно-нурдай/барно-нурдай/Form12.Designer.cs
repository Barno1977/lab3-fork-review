namespace барно_нурдай
{
    partial class Form12
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnGenerate = new Button();
            txtRows = new TextBox();
            txtCols = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblPositiveSum = new Label();
            lblNegativeSum = new Label();
            groupBox1 = new GroupBox();
            listBoxNegative = new ListBox();
            listBoxPositive = new ListBox();
            sorted = new Button();
            dataGridViewNegative = new DataGridView();
            dataGridViewPositive = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNegative).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositive).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(71, 66);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(635, 231);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(75, 328);
            btnGenerate.Margin = new Padding(4, 5, 4, 5);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(175, 35);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "СГЕНЕРИРОВАТЬ";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += button1_Click;
            // 
            // txtRows
            // 
            txtRows.Location = new Point(292, 352);
            txtRows.Margin = new Padding(4, 5, 4, 5);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(132, 27);
            txtRows.TabIndex = 2;
            // 
            // txtCols
            // 
            txtCols.Location = new Point(468, 352);
            txtCols.Margin = new Padding(4, 5, 4, 5);
            txtCols.Name = "txtCols";
            txtCols.Size = new Size(132, 27);
            txtCols.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 323);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 4;
            label1.Text = "СТРОКИ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 323);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 5;
            label2.Text = "СТОЛБЦЫ";
            // 
            // lblPositiveSum
            // 
            lblPositiveSum.AutoSize = true;
            lblPositiveSum.Location = new Point(640, 331);
            lblPositiveSum.Margin = new Padding(4, 0, 4, 0);
            lblPositiveSum.Name = "lblPositiveSum";
            lblPositiveSum.Size = new Size(50, 20);
            lblPositiveSum.TabIndex = 6;
            lblPositiveSum.Text = "label3";
            // 
            // lblNegativeSum
            // 
            lblNegativeSum.AutoSize = true;
            lblNegativeSum.Location = new Point(639, 378);
            lblNegativeSum.Margin = new Padding(4, 0, 4, 0);
            lblNegativeSum.Name = "lblNegativeSum";
            lblNegativeSum.Size = new Size(50, 20);
            lblNegativeSum.TabIndex = 7;
            lblNegativeSum.Text = "label4";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxNegative);
            groupBox1.Controls.Add(listBoxPositive);
            groupBox1.Controls.Add(sorted);
            groupBox1.Controls.Add(dataGridViewNegative);
            groupBox1.Controls.Add(dataGridViewPositive);
            groupBox1.Location = new Point(16, 426);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(997, 525);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "ДАННЫЕ МАТРИЦ";
            // 
            // listBoxNegative
            // 
            listBoxNegative.FormattingEnabled = true;
            listBoxNegative.Location = new Point(296, 314);
            listBoxNegative.Margin = new Padding(4, 5, 4, 5);
            listBoxNegative.Name = "listBoxNegative";
            listBoxNegative.Size = new Size(159, 144);
            listBoxNegative.TabIndex = 11;
            // 
            // listBoxPositive
            // 
            listBoxPositive.FormattingEnabled = true;
            listBoxPositive.Location = new Point(25, 308);
            listBoxPositive.Margin = new Padding(4, 5, 4, 5);
            listBoxPositive.Name = "listBoxPositive";
            listBoxPositive.Size = new Size(159, 144);
            listBoxPositive.TabIndex = 10;
            listBoxPositive.SelectedIndexChanged += listBoxPositive_SelectedIndexChanged;
            // 
            // sorted
            // 
            sorted.Location = new Point(784, 68);
            sorted.Margin = new Padding(4, 5, 4, 5);
            sorted.Name = "sorted";
            sorted.Size = new Size(123, 35);
            sorted.TabIndex = 9;
            sorted.Text = "СОРТИРОВКА";
            sorted.UseVisualStyleBackColor = true;
            sorted.Click += sorted_Click;
            // 
            // dataGridViewNegative
            // 
            dataGridViewNegative.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNegative.Location = new Point(403, 48);
            dataGridViewNegative.Margin = new Padding(4, 5, 4, 5);
            dataGridViewNegative.Name = "dataGridViewNegative";
            dataGridViewNegative.RowHeadersWidth = 51;
            dataGridViewNegative.RowTemplate.Height = 24;
            dataGridViewNegative.Size = new Size(352, 231);
            dataGridViewNegative.TabIndex = 1;
            // 
            // dataGridViewPositive
            // 
            dataGridViewPositive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPositive.Location = new Point(25, 45);
            dataGridViewPositive.Margin = new Padding(4, 5, 4, 5);
            dataGridViewPositive.Name = "dataGridViewPositive";
            dataGridViewPositive.RowHeadersWidth = 51;
            dataGridViewPositive.RowTemplate.Height = 24;
            dataGridViewPositive.Size = new Size(340, 231);
            dataGridViewPositive.TabIndex = 0;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 969);
            Controls.Add(groupBox1);
            Controls.Add(lblNegativeSum);
            Controls.Add(lblPositiveSum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCols);
            Controls.Add(txtRows);
            Controls.Add(btnGenerate);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form12";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNegative).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositive).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPositiveSum;
        private System.Windows.Forms.Label lblNegativeSum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sorted;
        private System.Windows.Forms.DataGridView dataGridViewNegative;
        private System.Windows.Forms.DataGridView dataGridViewPositive;
        private System.Windows.Forms.ListBox listBoxNegative;
        private System.Windows.Forms.ListBox listBoxPositive;
    }
}