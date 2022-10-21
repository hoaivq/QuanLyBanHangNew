using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HControl
{
    public partial class hForm : Form
    {
        public hForm()
        {
            InitializeComponent();
        }

        private void hForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public virtual void LoadData() { }
    }
}
