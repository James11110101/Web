using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebTest
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //�s�W��L�M�󪺤覡
            //ViewEngines.Engines.Insert(0, new RazorView());
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //Exception last_error = Server.GetLastError();

            //string err_msg = "";
            //if (last_error != null)
            //{
            //    err_msg = last_error.Message;
            //}
            

            ////�Y�����S�����g���󪺿��~�B�z�A�άO�S���^���M��(Server.ClearError)�A�̫�N��ܹw�]���~�e���F�Ϥ��Y���M���h���A���U�@�Ӱ����y�{�C
            //Server.ClearError();

            ////�ɦ^����
            //Response.Redirect("Home/Index");
        }
    }
}
