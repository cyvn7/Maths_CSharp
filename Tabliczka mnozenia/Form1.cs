using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabliczka_mnozenia
{
    public partial class Tabliczka_Mnozenia : Form
    {

        public Tabliczka_Mnozenia()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            start.Visible = false;
        }
    }
}
