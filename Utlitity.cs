using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    class Utlitity
    {
        public static UserControl showPage(Panel panel, UserControl content)
        {
            panel.Controls.Clear();
            panel.Controls.Add(content);
            content.Dock = DockStyle.Fill;
            return content;
        }
    }
}
