using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleProject.Presentation.LaunchSitecore.Configuration.SiteUI;
using SampleProject.Presentation.LaunchSitecore.Models;
using SampleProject.Presentation.LaunchSitecore.Configuration.SiteUI.Analytics;
using Sitecore.Analytics;
using SampleProject.Presentation.LaunchSitecore.Configuration;

namespace SampleProject.Presentation.LaunchSitecore.Controllers
{
  public class SearchController : LaunchSitecoreBaseController
  {
    [HttpGet]
    public ActionResult Search(string searchStr, string tag)
    {
      return View(new SearchResults("*", new string[] { String.Format("{0}|{1}", SiteConfiguration.GetDictionaryText("Tags"), tag) }));
    }

    [HttpPost]
    public ActionResult Search(string searchStr, string[] facets)
    {
      return View(new SearchResults(searchStr, facets));
    }
  }
}
