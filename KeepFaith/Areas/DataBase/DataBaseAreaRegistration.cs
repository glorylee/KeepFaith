using System.Web.Mvc;

namespace KeepFaith.Areas.DataBase
{
    public class DataBaseAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "DataBase";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "DataBase_default",
                "DataBase/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
