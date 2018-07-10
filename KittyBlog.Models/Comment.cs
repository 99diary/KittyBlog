using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace KittyBlog.Model
{
    /// <summary>
    /// 评论
    /// </summary>
    public class Comment
    {
        [Key]
        /// <summary>
        /// 自增唯一ID
        /// </summary>
        public Int64 ID { get; set; }
        /// <summary>
        /// 对应文章ID
        /// </summary>
        public Int64 PostID { get; set; }
        /// <summary>
        /// 评论者
        /// </summary>
        public String Author { get; set; }
        /// <summary>
        /// 评论者邮箱
        /// </summary>
        public String AuthorEmail { get; set; }
        /// <summary>
        /// 评论者网址
        /// </summary>
        public String AuthorUrl { get; set; }
        /// <summary>
        /// 评论者IP
        /// </summary>
        public String AuthorIP { get; set; }
        /// <summary>
        /// 评论时间（GMT+0时间）
        /// </summary>
        public Int64 CommentTimeStamp { get; set; }
        /// <summary>
        /// 评论正文
        /// </summary>
        public String Content { get; set; }
        /// <summary>
        /// 评论是否被批准
        /// </summary>
        public Boolean Approved { get; set; }
        /// <summary>
        /// 评论者的user-agent
        /// </summary>
        public String Agent { get; set; }
        /// <summary>
        /// 评论类型(pingback/普通)
        /// </summary>
        public EnumType Type { get; set; }
        /// <summary>
        /// 父评论ID
        /// </summary>
        public Int64 Parent { get; set; }
        /// <summary>
        /// 评论者用户ID（不一定存在）
        /// </summary>
        public Int64 UserID { get; set; }
    }
}

public enum EnumType
{
    PingBack=0,
    Original=1
}