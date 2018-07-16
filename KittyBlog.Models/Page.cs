using System;
using System.Collections.Generic;
using System.Text;

namespace KittyBlog.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Page
    {
        public Boolean Success { get; set; }
        public EnumCode Code { get; set; }
        public Object Data { get; set; }
    }

    /// <summary>
    /// 错误码
    /// </summary>
    public enum EnumCode
    {
        Success=10001,
        NoAccess=20001,
        DataError=20002,
        LackParam=30001
    }
}
