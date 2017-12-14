using Umbraco.Core;
using Umbraco.Core.Models;

namespace Forum
{

    public class Startup : ApplicationEventHandler
    {

        protected override void ApplicationStarted(UmbracoApplicationBase umbraco, ApplicationContext context)
        {

            // Gets a reference to the section (if already added)
            Section section = context.Services.SectionService.GetByAlias("forum");
            if (section != null) return;

            // Add a new "Forum" section
            context.Services.SectionService.MakeNew("Forum", "forum", "icon-newspaper");

            // Grant all existing users access to the new section
            //context.Services.UserService.AddSectionToAllUsers("forum");

            foreach (var group in ApplicationContext.Current.Services.UserService.GetAllUserGroups())
            {
                group.AddAllowedSection("forum");
            }

        }

    }

}