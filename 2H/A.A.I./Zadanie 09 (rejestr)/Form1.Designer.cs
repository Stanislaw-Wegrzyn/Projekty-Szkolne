namespace RejestrSystemowy
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
            this.txt_SubBranch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_CurrentConfig = new System.Windows.Forms.RadioButton();
            this.rb_Users = new System.Windows.Forms.RadioButton();
            this.rb_LocalMachine = new System.Windows.Forms.RadioButton();
            this.rb_CurrentUser = new System.Windows.Forms.RadioButton();
            this.lbl_SubBranch = new System.Windows.Forms.Label();
            this.txt_VariableName = new System.Windows.Forms.TextBox();
            this.lbl_VariableName = new System.Windows.Forms.Label();
            this.txt_VariableValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbox_Variables = new System.Windows.Forms.ListBox();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbox_SubBranch = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SubBranch
            // 
            this.txt_SubBranch.Location = new System.Drawing.Point(9, 157);
            this.txt_SubBranch.Name = "txt_SubBranch";
            this.txt_SubBranch.Size = new System.Drawing.Size(343, 23);
            this.txt_SubBranch.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_CurrentConfig);
            this.groupBox1.Controls.Add(this.rb_Users);
            this.groupBox1.Controls.Add(this.rb_LocalMachine);
            this.groupBox1.Controls.Add(this.rb_CurrentUser);
            this.groupBox1.Location = new System.Drawing.Point(358, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Branch";
            // 
            // rb_CurrentConfig
            // 
            this.rb_CurrentConfig.AutoSize = true;
            this.rb_CurrentConfig.Location = new System.Drawing.Point(6, 97);
            this.rb_CurrentConfig.Name = "rb_CurrentConfig";
            this.rb_CurrentConfig.Size = new System.Drawing.Size(158, 19);
            this.rb_CurrentConfig.TabIndex = 3;
            this.rb_CurrentConfig.TabStop = true;
            this.rb_CurrentConfig.Text = "HKEY_CURRENT_CONFIG";
            this.rb_CurrentConfig.UseVisualStyleBackColor = true;
            // 
            // rb_Users
            // 
            this.rb_Users.AutoSize = true;
            this.rb_Users.Location = new System.Drawing.Point(6, 72);
            this.rb_Users.Name = "rb_Users";
            this.rb_Users.Size = new System.Drawing.Size(92, 19);
            this.rb_Users.TabIndex = 2;
            this.rb_Users.TabStop = true;
            this.rb_Users.Text = "HKEY_USERS";
            this.rb_Users.UseVisualStyleBackColor = true;
            // 
            // rb_LocalMachine
            // 
            this.rb_LocalMachine.AutoSize = true;
            this.rb_LocalMachine.Location = new System.Drawing.Point(6, 47);
            this.rb_LocalMachine.Name = "rb_LocalMachine";
            this.rb_LocalMachine.Size = new System.Drawing.Size(155, 19);
            this.rb_LocalMachine.TabIndex = 1;
            this.rb_LocalMachine.TabStop = true;
            this.rb_LocalMachine.Text = "HKEY_LOCAL_MACHINE";
            this.rb_LocalMachine.UseVisualStyleBackColor = true;
            // 
            // rb_CurrentUser
            // 
            this.rb_CurrentUser.AutoSize = true;
            this.rb_CurrentUser.Location = new System.Drawing.Point(6, 22);
            this.rb_CurrentUser.Name = "rb_CurrentUser";
            this.rb_CurrentUser.Size = new System.Drawing.Size(142, 19);
            this.rb_CurrentUser.TabIndex = 0;
            this.rb_CurrentUser.TabStop = true;
            this.rb_CurrentUser.Text = "HKEY_CURRENT_USER";
            this.rb_CurrentUser.UseVisualStyleBackColor = true;
            // 
            // lbl_SubBranch
            // 
            this.lbl_SubBranch.AutoSize = true;
            this.lbl_SubBranch.Location = new System.Drawing.Point(9, 139);
            this.lbl_SubBranch.Name = "lbl_SubBranch";
            this.lbl_SubBranch.Size = new System.Drawing.Size(67, 15);
            this.lbl_SubBranch.TabIndex = 2;
            this.lbl_SubBranch.Text = "Sub Branch";
            // 
            // txt_VariableName
            // 
            this.txt_VariableName.Location = new System.Drawing.Point(98, 184);
            this.txt_VariableName.Name = "txt_VariableName";
            this.txt_VariableName.Size = new System.Drawing.Size(254, 23);
            this.txt_VariableName.TabIndex = 3;
            // 
            // lbl_VariableName
            // 
            this.lbl_VariableName.AutoSize = true;
            this.lbl_VariableName.Location = new System.Drawing.Point(9, 186);
            this.lbl_VariableName.Name = "lbl_VariableName";
            this.lbl_VariableName.Size = new System.Drawing.Size(83, 15);
            this.lbl_VariableName.TabIndex = 4;
            this.lbl_VariableName.Text = "Variable Name";
            // 
            // txt_VariableValue
            // 
            this.txt_VariableValue.Location = new System.Drawing.Point(98, 213);
            this.txt_VariableValue.Name = "txt_VariableValue";
            this.txt_VariableValue.Size = new System.Drawing.Size(254, 23);
            this.txt_VariableValue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Variable Value";
            // 
            // lbox_Variables
            // 
            this.lbox_Variables.FormattingEnabled = true;
            this.lbox_Variables.ItemHeight = 15;
            this.lbox_Variables.Location = new System.Drawing.Point(9, 242);
            this.lbox_Variables.Name = "lbox_Variables";
            this.lbox_Variables.Size = new System.Drawing.Size(343, 184);
            this.lbox_Variables.TabIndex = 7;
            this.lbox_Variables.SelectedIndexChanged += new System.EventHandler(this.lbox_Variables_SelectedIndexChanged);
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(358, 348);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(173, 36);
            this.btn_Read.TabIndex = 8;
            this.btn_Read.Text = "Read Registry";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(358, 390);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(173, 36);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save Registry";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbox_SubBranch
            // 
            this.lbox_SubBranch.FormattingEnabled = true;
            this.lbox_SubBranch.ItemHeight = 15;
            this.lbox_SubBranch.Location = new System.Drawing.Point(9, 12);
            this.lbox_SubBranch.Name = "lbox_SubBranch";
            this.lbox_SubBranch.Size = new System.Drawing.Size(343, 124);
            this.lbox_SubBranch.TabIndex = 10;
            this.lbox_SubBranch.SelectedIndexChanged += new System.EventHandler(this.lbox_SubBranch_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 431);
            this.Controls.Add(this.lbox_SubBranch);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.lbox_Variables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_VariableValue);
            this.Controls.Add(this.lbl_VariableName);
            this.Controls.Add(this.txt_VariableName);
            this.Controls.Add(this.lbl_SubBranch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_SubBranch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_SubBranch;
        private GroupBox groupBox1;
        private RadioButton rb_CurrentConfig;
        private RadioButton rb_Users;
        private RadioButton rb_LocalMachine;
        private RadioButton rb_CurrentUser;
        private Label lbl_SubBranch;
        private TextBox txt_VariableName;
        private Label lbl_VariableName;
        private TextBox txt_VariableValue;
        private Label label1;
        private ListBox lbox_Variables;
        private Button btn_Read;
        private Button btn_Save;
        private ListBox lbox_SubBranch;
    }
}