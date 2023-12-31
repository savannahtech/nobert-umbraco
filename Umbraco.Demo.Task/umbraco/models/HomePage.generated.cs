//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v12.1.2+9230b25
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Home Page</summary>
	[PublishedModel("homePage")]
	public partial class HomePage : PublishedContentModel, IArticleProperties, IHeaderProperties, ISiteNavigationProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		public new const string ModelTypeAlias = "homePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<HomePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public HomePage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Banner Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callToActionBannerImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops CallToActionBannerImage => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetCallToActionBannerImage(this, _publishedValueFallback);

		///<summary>
		/// Bullet
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callToActionBullet")]
		public virtual global::System.Collections.Generic.IEnumerable<string> CallToActionBullet => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetCallToActionBullet(this, _publishedValueFallback);

		///<summary>
		/// Cover Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callToActionCoverImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops CallToActionCoverImage => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetCallToActionCoverImage(this, _publishedValueFallback);

		///<summary>
		/// Descriptions
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callToActionDescriptions")]
		public virtual string CallToActionDescriptions => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetCallToActionDescriptions(this, _publishedValueFallback);

		///<summary>
		/// Navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callToActionNavigation")]
		public virtual string CallToActionNavigation => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetCallToActionNavigation(this, _publishedValueFallback);

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("callToActionTitle")]
		public virtual string CallToActionTitle => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetCallToActionTitle(this, _publishedValueFallback);

		///<summary>
		/// Faqs
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("faqs")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel Faqs => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetFaqs(this, _publishedValueFallback);

		///<summary>
		/// Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerEmail")]
		public virtual string FooterEmail => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetFooterEmail(this, _publishedValueFallback);

		///<summary>
		/// Fax
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerFax")]
		public virtual string FooterFax => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetFooterFax(this, _publishedValueFallback);

		///<summary>
		/// Location
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerLocation")]
		public virtual string FooterLocation => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetFooterLocation(this, _publishedValueFallback);

		///<summary>
		/// Telephone
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerTelephone")]
		public virtual string FooterTelephone => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetFooterTelephone(this, _publishedValueFallback);

		///<summary>
		/// Button Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerFaqButtonName")]
		public virtual string HeaderFaqButtonName => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetHeaderFaqButtonName(this, _publishedValueFallback);

		///<summary>
		/// Button Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerFaqButtonTitle")]
		public virtual string HeaderFaqButtonTitle => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetHeaderFaqButtonTitle(this, _publishedValueFallback);

		///<summary>
		/// Cover Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerFaqCoverImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops HeaderFaqCoverImage => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetHeaderFaqCoverImage(this, _publishedValueFallback);

		///<summary>
		/// Header Faq Features
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerFaqFeatures")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel HeaderFaqFeatures => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetHeaderFaqFeatures(this, _publishedValueFallback);

		///<summary>
		/// YouTube Video Id
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerFaqYouTubeVideoId")]
		public virtual string HeaderFaqYouTubeVideoId => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetHeaderFaqYouTubeVideoId(this, _publishedValueFallback);

		///<summary>
		/// Post Features
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("postFeatures")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel PostFeatures => global::Umbraco.Cms.Web.Common.PublishedModels.ArticleProperties.GetPostFeatures(this, _publishedValueFallback);

		///<summary>
		/// Page Title: Enter the page title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HeaderProperties.GetPageTitle(this, _publishedValueFallback);

		///<summary>
		/// Main Navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mainNavigation")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.NavigationItem> MainNavigation => global::Umbraco.Cms.Web.Common.PublishedModels.SiteNavigationProperties.GetMainNavigation(this, _publishedValueFallback);
	}
}
