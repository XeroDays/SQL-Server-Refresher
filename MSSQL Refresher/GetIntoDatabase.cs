using DatabaseFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSQL_Refresher
{
    public partial class GetIntoDatabase : Form
    {

        public delegate void sender();
        public event sender formDeActivated;

        #region Events
        
        public GetIntoDatabase()
        {
            InitializeComponent();
        }

        private void GetIntoDatabase_Load(object sender, EventArgs e)
        {
            string linkTempalte = "Data Source="+dataController.datasource+";Initial Catalog="+dataController.dbname+";Integrated Security=true";
            Console.WriteLine(linkTempalte);
            dataController.conLink = linkTempalte;
            label2.Text = dataController.dbname;
            updateTables();
        }

        private void GetIntoDatabase_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (formDeActivated != null)
            {
                formDeActivated();
            }
        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            if (!validation())
            {
                return;
            }

            DialogResult ss = MessageBox.Show("Are you sure you want to Truncate Table?", "Confirm Table Truncating", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ss == DialogResult.Yes)
            {
                foreach (string tablename in getTableNAmes())
                {
                    sysController.truncateTable(tablename);
                }
                MessageBox.Show("Tables Are Successfully Truncated!", "Tables Records Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnReseedIdentity_Click(object sender, EventArgs e)
        {
            if (!validation())
            {
                return;
            }
            DialogResult ss = MessageBox.Show("Are you sure you want to RESEED Table?", "Confirm Table RESEEDING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ss == DialogResult.Yes)
            {
                foreach (string tablename in getTableNAmes())
                {
                    sysController.table_Reseed_Identity(tablename);
                }
                MessageBox.Show("Tables Are successfully Reseeded!", "Tables Records RESEEDED from 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void chkBoxSeelctAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxSeelctAll.Checked)
            {

                selectAllBoxes(true);
            }
            else
            {
                selectAllBoxes(false);
            }
        }
        
        #endregion
        
        #region Methods
        int i = 1;
        private void addnewCheckbox(string name)
        {
            CheckBox box = new System.Windows.Forms.CheckBox();
            this.panel1.Controls.Add(box);
            box.Top = 24 * i;
            box.Left = 15;
            box.Text = name;
            i++;
            
                this.panel1.Height += 16;
                this.Height += 16;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private DataTable getTableName()
        {
            DataTable tbl = new dbServer(dataController.conLink).getQueryList("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = '"+dataController.dbname+"'");
            return tbl;
        }

        private void updateTables()
        {

           
            DataTable table = getTableName();
            foreach (DataRow  row in table.Rows)
            {
                Console.WriteLine(row["table_name"]);
                addnewCheckbox(row["table_name"].ToString());
            }
        }

        private void selectAllBoxes(bool isCheck = true)
        {

            foreach (CheckBox checkbox in panel1.Controls)
            {
                checkbox.Checked = isCheck;
            }
        }
        
        private List<string> getTableNAmes()
        {
            List<string> tblnames = new List<string>();
            foreach (CheckBox chkBox in panel1.Controls)
            {
                if (chkBox.Checked)
                {
                    tblnames.Add(chkBox.Text);
                }
            }

            return tblnames;
        }
        
        private bool validation()
        {
            int count = 0;
            foreach (CheckBox chkBox in panel1.Controls)
            {
                if (chkBox.Checked)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                MessageBox.Show("You must Atleast select One Table.", "Table Not Selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        
        #endregion


    }
}
