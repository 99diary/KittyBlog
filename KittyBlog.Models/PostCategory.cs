using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KittyBlog.Model
{
    /// <summary>
    /// post与分类关系表
    /// </summary>
    public class PostCategory
    {
        [Key]
        /// <summary>
        /// 自增
        /// </summary>
        public Int64 ID { get; set; }
        /// <summary>
        /// 对应文章ID
        /// </summary>
        public Int64 PostID { get; set; }
        /// <summary>
        /// 分类ID
        /// </summary>
        public Int64 CategoryID { get; set; }
        /// <summary>
        /// 是否可见
        /// </summary>
        public Boolean Enable { get; set; }
    }
}
