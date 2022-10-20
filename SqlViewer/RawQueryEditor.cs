using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadatak.Dal;
using Zadatak.Models;

namespace Zadatak0102
{
    public partial class RawQueryEditor : Form
    {
        SqlRepository sqlRepository;
        public RawQueryEditor()
        {
            InitializeComponent();
            LoadDatabases();
            sqlRepository = new SqlRepository();

        }

        private void LoadDatabases() => cbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                tbError.Text = "";
                var vals = sqlRepository.ExecuteQuery(tbQueryEditor.Text.ToString(), cbDatabases.SelectedValue.ToString(), tbError);

                if (vals == null) {
                    LoadDatabases();
                    return; }
                DataTable dataTable = vals.Tables[0];
                Text = dataTable.TableName;
                dataGridView1.DataSource = dataTable;
            }catch(Exception ex)
            {
                tbError.Text = ex.Message;
            }
        }
    }
}
