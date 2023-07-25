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
    public partial class FormAcceptedInfo : Form
    {
        public string user { get; set; }
        public string region { get; set; }
        public string rol { get; set; }
        public string dayHour { get; set; }

        public FormAcceptedInfo()
        {
            InitializeComponent();
        }

        private void FormAcceptedInfo_Load(object sender, EventArgs e) 
        {
            textBoxUser.Text = user;
            textBoxRegion.Text = region;
            textBoxRol.Text = rol;
            textBoxDayHour.Text = dayHour;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
