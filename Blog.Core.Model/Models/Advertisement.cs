using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Model.Models
{
    /// <summary>
    /// 功能描述    ：Advertisement  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/22 15:00:16 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/22 15:00:16 
    /// </summary>
    public class Advertisement
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Createdate { get; set; }

        /// <summary>
        /// 广告图片
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 广告标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 广告链接
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
