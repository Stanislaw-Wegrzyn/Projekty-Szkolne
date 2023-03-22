namespace Lista09
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
            this.dataGridViewDefault = new System.Windows.Forms.DataGridView();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxPojemnosc = new System.Windows.Forms.TextBox();
            this.textBoxPrzyspieszenie = new System.Windows.Forms.TextBox();
            this.textBoxSpalanie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefault
            // 
            this.dataGridViewDefault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefault.Location = new System.Drawing.Point(12, 46);
            this.dataGridViewDefault.Name = "dataGridViewDefault";
            this.dataGridViewDefault.RowTemplate.Height = 25;
            this.dataGridViewDefault.Size = new System.Drawing.Size(558, 247);
            this.dataGridViewDefault.TabIndex = 0;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "nazwa marki",
            "nazwa modelu",
            "pojemność silnika",
            "przyspieszenie 0-100",
            "spalanie na 100 km"});
            this.comboBoxSearch.Location = new System.Drawing.Point(416, 12);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(154, 23);
            this.comboBoxSearch.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PlaceholderText = "Wprowadź wartośc jaką chcesz wyszukać";
            this.textBoxSearch.Size = new System.Drawing.Size(398, 23);
            this.textBoxSearch.TabIndex = 2;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(12, 337);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowTemplate.Height = 25;
            this.dataGridViewSearch.Size = new System.Drawing.Size(558, 247);
            this.dataGridViewSearch.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(582, 386);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(214, 62);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(582, 454);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(214, 62);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Usuń";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(582, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(214, 62);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Wyszukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(582, 522);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(214, 62);
            this.buttonRead.TabIndex = 8;
            this.buttonRead.Text = "Odczytaj";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(582, 181);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(214, 23);
            this.textBoxMarka.TabIndex = 9;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(582, 225);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(214, 23);
            this.textBoxModel.TabIndex = 10;
            // 
            // textBoxPojemnosc
            // 
            this.textBoxPojemnosc.Location = new System.Drawing.Point(582, 269);
            this.textBoxPojemnosc.Name = "textBoxPojemnosc";
            this.textBoxPojemnosc.Size = new System.Drawing.Size(214, 23);
            this.textBoxPojemnosc.TabIndex = 11;
            // 
            // textBoxPrzyspieszenie
            // 
            this.textBoxPrzyspieszenie.Location = new System.Drawing.Point(582, 313);
            this.textBoxPrzyspieszenie.Name = "textBoxPrzyspieszenie";
            this.textBoxPrzyspieszenie.Size = new System.Drawing.Size(214, 23);
            this.textBoxPrzyspieszenie.TabIndex = 12;
            // 
            // textBoxSpalanie
            // 
            this.textBoxSpalanie.Location = new System.Drawing.Point(582, 357);
            this.textBoxSpalanie.Name = "textBoxSpalanie";
            this.textBoxSpalanie.Size = new System.Drawing.Size(214, 23);
            this.textBoxSpalanie.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Spalanie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Przyspieszenie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pojemność";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "DODAJ NOWY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 608);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSpalanie);
            this.Controls.Add(this.textBoxPrzyspieszenie);
            this.Controls.Add(this.textBoxPojemnosc);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.dataGridViewDefault);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewDefault;
        private ComboBox comboBoxSearch;
        private TextBox textBoxSearch;
        private DataGridView dataGridViewSearch;
        private Button buttonAdd;
        private Button buttonDel;
        private Button buttonSearch;
        private Button buttonRead;
        private TextBox textBoxMarka;
        private TextBox textBoxModel;
        private TextBox textBoxPojemnosc;
        private TextBox textBoxPrzyspieszenie;
        private TextBox textBoxSpalanie;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}