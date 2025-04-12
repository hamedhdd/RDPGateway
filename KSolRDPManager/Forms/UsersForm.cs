using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using KSolRDPManager.Data;

namespace KSolRDPManager.Forms
{
    public class UsersForm : Form
    {
        private DataGridView dataGridViewUsers;

        public UsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void InitializeComponent()
        {
            dataGridViewUsers = new DataGridView { Dock = DockStyle.Fill };
            Controls.Add(dataGridViewUsers);
            Text = "Manage Users";
            Width = 800;
            Height = 600;
        }

        private void LoadUsers()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM AspNetUsers", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dataGridViewUsers.DataSource = table;
            }
        }
    }
}
