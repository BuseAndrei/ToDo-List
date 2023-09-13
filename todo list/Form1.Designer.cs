namespace todo_list
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
            buton_adaugare = new Button();
            btnVizualizareSarcina = new Button();
            btnEditareSarcina = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            Sarcina = new DataGridViewTextBoxColumn();
            txtDescriereSarcina = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buton_adaugare
            // 
            buton_adaugare.Location = new Point(39, 45);
            buton_adaugare.Name = "buton_adaugare";
            buton_adaugare.Size = new Size(152, 41);
            buton_adaugare.TabIndex = 0;
            buton_adaugare.Text = "Adaugare sacrina";
            buton_adaugare.UseVisualStyleBackColor = true;
            buton_adaugare.Click += button1_Click;
            // 
            // btnVizualizareSarcina
            // 
            btnVizualizareSarcina.Location = new Point(39, 103);
            btnVizualizareSarcina.Name = "btnVizualizareSarcina";
            btnVizualizareSarcina.Size = new Size(152, 33);
            btnVizualizareSarcina.TabIndex = 1;
            btnVizualizareSarcina.Text = "Vizualizare sarcina";
            btnVizualizareSarcina.UseVisualStyleBackColor = true;
            btnVizualizareSarcina.Click += button2_Click;
            // 
            // btnEditareSarcina
            // 
            btnEditareSarcina.Location = new Point(39, 151);
            btnEditareSarcina.Name = "btnEditareSarcina";
            btnEditareSarcina.Size = new Size(152, 52);
            btnEditareSarcina.TabIndex = 2;
            btnEditareSarcina.Text = "Editare sarcina";
            btnEditareSarcina.UseVisualStyleBackColor = true;
            btnEditareSarcina.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(42, 209);
            button4.Name = "button4";
            button4.Size = new Size(149, 37);
            button4.TabIndex = 3;
            button4.Text = "Stergere sarcina";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(44, 267);
            button5.Name = "button5";
            button5.Size = new Size(147, 47);
            button5.TabIndex = 4;
            button5.Text = "Iesire";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Sarcina });
            dataGridView1.Location = new Point(266, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(656, 350);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Sarcina
            // 
            Sarcina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sarcina.HeaderText = "Sarcina";
            Sarcina.MinimumWidth = 6;
            Sarcina.Name = "Sarcina";
            // 
            // txtDescriereSarcina
            // 
            txtDescriereSarcina.Location = new Point(310, 40);
            txtDescriereSarcina.Name = "txtDescriereSarcina";
            txtDescriereSarcina.Size = new Size(199, 27);
            txtDescriereSarcina.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 511);
            Controls.Add(txtDescriereSarcina);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnEditareSarcina);
            Controls.Add(btnVizualizareSarcina);
            Controls.Add(buton_adaugare);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buton_adaugare;
        private Button btnVizualizareSarcina;
        private Button btnEditareSarcina;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private TextBox txtDescriereSarcina;
        private DataGridViewTextBoxColumn Sarcina;
    }
}