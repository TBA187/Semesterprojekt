using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using umbraco.BusinessLogic.Actions;
using Umbraco.Web.Models.Trees;
using Umbraco.Web.Mvc;
using Umbraco.Web.Trees;

namespace Semesterprojekt.Controllers
{
    [PluginController("Forum")]
    [Tree("forum", "ForumTree", "Forum", iconClosed: "icon-doc")]
    public class ForumTreeController : TreeController
    {

        protected override Umbraco.Web.Models.Trees.TreeNodeCollection GetTreeNodes(string id, FormDataCollection queryStrings)
        {
            var nodes = new Umbraco.Web.Models.Trees.TreeNodeCollection();
            var item = this.CreateTreeNode("dashboard", id, queryStrings, "My item", "icon-truck", true);
            nodes.Add(item);
            return nodes;
        }

        protected override Umbraco.Web.Models.Trees.MenuItemCollection GetMenuForNode(string id, FormDataCollection queryStrings)
        {
            var menu = new Umbraco.Web.Models.Trees.MenuItemCollection();
            menu.DefaultMenuAlias = ActionNew.Instance.Alias;
            menu.Items.Add<ActionNew>("Create");
            return menu;
        }
    }
}