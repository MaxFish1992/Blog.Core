using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Model.Models
{
    /// <summary>
    /// 功能描述    ：博客文章  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/11/23 16:12:00 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/11/23 16:12:00 
    /// </summary>
    public class BlogArticle
    {
        /// <summary>
        /// 
        /// </summary>
        public int bID { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string bsubmitter { get; set; }

        /// <summary>
        /// 博客标题
        /// </summary>
        public string btitle { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public string bcategory { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string bcontent { get; set; }

        /// <summary>
        /// 访问量
        /// </summary>
        public int btraffic { get; set; }

        /// <summary>
        /// 评论数量
        /// </summary>
        public int bcommentNum { get; set; }

        /// <summary> 
        /// 修改时间
        /// </summary>
        public DateTime bUpdateTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime bCreateTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string bRemark { get; set; }
    }
}
