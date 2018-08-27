using System;
using System.Drawing;
using System.Web.UI.WebControls;

namespace BootStrapLogInPage
{
    public partial class UserTasks : System.Web.UI.Page
    {
        private static readonly object _syncRoot = new object();
        DataAccess dataAccess = new DataAccess();
        System.Data.DataSet ds;
        int count = 0;
        int userID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            gvbindTasks();
            if (Session["Name"] != null)
            {
                lblLogin.Text = "Hi " + Session["Name"].ToString();
            }

            if (Session["Role"] != null)
            {
                lblLogin.Text += "[" + Session["Role"].ToString() + "]";
            }

            if (Session["UserID"] != null)
            {
                userID = Convert.ToInt32(Session["UserID"].ToString());
            }

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            lock (_syncRoot)
            {
                if (string.IsNullOrEmpty(txtTaskTitle.Text))
                {
                    lblMessage.Text = "Enter task title";
                    lblMessage.ForeColor = Color.Red;
                }
                if (IsTaskExist())
                {
                    MessageBoxUtility.MessageBox(this, "Task added!");
                }
                //else
                //{
                //    lblMessage.Text = "Oops..your taks is already exist!!";
                //    lblMessage.ForeColor = Color.Red;
                //}
            }
        }

        private bool IsTaskExist()
        {

            int result = dataAccess.IsInsertTasks(txtTaskTitle.Text, userID, false);
            if (result > 0)
            {
                MessageBoxUtility.MessageBox(this, "Task added!");
                gvbindTasks();
                return true;
            }
            return false;
        }

        #region Data binding block
        protected void gvbindTasks()
        {
            ds = dataAccess.GetTasks();
            count = ds.Tables[0].Rows.Count;
            if (ds.Tables[0].Rows.Count > 0)
            {
                GVTasks.Visible = true;
                GVTasks.DataSource = ds;
                GVTasks.DataBind();
            }
            else
            {
                GVTasks.Visible = false;
            }
        }

        protected void GVTasks_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)GVTasks.Rows[e.RowIndex];
            int TaskID = Convert.ToInt32(GVTasks.DataKeys[e.RowIndex]["TaskID"]);
            int result = dataAccess.IsDeleteTesk(TaskID, userID);

            if (result > 0)
            {
                MessageBoxUtility.MessageBox(this, "Task deleted!");
                gvbindTasks();
            }
        }

        protected void GVTasks_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GVTasks.EditIndex = e.NewEditIndex;
            gvbindTasks();
        }

        protected void GVTasks_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int TaskID = Convert.ToInt32(GVTasks.DataKeys[e.RowIndex]["TaskID"]);
            string task = ((TextBox)GVTasks.Rows[e.RowIndex].Cells[0].Controls[0]).Text.ToString();
            bool isCompleted = ((CheckBox)GVTasks.Rows[e.RowIndex].Cells[1].Controls[0]).Checked;
            int result = dataAccess.IsUpdateTasks(TaskID, task, userID, isCompleted);

            if (result > 0)
            {
                MessageBoxUtility.MessageBox(this, "Task updated!");
                GVTasks.EditIndex = -1;
                gvbindTasks();
            }
            
        }

        protected void GVTasks_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVTasks.PageIndex = e.NewPageIndex;
            gvbindTasks();
        }

        protected void GVTasks_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GVTasks.EditIndex = -1;
            gvbindTasks();
        }
        #endregion
    }
}