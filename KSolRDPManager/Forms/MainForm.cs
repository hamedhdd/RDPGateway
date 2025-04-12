using System;
using System.Windows.Forms;

namespace KSolRDPManager.Forms
{
    public partial class MainForm : Form
    {
        private Button btnManageUsers;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            btnManageUsers = new Button { Text = "Manage Users", Left = 10, Top = 10, Width = 120 };
            btnManageUsers.Click += BtnManageUsers_Click;
            Controls.Add(btnManageUsers);
            Text = "KSol RDP Manager";
            Width = 400;
            Height = 300;
        }

        private void BtnManageUsers_Click(object sender, EventArgs e)
        {
            var usersForm = new UsersForm();
            usersForm.ShowDialog();
        }
    }
}
