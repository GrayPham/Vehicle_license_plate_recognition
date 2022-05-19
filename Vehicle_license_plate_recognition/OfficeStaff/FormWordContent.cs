using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_license_plate_recognition.OfficeStaff
{
    public partial class FormWordContent : Form
    {
        public FormWordContent()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }
    }
}
