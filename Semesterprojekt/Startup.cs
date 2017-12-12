using Umbraco.Core;
using Umbraco.Core.Models;

namespace SkriftDemo {
    
    public class Startup : ApplicationEventHandler {
        
        protected override void ApplicationStarted(UmbracoApplicationBase umbraco, ApplicationContext context) {
            
            // Gets a reference to the section (if already added)
            Section section = context.Services.SectionService.GetByAlias("forum");
            if (section != null) return;

            // Add a new "Skrift Demo" section
            context.Services.SectionService.MakeNew("Skrift Demo", "forum", "icon-newspaper");

            // Grant all existing users access to the new section
            //context.Services.UserService.AddSectionToAllUsers(SkriftConstants.SkriftSectionAlias);

            foreach (var group in ApplicationContext.Current.Services.UserService.GetAllUserGroups())
            {
                group.AddAllowedSection("forum");
            }

        }
    
    }

}