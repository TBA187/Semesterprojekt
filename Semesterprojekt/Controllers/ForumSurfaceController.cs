using Umbraco.Web.Mvc;
using System.Web.Mvc;
using Semesterprojekt.Models;
using System.Net.Mail;

namespace Semesterprojekt.Controllers
{
    public class ForumSurfaceController : SurfaceController
    {
        public const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/Forum/";

        public ActionResult RenderForum()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Forum.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForum(Forum model)
        {
            if (ModelState.IsValid)
            {
                SendEmail(model);
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();
        }
      
        private void SendEmail(Forum model)
        {
            MailMessage message = new MailMessage(model.forumTitle, "info@alphajob.dk");
            message.Subject = string.Format("Enquiry from {0} {1}", model.forumTitle, model.forumSubject);
            message.Body = "sdflkhsdkjlfnd ksldj fkjsd fk";
            SmtpClient client = new SmtpClient("127.0.0.1", 25);
            client.Send(message);
        }
    }
}