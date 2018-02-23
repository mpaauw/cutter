using cutter.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cutter.Types
{
    public class Comment
    {
        /// <summary>
        /// The username of the comment's author.
        /// </summary>
        public string by { get; set; }

        /// <summary>
        /// The comment's unique id.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// The ids of the comment's children, in ranked display order.
        /// </summary>
        public int[] kids { get; set; }

        /// <summary>
        /// The comment's parent: either another comment or the relevant story.
        /// </summary>
        public int parent { get; set; }

        /// <summary>
        /// The comment text. HTML.
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Creation date of the item, in Unix Time.
        /// </summary>
        public long time { get; set; }

        /// <summary>
        /// The type of item: "comment".
        /// </summary>
        public const string type = Constants.ITEM_TYPE_COMMENT;
    }
}
