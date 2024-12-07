using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Mini_Cs
{
    public partial class Service : Form
    {
        private Customers parentForm;
        private DeceasedInfoData deceasedData;
        public Service(Customers parent, DeceasedInfoData data)
        {
            InitializeComponent();
            parentForm = parent;
            deceasedData = data;
        }
    }
}
