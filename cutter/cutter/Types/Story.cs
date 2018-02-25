using cutter.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cutter.Types
{
    public class Story
    {
        /// <summary>
        /// The username of the story's author.
        /// </summary>
        public string by { get; set; }

        /// <summary>
        /// The total comment count.
        /// </summary>
        public int descendents { get; set; }

        /// <summary>
        /// the story's unique id.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// The ids of the story's comments, in ranked display order.
        /// </summary>
        public int[] kids { get; set; }

        /// <summary>
        /// The story's score.
        /// </summary>
        public int score { get; set; }

        /// <summary>
        /// Creation date of the story, in Unix Time.
        /// </summary>
        public long time { get; set; }

        /// <summary>
        /// The title of the story.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// The type of item: "story".
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// The URL of the story.
        /// </summary>
        public string url { get; set; }
    }
}
