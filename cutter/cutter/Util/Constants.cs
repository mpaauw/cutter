using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cutter.Util
{
    public class Constants
    {
        public const string URL_SCHEME = "https:/";
        public const string URL_HOST = "hacker-news.firebaseio.com";
        public const string URL_PATH = "v0";
        public const string URL_FORMAT = ".json";

        public const string PATH_ITEM = "item";
        public const string PATH_USER = "user";
        public const string PATH_MAX_ITEM = "maxitem";

        public const string PATH_TOP_STORIES = "topstories";
        public const string PATH_NEW_STORIES = "newstories";
        public const string PATH_BEST_STORIES = "beststories";
        public const string PATH_ASK_STORIES = "askstories";
        public const string PATH_SHOW_STORIES = "showstories";
        public const string PATH_JOB_STORIES = "jobstories";

        public const string ITEM_TYPE_JOB = "job";
        public const string ITEM_TYPE_STORY = "story";
        public const string ITEM_TYPE_COMMENT = "comment";
        public const string ITEM_TYPE_POLL = "poll";
        public const string ITEM_TYPE_POLLOPT = "pollopt";

        public const string HTTP_EXCEPTION_GENERIC = "HttpException encountered.";
    }
}
