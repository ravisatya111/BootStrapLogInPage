using System.Web.UI;

namespace BootStrapLogInPage
{
    public class MessageBoxUtility
    {
        public static void MessageBox(Page page, string strMsg)
        {
            ScriptManager.RegisterClientScriptBlock(page, page.GetType(), "alertMessage", "alert('" + strMsg +"')", true);

        }
    }
}