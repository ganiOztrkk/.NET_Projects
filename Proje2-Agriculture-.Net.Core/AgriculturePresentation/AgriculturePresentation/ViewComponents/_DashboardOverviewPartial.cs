using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverviewPartial:ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = c.Employees.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.currentMonthMessage = c.Contacts.Count(x => x.Date.Month == DateTime.Now.Month);

            ViewBag.announcementTrue = c.Announcements.Count(x => x.Status == true);
            ViewBag.announcementFalse = c.Announcements.Count(x => x.Status == false);

            ViewBag.uretimMuduru = c.Employees.Where(x => x.Title == "Üretim Müdürü").Select(y => y.EmployeeName).FirstOrDefault();
            ViewBag.endustriMuhendisi = c.Employees.Where(x => x.Title == "Endüstri Mühendisi").Select(y => y.EmployeeName).FirstOrDefault();
            ViewBag.ziraatMuhendisi = c.Employees.Where(x => x.Title == "Ziraat Mühendisi").Select(y => y.EmployeeName).FirstOrDefault();
            ViewBag.satisPazarlama = c.Employees.Where(x => x.Title == "Satış Pazarlama").Select(y => y.EmployeeName).FirstOrDefault();
            return View();
        }
    }
}
