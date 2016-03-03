using SampleProject.Presentation.LaunchSitecore.Configuration;
using SampleProject.Presentation.LaunchSitecore.Configuration.SiteUI;
using SampleProject.Presentation.LaunchSitecore.Models;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleProject.Presentation.LaunchSitecore.Controllers
{
  public class VisitController : LaunchSitecoreBaseController
  {
    public ActionResult VisitDetails()
    {
      /* Run the query and show the same view as IconAndTitleList */
      //VisitInformation visit = new VisitInformation();
      return Sitecore.Context.PageMode.IsNormal ? View("VisitDetails", new VisitInformation()) : ShowEditorAlert();
    }

    private ActionResult ShowEditorAlert()
    {
      return View("ShowPageEditorAlert", new PageEditorAlert(PageEditorAlert.Alerts.VisitDetailsNotAllowedInPageEditor));
    }
  }
}
