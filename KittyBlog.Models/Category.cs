using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KittyBlog.Model
{
    /// <summary>
    /// 分类
    /// </summary>
    public class Category
    {
        [Key]
        /// <summary>
        /// 自增唯一ID
        /// </summary>
        public Int64 ID { get; set; }
        /// <summary>
        /// 分类名
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 缩微名
        /// </summary>
        public string Slug { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Describe { get; set; }
        /// <summary>
        /// 分类密码
        /// </summary>
        public String CategoryPassword { get; set; }
    }
}
