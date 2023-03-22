namespace Lista_10___Nuty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnStart = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnRead = new Button();
            btnNutaPauza = new Button();
            btnDlugoscMin = new Button();
            btnDlugoscMax = new Button();
            btnToneUp = new Button();
            btnToneDown = new Button();
            lblLength = new Label();
            lblTone = new Label();
            btnAdd = new Button();
            txtNuta = new TextBox();
            btnRemoveNote = new Button();
            btnKontekstLewo = new Button();
            btnKontekstPrawo = new Button();
            txtUtwor = new TextBox();
            rbLista = new RadioButton();
            rbStos = new RadioButton();
            rbKolejka = new RadioButton();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 41);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(93, 41);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(93, 12);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 3;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            // 
            // btnNutaPauza
            // 
            btnNutaPauza.Location = new Point(279, 12);
            btnNutaPauza.Name = "btnNutaPauza";
            btnNutaPauza.Size = new Size(82, 33);
            btnNutaPauza.TabIndex = 4;
            btnNutaPauza.Text = "Note";
            btnNutaPauza.UseVisualStyleBackColor = true;
            btnNutaPauza.Click += btnNutaPauza_Click;
            // 
            // btnDlugoscMin
            // 
            btnDlugoscMin.Font = new Font("Wingdings 3", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDlugoscMin.Location = new Point(279, 51);
            btnDlugoscMin.Name = "btnDlugoscMin";
            btnDlugoscMin.Size = new Size(38, 33);
            btnDlugoscMin.TabIndex = 5;
            btnDlugoscMin.Text = "3";
            btnDlugoscMin.UseVisualStyleBackColor = true;
            // 
            // btnDlugoscMax
            // 
            btnDlugoscMax.Font = new Font("Wingdings 3", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDlugoscMax.Location = new Point(323, 51);
            btnDlugoscMax.Name = "btnDlugoscMax";
            btnDlugoscMax.Size = new Size(38, 33);
            btnDlugoscMax.TabIndex = 6;
            btnDlugoscMax.Text = "4";
            btnDlugoscMax.UseVisualStyleBackColor = true;
            // 
            // btnToneUp
            // 
            btnToneUp.Font = new Font("Wingdings 3", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnToneUp.Location = new Point(235, 95);
            btnToneUp.Name = "btnToneUp";
            btnToneUp.Size = new Size(38, 33);
            btnToneUp.TabIndex = 7;
            btnToneUp.Text = "5";
            btnToneUp.UseVisualStyleBackColor = true;
            // 
            // btnToneDown
            // 
            btnToneDown.Font = new Font("Wingdings 3", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnToneDown.Location = new Point(235, 134);
            btnToneDown.Name = "btnToneDown";
            btnToneDown.Size = new Size(38, 33);
            btnToneDown.TabIndex = 8;
            btnToneDown.Text = "6";
            btnToneDown.UseVisualStyleBackColor = true;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(229, 59);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(44, 15);
            lblLength.TabIndex = 9;
            lblLength.Text = "Length";
            // 
            // lblTone
            // 
            lblTone.AutoSize = true;
            lblTone.Location = new Point(197, 123);
            lblTone.Name = "lblTone";
            lblTone.Size = new Size(32, 15);
            lblTone.TabIndex = 10;
            lblTone.Text = "Tone";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(198, 176);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 33);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Note";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtNuta
            // 
            txtNuta.Font = new Font("Lassus", 47.99999F, FontStyle.Regular, GraphicsUnit.Point);
            txtNuta.Location = new Point(279, 90);
            txtNuta.Name = "txtNuta";
            txtNuta.ReadOnly = true;
            txtNuta.Size = new Size(82, 76);
            txtNuta.TabIndex = 12;
            txtNuta.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRemoveNote
            // 
            btnRemoveNote.Location = new Point(279, 176);
            btnRemoveNote.Name = "btnRemoveNote";
            btnRemoveNote.Size = new Size(103, 33);
            btnRemoveNote.TabIndex = 13;
            btnRemoveNote.Text = "Remove Note";
            btnRemoveNote.UseVisualStyleBackColor = true;
            // 
            // btnKontekstLewo
            // 
            btnKontekstLewo.Font = new Font("Wingdings 3", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnKontekstLewo.Location = new Point(110, 176);
            btnKontekstLewo.Name = "btnKontekstLewo";
            btnKontekstLewo.Size = new Size(38, 33);
            btnKontekstLewo.TabIndex = 14;
            btnKontekstLewo.Text = "3";
            btnKontekstLewo.UseVisualStyleBackColor = true;
            // 
            // btnKontekstPrawo
            // 
            btnKontekstPrawo.Font = new Font("Wingdings 3", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnKontekstPrawo.Location = new Point(154, 176);
            btnKontekstPrawo.Name = "btnKontekstPrawo";
            btnKontekstPrawo.Size = new Size(38, 33);
            btnKontekstPrawo.TabIndex = 15;
            btnKontekstPrawo.Text = "4";
            btnKontekstPrawo.UseVisualStyleBackColor = true;
            // 
            // txtUtwor
            // 
            txtUtwor.Font = new Font("Lassus", 72F, FontStyle.Regular, GraphicsUnit.Point);
            txtUtwor.Location = new Point(12, 215);
            txtUtwor.Name = "txtUtwor";
            txtUtwor.ReadOnly = true;
            txtUtwor.ScrollBars = ScrollBars.Horizontal;
            txtUtwor.Size = new Size(776, 111);
            txtUtwor.TabIndex = 16;
            // 
            // rbLista
            // 
            rbLista.AutoSize = true;
            rbLista.Location = new Point(37, 22);
            rbLista.Name = "rbLista";
            rbLista.Size = new Size(43, 19);
            rbLista.TabIndex = 17;
            rbLista.TabStop = true;
            rbLista.Text = "List";
            rbLista.UseVisualStyleBackColor = true;
            // 
            // rbStos
            // 
            rbStos.AutoSize = true;
            rbStos.Location = new Point(37, 47);
            rbStos.Name = "rbStos";
            rbStos.Size = new Size(47, 19);
            rbStos.TabIndex = 18;
            rbStos.TabStop = true;
            rbStos.Text = "Stos";
            rbStos.UseVisualStyleBackColor = true;
            // 
            // rbKolejka
            // 
            rbKolejka.AutoSize = true;
            rbKolejka.Location = new Point(37, 72);
            rbKolejka.Name = "rbKolejka";
            rbKolejka.Size = new Size(60, 19);
            rbKolejka.TabIndex = 19;
            rbKolejka.TabStop = true;
            rbKolejka.Text = "Queue";
            rbKolejka.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbLista);
            groupBox1.Controls.Add(rbKolejka);
            groupBox1.Controls.Add(rbStos);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(156, 100);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(465, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 183);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 340);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(txtUtwor);
            Controls.Add(btnKontekstPrawo);
            Controls.Add(btnKontekstLewo);
            Controls.Add(btnRemoveNote);
            Controls.Add(txtNuta);
            Controls.Add(btnAdd);
            Controls.Add(lblTone);
            Controls.Add(lblLength);
            Controls.Add(btnToneDown);
            Controls.Add(btnToneUp);
            Controls.Add(btnDlugoscMax);
            Controls.Add(btnDlugoscMin);
            Controls.Add(btnNutaPauza);
            Controls.Add(btnRead);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnEdit;
        private Button btnSave;
        private Button btnRead;
        private Button btnNutaPauza;
        private Button btnDlugoscMin;
        private Button btnDlugoscMax;
        private Button btnToneUp;
        private Button btnToneDown;
        private Label lblLength;
        private Label lblTone;
        private Button btnAdd;
        private TextBox txtNuta;
        private Button btnRemoveNote;
        private Button btnKontekstLewo;
        private Button btnKontekstPrawo;
        private TextBox txtUtwor;
        private RadioButton rbLista;
        private RadioButton rbStos;
        private RadioButton rbKolejka;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}