using System.Web.Mvc;

namespace ProyASAP_Web.Areas.Aerolinea
{
    public class AerolineaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Aerolinea";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Aerolinea_default",
                "Aerolinea/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}