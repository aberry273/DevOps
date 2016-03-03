using System.Collections.Generic;
using Sitecore.Data.Items;

namespace SampleProject.Presentation.LaunchSitecore.Configuration.AuthoringExperience.PageEditor
{
  public class AlertDictionary : Dictionary<string, string>
  {
    public AlertDictionary()
    {
      foreach (Item item in SiteConfiguration.GetPageEditorAlertsRootItem().Children)
      {
        Add(item["Key"],item["Alert"]);
      }
    }
  }
}