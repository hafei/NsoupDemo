using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsoupDemo.BLL
{
    /// <summary>
    /// Nsoup 组件类   处理网页html
    /// </summary>
    public class NsoupUtil
    {
        //Url
        private string url = "http://www.topsage.com/";//种子url

        public string Url
        {
            get { return this.url; }
            set { url = value; }
        }

        public NsoupUtil(string url)
        {
            this.url = url;
        }
        //连接Url  获取Document
        /// <summary>
        /// 获取网页Document
        /// </summary>
        /// <returns></returns>
        public NSoup.Nodes.Document GetDocument()
        {
            NSoup.Nodes.Document doc = NSoup.NSoupClient.Connect(this.Url).Get();
            return doc;
        }


    }
}
