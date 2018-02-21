using System;
using System.Collections.Generic;
using System.Text;

namespace cutter.Types
{
    public class Item
    {
        /// <summary>
        /// The item's unique id.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// true if the item is deleted.
        /// </summary>
        public bool deleted { get; set; }

        /// <summary>
        /// The type of item. One of "job", "story", "comment", "poll", or "pollopt".
        /// </summary>
        public ItemType type { get; set; }

        /// <summary>
        /// The username of the item's author.
        /// </summary>
        public string by { get; set; }

        /// <summary>
        /// Creation date of the item, in Unix Time.
        /// </summary>
        public long time { get; set; }

        /// <summary>
        /// The comment, story or poll text. HTML.
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// true if the item is dead
        /// </summary>
        public bool dead { get; set; }

        /// <summary>
        /// The comment's parent: either another comment or the relevant story.
        /// </summary>
        public Item parent { get; set; }

        /// <summary>
        /// The pollopt's associated poll.
        /// </summary>
        public int poll { get; set; }

        /// <summary>
        /// The ids of the item's comments, in ranked display order.
        /// </summary>
        public int[] kids { get; set; }

        /// <summary>
        /// The URL of the story.
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// The story's score, or the votes for a pollopt.
        /// </summary>
        public int score { get; set; }

        /// <summary>
        /// The title of the story, poll or job.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// A list of related pollopts, in display order.
        /// </summary>
        public int[] parts { get; set; }

        /// <summary>
        /// In the case of stories or polls, the total comment count.
        /// </summary>
        public int descendants { get; set; }

    }
}
