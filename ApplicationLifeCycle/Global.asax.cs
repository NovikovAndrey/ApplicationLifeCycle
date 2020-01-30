using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ApplicationLifeCycle
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Debug.WriteLine("Start");
        }
        protected void Application_End(object sender, EventArgs e)
        {
            Debug.WriteLine("End");
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            Debug.WriteLine("Error");
            Exception ex = Server.GetLastError().GetBaseException();
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Debug.WriteLine("Session Start");
        }
        protected void Session_End(object sender, EventArgs e)
        {
            Debug.WriteLine("Session End");
        }
        /////////////////////////////////////////
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Debug.WriteLine("Begin Request");
        }
        protected void Application_AutantificateRequest(object sender, EventArgs e)
        {
            Debug.WriteLine("Autantificate Request");
        }
        protected void Application_AutorizeRequest(object sender, EventArgs e)
        {
            Debug.WriteLine("Autorize Request");
        }
        protected void Application_ResolveRequestCache(object sender, EventArgs e)
        {
            Debug.WriteLine("Resolve Request Cache");
        }
        protected void Application_AcquireRequestSate(object sender, EventArgs e)
        {
            Debug.WriteLine("AcquireRequestState");
        }
        protected void Application_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            Debug.WriteLine("PreRequestHandlerExecute");
        }
        protected void Application_PostRequestHandlerExecute(object sender, EventArgs e)
        {
            Debug.WriteLine("PostRequestHandlerExecute");
        }
        protected void Application_ReleaseRequestState(object sender, EventArgs e)
        {
            Debug.WriteLine("ReleaseReqquestState");
        }
        protected void Application_UpdaeteRequestCache(object sender, EventArgs e)
        {
            Debug.WriteLine("UpdateRequestCache");
        }
        protected void Application_EndRequst(object sender, EventArgs e)
        {
            Debug.WriteLine("EndRequest");
        }
        
    }
}