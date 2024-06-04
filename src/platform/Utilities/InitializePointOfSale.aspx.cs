using System;

namespace XmCloudSXAStarter.Utilities
{
    public partial class InitializePointOfSale : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (new Sitecore.SecurityModel.SecurityDisabler())
            {
                var item = Sitecore.Context.Database.GetItem("/sitecore/content/Verticals/Financial/Settings/Site Grouping/Financial");
                using (new Sitecore.Data.Items.EditContext(item))
                {
                    item["__Updated by"] = "sitecore\\Admin";
                }

                Response.Write("Success!");
            }
        }
    }
}
