using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCKamp.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        // GET: WriterPanelMessage
        MessageManager mm = new MessageManager(new EfMessageDal());
        MessageValidator messagevalidator = new MessageValidator();
        public ActionResult Inbox()
        {
            string p = (string)Session["WriterMail"];
            var messageValues = mm.GetListInbox(p);
            return View(messageValues);
        }
        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }
        public ActionResult Sendbox()
        {
            string p = (string)Session["WriterMail"];
            var messageValues = mm.GetListSendbox(p);
            return View(messageValues);
        }

        public ActionResult GetInboxMessageDetails(int id)
        {
            var Values = mm.GetByID(id);
            return View(Values);
        }
        public ActionResult GetSendMessageDetails(int id)
        {
            var Values = mm.GetByID(id);
            return View(Values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            string sender = (string)Session["WriterMail"];
            ValidationResult results = messagevalidator.Validate(p);

            if (results.IsValid)
            {
                p.SenderMail = sender;
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.Draft = true;
                mm.MessageAdd(p);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}