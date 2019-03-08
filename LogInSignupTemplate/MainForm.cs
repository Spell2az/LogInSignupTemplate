using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInSignupTemplate
{
    public partial class MainForm : Form
    {
        public event EventHandler LogoutHandler;
        protected virtual void OnLogout(EventArgs e)
        {
            EventHandler handler = LogoutHandler;
            handler?.Invoke(this, e);
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            OnLogout(EventArgs.Empty);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var random = new Random();
            var tabControl = (TabControl)sender;
            if (tabControl.SelectedTab.Text == "Progress")
            {
                progressBar.Value = random.Next(0, 100);
            }
        }
    }
}
