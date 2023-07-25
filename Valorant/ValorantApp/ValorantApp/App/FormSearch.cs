using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorantApp.App
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            FormAcceptedInfo formAcceptedInfo = new FormAcceptedInfo();
            formAcceptedInfo.user = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            formAcceptedInfo.region = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            formAcceptedInfo.rol = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            formAcceptedInfo.dayHour = (dataGridView1.CurrentRow.Cells[4].Value.ToString());
            formAcceptedInfo.ShowDialog();
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            //hay que actualizar el JSON??? 
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            buttonAccept.Enabled = (dataGridView1.SelectedRows.Count == 1) && (dataGridView1.CurrentRow != null) && (dataGridView1.CurrentRow.Index != dataGridView1.Rows.Count - 1);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("a", "b", "c", "d",DateTime.Now.ToString()) ;
        }
    }
}

