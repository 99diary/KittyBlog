using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace KittyBlog.Model
{
    /// <summary>
    /// 文章
    /// </summary>
    public class Post
    {
        [Key]
        public Int64 ID { get; set; }
        public Int64 AuthorID { get; set; }
        /// <summary>
        /// GMT +0 时间
        /// </summary>
        public Int64 PublishTimeStamp { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        public String Content { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public String Title { get; set; }
        /// <summary>
        /// 摘录
        /// </summary>
        public String Excerpt { get; set; }
        /// <summary>
        /// 文章状态
        /// </summary>
        public EnumPostStatus PostStatus { get;set; }
        /// <summary>
        /// 评论状态
        /// </summary>
        public EnumCommentStatus CommentStatus { get; set; }
        /// <summary>
        /// Ping状态
        /// </summary>
        public EnumPingStatus PingStatus { get; set; }
        /// <summary>
        /// 文章密码
        /// </summary>
        public String PostPassword { get; set; }
        /// <summary>
        /// 文章缩略名
        /// </summary>
        public String ShortName { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public Int64 ModifiedTimeStamp { get; set; }
        /// <summary>
        /// 父文章，主要用于page
        /// </summary>
        public String PostParent { get; set; }
        /// <summary>
        /// Guid
        /// </summary>
        public Guid Guid { get; set; }
        /// <summary>
        /// 排序id
        /// </summary>
        public Int64 MenuOrder { get; set; }
        /// <summary>
        /// 文章类型
        /// </summary>
        public EnumPostType PostType { get; set; }
        /// <summary>
        /// MIME类型
        /// </summary>
        public String PostMimeType { get; set; }
        /// <summary>
        /// 评论总数
        /// </summary>
        public Int64 CommentCount { get; set; }
    }
}


public enum EnumPostStatus
{
    Publish = 0,
    AutoDraft = 1,
    Inherit = 2
}
public enum EnumCommentStatus
{
    Closed=0,
    Open=1
}
public enum EnumPingStatus
{
    Closed = 0,
    Open = 1
}
public enum EnumPostType
{
    Post = 0,
    Page = 1
}