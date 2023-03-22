using Microsoft.Win32;
using System.Security;

namespace RejestrSystemowy
{
    public partial class Form1 : Form
    {
        RegistryKey rk = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                rk.OpenSubKey(txt_SubBranch.Text, RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue(txt_VariableName.Text, txt_VariableValue.Text);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Unauthorised Access. You can't acces this key.", "Unauthorised Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int CheckSelectedMainBranch()
        {
            if (rb_CurrentConfig.Checked)
            {
                return 0;
            }
            else if (rb_CurrentUser.Checked)
            {
                return 1;
            }
            else if (rb_LocalMachine.Checked)
            {
                return 2;
            }
            else if (rb_Users.Checked)
            {
                return 3;
            }
            else
            {
                MessageBox.Show("Main Branch Not Selected", "No Main Branch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            lbox_SubBranch.Items.Clear();

            switch (CheckSelectedMainBranch())
            {
                case 0:
                    rk = Registry.CurrentConfig;
                    break;
                case 1:
                    rk = Registry.CurrentUser;
                    break;
                case 2:
                    rk = Registry.LocalMachine;
                    break;
                case 3:
                    rk = Registry.Users;
                    break;
                case -1:
                    return;
            }

            string[] SubKeys = rk.GetSubKeyNames();
            foreach(string s in SubKeys)
            {
                lbox_SubBranch.Items.Add(s);
            }
        }

        private void lbox_SubBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int VariablesCount = 0;
                lbox_Variables.Items.Clear();
                string SubBranch = lbox_SubBranch.Text;
                if (rk.OpenSubKey(SubBranch) == null)
                {
                    return;
                }
                txt_SubBranch.Text = SubBranch;
                RegistryKey SubBranchKey = rk.OpenSubKey(SubBranch);
                string[] SubValues = SubBranchKey.GetValueNames();
                foreach (string s in SubValues)
                {
                    lbox_Variables.Items.Add(s);
                    VariablesCount++;
                }
                if(VariablesCount == 0)
                {
                    lbox_Variables.Items.Add("No Variables");
                }
            }
            catch(SecurityException se)
            {
                MessageBox.Show("Security Error. You can't acces this key.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbox_Variables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbox_Variables.Text == "No Variables")
                {
                    return;
                }
                string VariableName = lbox_Variables.Text;
                string SubBranch = lbox_SubBranch.Text;
                var VariableValue = rk.OpenSubKey(SubBranch).GetValue(VariableName);
                txt_VariableName.Text = VariableName;
                txt_VariableValue.Text = VariableValue.ToString();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}
