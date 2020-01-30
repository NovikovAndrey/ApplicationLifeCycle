using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycle
{
    public partial class Default : System.Web.UI.Page
    {
        

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write(PrepareMessage("Page_PreInit"));
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write(PrepareMessage("Page_Init"));
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write(PrepareMessage("Page_InitComplete"));
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write(PrepareMessage("Page_PreLoad"));
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(PrepareMessage("Page_Load"));
        }
        protected void TestButton_Click(object sender, EventArgs e)
        {
            Response.Write(PrepareEmphasizedMessage("ButtonClick"));
        }
        
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write(PrepareMessage("Page_LoadCmplete"));
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write(PrepareMessage("Page_Prerender"));
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write(PrepareMessage("Page_PreRenderComplete"));
        }
        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            Response.Write(PrepareMessage("Page_SaveStateComplete"));
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            //Response.Write(PrepareMessage("Page_Unload"));
        }

        #region Help Methods
        private string PrepareMessage(string v)
        {
            return string.Format("<div style='background-color:lightgreen; border:1px solid black;'>{0}</div><br/>", v);
        }
        private string PrepareEmphasizedMessage(string v)
        {
            return string.Format("<div style='background-color:purple; border:1px solid black;'>{0}</div><br/>", v);
        }
        #endregion
    }
}