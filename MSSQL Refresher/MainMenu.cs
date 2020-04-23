using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace MSSQL_Refresher
{
    public partial class MainMenu : Form
    {



        public MainMenu()
        {
            InitializeComponent();
            panel1.Visible = false;
            button1.Visible = false;
            cmbDatabases.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDataSource.Text = Environment.MachineName;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
             SQLInstance obi = new SQLInstance();
            //  tryConnectingServer();
        }



        private void tryConnectingServer()
        {
            cmbDatabases.DataSource = null;
            lblLoading.Visible = true;
            DataTable tbll = new DataTable();
            completedCallback callback = new completedCallback(updateCombo);
            ThreadController controller = new ThreadController(callback);
            Thread t1 = new Thread(new ThreadStart(() => controller.getDatabaseNames(txtDataSource.Text.Trim())));
            t1.Start();
        }

        private void updateCombo(DataTable tbl, bool serverAvailible)
        {

            if (serverAvailible)
            {

                MethodInvoker invoker = new MethodInvoker(delegate { ss(tbl); });
                cmbDatabases.Invoke(invoker);
            }
            else
            {
                MethodInvoker invoker = new MethodInvoker(delegate { serverNotAvailible(); });
                panel1.Invoke(invoker);
            }

        }

        private void ss(DataTable tbl)
        {
            lblLoading.Visible = false;
            cmbDatabases.DataSource = tbl;
            cmbDatabases.DisplayMember = "dbname";
            cmbDatabases.ValueMember = "dbname";

        }

        private void serverNotAvailible()
        {
            lblLoading.Visible = false;
            DialogResult ss = MessageBox.Show("Sorry Couldn't Connect to Server.\n Server Maybe is Stopped!", "Server Not Availible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            panel1.Visible = true;
            button1.Visible = true;

        }


        private void cmbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cmbDatabases.SelectedIndex != -1)
            {
                this.Hide();
                dataController.dbname = cmbDatabases.SelectedValue.ToString();
                Console.WriteLine(dataController.dbname);
                GetIntoDatabase obj = new GetIntoDatabase();
                obj.formDeActivated += Obj_formDeActivated;
                obj.Show();
            }
        }

        private void Obj_formDeActivated()
        {
            this.Show();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button1.Visible = false;
            tryConnectingServer();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { 
            tryConnectingServer();
        }
    }
}
