//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.ComponentModel.DataAnnotations;

namespace Apps.Models.Sys
{
	public class Virtual_MIS_Article_CategoryModel
	{
		public virtual string Id { get; set; }
		public virtual Nullable<int> ChannelId { get; set; }
		public virtual string Name { get; set; }
		public virtual string ParentId { get; set; }
		public virtual Nullable<int> Sort { get; set; }
		public virtual string ImgUrl { get; set; }
		public virtual string BodyContent { get; set; }
		public virtual Nullable<System.DateTime> CreateTime { get; set; }
		public virtual bool Enable { get; set; }
			
	}

}