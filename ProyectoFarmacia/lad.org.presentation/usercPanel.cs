using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lad.org.presentation
{
    public partial class usercPanel : UserControl
    {
        private static usercPanel _instance;

        public static usercPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usercPanel();
                return _instance;
            }
        }

        public usercPanel()
        {
            InitializeComponent();
        }

        private void usercPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
