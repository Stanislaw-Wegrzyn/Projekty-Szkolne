namespace OperacjNaPlikachTekstowych
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.txtFiles = new System.Windows.Forms.TabPage();
            this.txt_fileContent_txt = new System.Windows.Forms.TextBox();
            this.btn_wczytaj_txt = new System.Windows.Forms.Button();
            this.btn_zapisz_txt = new System.Windows.Forms.Button();
            this.XMLfiles = new System.Windows.Forms.TabPage();
            this.treeView = new System.Windows.Forms.TreeView();
            this.btn_zapisz_xml = new System.Windows.Forms.Button();
            this.btn_wczytaj_xml = new System.Windows.Forms.Button();
            this.btn_localization = new System.Windows.Forms.Button();
            this.lbl_adres_txt = new System.Windows.Forms.Label();
            this.txt_lokalizacja = new System.Windows.Forms.TextBox();
            this.rb_txt = new System.Windows.Forms.RadioButton();
            this.rb_xml = new System.Windows.Forms.RadioButton();
            this.tabControl.SuspendLayout();
            this.txtFiles.SuspendLayout();
            this.XMLfiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.txtFiles);
            this.tabControl.Controls.Add(this.XMLfiles);
            this.tabControl.Location = new System.Drawing.Point(12, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(769, 409);
            this.tabControl.TabIndex = 1;
            this.tabControl.TabStop = false;
            // 
            // txtFiles
            // 
            this.txtFiles.Controls.Add(this.txt_fileContent_txt);
            this.txtFiles.Controls.Add(this.btn_wczytaj_txt);
            this.txtFiles.Controls.Add(this.btn_zapisz_txt);
            this.txtFiles.Location = new System.Drawing.Point(4, 22);
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.Padding = new System.Windows.Forms.Padding(3);
            this.txtFiles.Size = new System.Drawing.Size(761, 383);
            this.txtFiles.TabIndex = 0;
            this.txtFiles.Text = "Text";
            this.txtFiles.UseVisualStyleBackColor = true;
            // 
            // txt_fileContent_txt
            // 
            this.txt_fileContent_txt.Location = new System.Drawing.Point(3, 6);
            this.txt_fileContent_txt.Multiline = true;
            this.txt_fileContent_txt.Name = "txt_fileContent_txt";
            this.txt_fileContent_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_fileContent_txt.Size = new System.Drawing.Size(534, 371);
            this.txt_fileContent_txt.TabIndex = 11;
            this.txt_fileContent_txt.TextChanged += new System.EventHandler(this.txt_fileContent_txt_TextChanged);
            // 
            // btn_wczytaj_txt
            // 
            this.btn_wczytaj_txt.Location = new System.Drawing.Point(543, 348);
            this.btn_wczytaj_txt.Name = "btn_wczytaj_txt";
            this.btn_wczytaj_txt.Size = new System.Drawing.Size(212, 29);
            this.btn_wczytaj_txt.TabIndex = 13;
            this.btn_wczytaj_txt.Text = "Wczytaj plik";
            this.btn_wczytaj_txt.UseVisualStyleBackColor = true;
            this.btn_wczytaj_txt.Click += new System.EventHandler(this.btn_wczytaj_txt_Click);
            // 
            // btn_zapisz_txt
            // 
            this.btn_zapisz_txt.Location = new System.Drawing.Point(543, 313);
            this.btn_zapisz_txt.Name = "btn_zapisz_txt";
            this.btn_zapisz_txt.Size = new System.Drawing.Size(212, 29);
            this.btn_zapisz_txt.TabIndex = 14;
            this.btn_zapisz_txt.Text = "Zapisz plik";
            this.btn_zapisz_txt.UseVisualStyleBackColor = true;
            this.btn_zapisz_txt.Click += new System.EventHandler(this.btn_zapisz_txt_Click);
            // 
            // XMLfiles
            // 
            this.XMLfiles.Controls.Add(this.treeView);
            this.XMLfiles.Controls.Add(this.btn_zapisz_xml);
            this.XMLfiles.Controls.Add(this.btn_wczytaj_xml);
            this.XMLfiles.Location = new System.Drawing.Point(4, 22);
            this.XMLfiles.Name = "XMLfiles";
            this.XMLfiles.Padding = new System.Windows.Forms.Padding(3);
            this.XMLfiles.Size = new System.Drawing.Size(761, 383);
            this.XMLfiles.TabIndex = 1;
            this.XMLfiles.Text = "XML";
            this.XMLfiles.UseVisualStyleBackColor = true;
            // 
            // treeView
            // 
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(221, 9);
            this.treeView.Name = "treeView";
            this.treeView.ShowNodeToolTips = true;
            this.treeView.Size = new System.Drawing.Size(534, 371);
            this.treeView.TabIndex = 21;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // btn_zapisz_xml
            // 
            this.btn_zapisz_xml.Location = new System.Drawing.Point(3, 9);
            this.btn_zapisz_xml.Name = "btn_zapisz_xml";
            this.btn_zapisz_xml.Size = new System.Drawing.Size(212, 29);
            this.btn_zapisz_xml.TabIndex = 15;
            this.btn_zapisz_xml.Text = "Zapisz plik";
            this.btn_zapisz_xml.UseVisualStyleBackColor = true;
            this.btn_zapisz_xml.Click += new System.EventHandler(this.btn_zapisz_xml_Click);
            // 
            // btn_wczytaj_xml
            // 
            this.btn_wczytaj_xml.Location = new System.Drawing.Point(3, 44);
            this.btn_wczytaj_xml.Name = "btn_wczytaj_xml";
            this.btn_wczytaj_xml.Size = new System.Drawing.Size(212, 29);
            this.btn_wczytaj_xml.TabIndex = 14;
            this.btn_wczytaj_xml.Text = "Wczytaj plik";
            this.btn_wczytaj_xml.UseVisualStyleBackColor = true;
            this.btn_wczytaj_xml.Click += new System.EventHandler(this.btn_wczytaj_xml_Click);
            // 
            // btn_localization
            // 
            this.btn_localization.Location = new System.Drawing.Point(637, 22);
            this.btn_localization.Name = "btn_localization";
            this.btn_localization.Size = new System.Drawing.Size(35, 20);
            this.btn_localization.TabIndex = 17;
            this.btn_localization.Text = "Plik";
            this.btn_localization.UseVisualStyleBackColor = true;
            this.btn_localization.Click += new System.EventHandler(this.btn_localization_Click);
            // 
            // lbl_adres_txt
            // 
            this.lbl_adres_txt.AutoSize = true;
            this.lbl_adres_txt.Location = new System.Drawing.Point(9, 7);
            this.lbl_adres_txt.Name = "lbl_adres_txt";
            this.lbl_adres_txt.Size = new System.Drawing.Size(88, 13);
            this.lbl_adres_txt.TabIndex = 16;
            this.lbl_adres_txt.Text = "Lokalizacja pliku:";
            // 
            // txt_lokalizacja
            // 
            this.txt_lokalizacja.Enabled = false;
            this.txt_lokalizacja.Location = new System.Drawing.Point(12, 21);
            this.txt_lokalizacja.Name = "txt_lokalizacja";
            this.txt_lokalizacja.Size = new System.Drawing.Size(619, 20);
            this.txt_lokalizacja.TabIndex = 15;
            // 
            // rb_txt
            // 
            this.rb_txt.AutoSize = true;
            this.rb_txt.Checked = true;
            this.rb_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.rb_txt.Location = new System.Drawing.Point(682, 24);
            this.rb_txt.Name = "rb_txt";
            this.rb_txt.Size = new System.Drawing.Size(46, 17);
            this.rb_txt.TabIndex = 18;
            this.rb_txt.TabStop = true;
            this.rb_txt.Text = "Text";
            this.rb_txt.UseVisualStyleBackColor = true;
            this.rb_txt.CheckedChanged += new System.EventHandler(this.rb_txt_CheckedChanged);
            // 
            // rb_xml
            // 
            this.rb_xml.AutoSize = true;
            this.rb_xml.Location = new System.Drawing.Point(734, 24);
            this.rb_xml.Name = "rb_xml";
            this.rb_xml.Size = new System.Drawing.Size(47, 17);
            this.rb_xml.TabIndex = 19;
            this.rb_xml.Text = "XML";
            this.rb_xml.UseVisualStyleBackColor = true;
            this.rb_xml.CheckedChanged += new System.EventHandler(this.rb_xml_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 470);
            this.Controls.Add(this.rb_txt);
            this.Controls.Add(this.rb_xml);
            this.Controls.Add(this.btn_localization);
            this.Controls.Add(this.lbl_adres_txt);
            this.Controls.Add(this.txt_lokalizacja);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.txtFiles.ResumeLayout(false);
            this.txtFiles.PerformLayout();
            this.XMLfiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage txtFiles;
        private System.Windows.Forms.TextBox txt_fileContent_txt;
        private System.Windows.Forms.TabPage XMLfiles;
        private System.Windows.Forms.Button btn_zapisz_xml;
        private System.Windows.Forms.Button btn_wczytaj_xml;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btn_wczytaj_txt;
        private System.Windows.Forms.Button btn_zapisz_txt;
        private System.Windows.Forms.Button btn_localization;
        private System.Windows.Forms.Label lbl_adres_txt;
        private System.Windows.Forms.TextBox txt_lokalizacja;
        private System.Windows.Forms.RadioButton rb_txt;
        private System.Windows.Forms.RadioButton rb_xml;
    }
}

