using System;
using System.Drawing;

namespace BootStrapLogInPage
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                lblMessage.Text = "Enter credentials";
                lblMessage.ForeColor = Color.Red;
            }
            else if (isUserValid())
            {
                lblMessage.Text = "Welcome to our website..!";
                lblMessage.ForeColor = Color.Blue;
                Server.Transfer("Registration.aspx", true);
            }
            else
            {
                lblMessage.Text = "Oops..your credentials are incorrect!!";
                lblMessage.ForeColor = Color.Red;
            }
        }

        private bool isUserValid()
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (String.Equals(txtUserName.Text, "admin") && String.Equals(txtPassword.Text, "admin"))
                return true;
            return false;
        }
    }
}