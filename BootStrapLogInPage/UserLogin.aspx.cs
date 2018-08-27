using System;
using System.Drawing;

namespace BootStrapLogInPage
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                lblMessage.Text = "Enter credentials";
                lblMessage.ForeColor = Color.Red;
            }
            else if (IsUserValid())
            {
                lblMessage.Text = "Welcome to our website..!";
                lblMessage.ForeColor = Color.Blue;
                Server.Transfer("UserTasks.aspx", true);
            }
            else
            {
                lblMessage.Text = "Oops..your credentials are incorrect!!";
                lblMessage.ForeColor = Color.Red;
            }
        }

        private bool IsUserValid()
        {
            DataAccess dataAccess = new DataAccess();
            int result = dataAccess.IsValidUser(txtUserName.Text, txtPassword.Text);
            if (result > 0)
            {
                Session["UserID"] = result;
                Session["Name"] = txtUserName.Text;
                return true;
            }
            return false;
        }
    }
}