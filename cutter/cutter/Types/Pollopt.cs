using cutter.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cutter.Types
{
    public class Pollopt
    {
        /// <summary>
        /// The username of the item's author.
        /// </summary>
        public string by { get; set; }

        /// <summary>
        /// The item's unique id.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// The pollopt's associated poll.
        /// </summary>
        public int poll { get; set; }

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
        /// The type of item: "pollopt".
        /// </summary>
        public string type { get; set; }
    }
}
