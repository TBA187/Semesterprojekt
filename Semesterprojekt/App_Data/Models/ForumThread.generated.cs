//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Forum Thread</summary>
	[PublishedContentModel("forumThread")]
	public partial class ForumThread : PublishedContentModel, IForumCategory
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "forumThread";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ForumThread(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ForumThread, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("threadContent")]
		public string ThreadContent
		{
			get { return this.GetPropertyValue<string>("threadContent"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("threadTitle")]
		public string ThreadTitle
		{
			get { return this.GetPropertyValue<string>("threadTitle"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("forumDescription")]
		public string ForumDescription
		{
			get { return Umbraco.Web.PublishedContentModels.ForumCategory.GetForumDescription(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("forumTitle")]
		public string ForumTitle
		{
			get { return Umbraco.Web.PublishedContentModels.ForumCategory.GetForumTitle(this); }
		}
	}
}
