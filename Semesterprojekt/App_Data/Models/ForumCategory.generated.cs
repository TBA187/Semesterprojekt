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
	// Mixin content Type 1308 with alias "forumCategory"
	/// <summary>Forum Catergory</summary>
	public partial interface IForumCategory : IPublishedContent
	{
		/// <summary>Description</summary>
		string ForumDescription { get; }

		/// <summary>Title</summary>
		string ForumTitle { get; }
	}

	/// <summary>Forum Catergory</summary>
	[PublishedContentModel("forumCategory")]
	public partial class ForumCategory : PublishedContentModel, IForumCategory
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "forumCategory";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ForumCategory(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ForumCategory, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("forumDescription")]
		public string ForumDescription
		{
			get { return GetForumDescription(this); }
		}

		/// <summary>Static getter for Description</summary>
		public static string GetForumDescription(IForumCategory that) { return that.GetPropertyValue<string>("forumDescription"); }

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("forumTitle")]
		public string ForumTitle
		{
			get { return GetForumTitle(this); }
		}

		/// <summary>Static getter for Title</summary>
		public static string GetForumTitle(IForumCategory that) { return that.GetPropertyValue<string>("forumTitle"); }
	}
}
