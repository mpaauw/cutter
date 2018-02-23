using cutter.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cutter.Types
{
    public class Poll
    {
        /// <summary>
        /// The username of the item's author.
        /// </summary>
        public string by { get; set; }

        /// <summary>
        /// In the case of stories or polls, the total comment count.
        /// </summary>
        public int descendants { get; set; }

        /// <summary>
        /// The item's unique id.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// The ids of the item's comments, in ranked display order.
        /// </summary>
        public int[] kids { get; set; }

        /// <summary>
        /// A list of related pollopts, in display order.
        /// </summary>
        public int[] parts { get; set; }

        /// <summary>
        /// The story's score, or the votes for a pollopt.
        /// </summary>
        public int score { get; set; }

        /// <summary>
        /// The comment, story or poll text. HTML.
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Creation date of the item, in Unix Time.
        /// </summary>
        public long time { get; set; }

        /// <summary>
        /// The title of the story, poll or job.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// The type of item: "poll".
        /// </summary>
        public const string type = Constants.ITEM_TYPE_POLL;
    }
}
