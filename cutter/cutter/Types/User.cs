using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cutter.Types
{
    public class User
    {
        /// <summary>
        /// The user's unique username. Case-sensitive. Required.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Delay in minutes between a comment's creation and its visibility to other users.
        /// </summary>
        public int delay { get; set; }

        /// <summary>
        /// Creation date of the user, in Unix Time.
        /// </summary>
        public long created { get; set; }

        /// <summary>
        /// The user's karma.
        /// </summary>
        public int karma { get; set; }

        /// <summary>
        /// The user's optional self-description. HTML.
        /// </summary>
        public string about { get; set; }

        /// <summary>
        /// List of the user's stories, polls, and comments.
        /// </summary>
        public int[] submitted { get; set; }
    }
}
