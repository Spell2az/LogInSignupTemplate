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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public event EventHandler SignupFormHandler;

        protected virtual void OnSignupHandler(EventArgs e)
        {
            EventHandler handler = SignupFormHandler;
            handler?.Invoke(this, e);
        }

        private void btnShowSignUp_Click(object sender, EventArgs e)
        {
            OnSignupHandler(EventArgs.Empty);
        }
    }
}
