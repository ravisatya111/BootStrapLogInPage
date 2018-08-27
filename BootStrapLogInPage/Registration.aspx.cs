using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace BootStrapLogInPage
{
    public partial class Registration : System.Web.UI.Page
    {
        DataAccess dataAccessObj = new DataAccess();
        private static readonly object _syncRoot = new object();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            lock (_syncRoot)
            {
                if (IsNullEmpty())
                {
                    lblMessage.Text = "Enter your details..!";
                    lblMessage.ForeColor = Color.Red;
                }
                else if (!ValidateEmail())
                {
                    lblMessage.Text = "Oops.. Your email id is incorrect..!";
                    lblMessage.ForeColor = Color.Red;
                }
                if (IsInsertUser())
                {
                    lblMessage.Text = "Your registration is done successfully..!";
                    lblMessage.ForeColor = Color.Blue;
                    Response.Redirect("UserTasks.aspx", true);
                }
                //else
                //{
                //    lblMessage.Text = "Oops.. your email ID is already exist!!";
                //    lblMessage.ForeColor = Color.Red;
                //}
            }
           
        }

        private bool IsNullEmpty()
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtMailID.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUserName.Text) ||
                ddlRoles.SelectedIndex == 0)
                return true;
            return false;
        }

        private bool IsInsertUser()
        {
            int result = dataAccessObj.IsInsertUSers(txtName.Text, txtMailID.Text, txtUserName.Text,
                                            txtPassword.Text, Convert.ToInt32(ddlRoles.SelectedValue));

            if(result > 0)
            {
                Session["UserID"] = result;
                Session["Name"] = txtName.Text;
                Session["Role"] = ddlRoles.SelectedItem.Text;
                return true;
            }
            return false;

        }

        private bool ValidateEmail()
        {
            string email = txtMailID.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}