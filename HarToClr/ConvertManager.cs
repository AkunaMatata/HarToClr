using System;
using System.Collections.Generic;
using System.IO;
using ServiceStack;
using ServiceStack.Text;

namespace HarToClr
{
    public class ConvertManager
    {
        public void ExportToCsv<T>(string fileName, IEnumerable<T> items)
        {
            var file = new FileStream(fileName, FileMode.Create);
            file.WriteCsv(items);
        }

        public Har ConvertToHar(string fileName)
        {
            var zzz = new StreamReader(fileName, true).ReadToEnd();
            var replaced = zzz.Replace("\"", "\"");

            var harObject = JsonObject.Parse(replaced).ConvertTo(x => new Har
            {
                Log = x.Object("log").ConvertTo(log => new Log
                {
                    Comment = log.Get("comment"),
                    Creator = log.Object("creator").ConvertTo(creator => new Creator
                    {
                        Comment = creator.Get("comment"),
                        Name = creator.Get("name"),
                        Version = creator.Get("version"),
                    }),
                    Version = log.Get("version"),
                    Entries = log.ArrayObjects("entries").ConvertAll(entry => new RequestEntity
                    {
                        Connection = entry.Get("connection"),
                        Time = entry.Get("time").ToInt(0),
                        StartDateTime = entry.Get("startedDateTime").To<DateTime>(),
                        Request = entry.Object("request").ConvertTo(request => new Request
                        {
                            BodySize = request.Get("bodySize").ToInt(0),
                            HeaderSize = request.Get("headersSize").ToInt(0),
                            HttpVersion =  request.Get("httpVersion"),
                            Method = request.Get("method"),
                            Url = request.Get("url"),
                            PostData = request.Object("postData").ConvertTo(postData => new PostData
                            {
                                MimeType = postData.Get("mimeType"),
                            }),
                            Cookies = request.ArrayObjects("cookies")
                                .ConvertAll(cookie => new KeyValuePair<string, string>(cookie.Get("name"), cookie.Get("value"))),
                            Headers = request.ArrayObjects("headers")
                                .ConvertAll(headers => new KeyValuePair<string, string>(headers.Get("name"), headers.Get("value"))),
                            QueryString = request.ArrayObjects("queryString")
                                .ConvertAll(queryString => new KeyValuePair<string, string>(queryString.Get("name"), queryString.Get("value")))
                        }),
                        Response = entry.Object("response").ConvertTo(response => new Response
                        {
                            BodySize = response.Get("bodySize").ToInt(0),
                            HeaderSize = response.Get("headersSize").ToInt(0),
                            HttpVersion = response.Get("httpVersion"),
                            RedirectUrl = response.Get("redirectURL"),
                            Status = response.Get("status").ToInt(),
                            StatusText = response.Get("statusText"),
                            Cookies = response.ArrayObjects("cookies")
                                .ConvertAll(cookie => new KeyValuePair<string, string>(cookie.Get("name"), cookie.Get("value"))),
                            Headers = response.ArrayObjects("headers")
                                .ConvertAll(headers => new KeyValuePair<string, string>(headers.Get("name"), headers.Get("value"))),
                            Content = response.Object("content").ConvertTo(content => new Content
                            {
                                MimeType = content.Get("mimeType"),
                                Encoding = content.Get("encoding"),
                                Size = content.Get("size").ToInt(0),
                                Compression = content.Get("compression").ToInt(0),
                                Text = content.Get("text")
                            })
                        }),
                        Timing = entry.Object("timings").ConvertTo(timing => new Timing
                        {
                            Blocked = timing.Get("blocked").ToInt(0),
                            Connect = timing.Get("connect").ToInt(0),
                            Dns = timing.Get("dns").ToInt(0),
                            Receive = timing.Get("receive").ToInt(0),
                            Send = timing.Get("send").ToInt(0),
                            Ssl = timing.Get("ssl").ToInt(0),
                            Wait = timing.Get("wait").ToInt(0),
                        })
                    })
                })
            });
            return harObject;
        }
    }
}
