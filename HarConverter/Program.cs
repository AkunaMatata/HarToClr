using System.Linq;
using HarToClr;

namespace HarConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new ConvertManager();
            var item = manager.ConvertToHar("D:\\tested.har");
            var logEntires = item.Log.Entries.Select(x => new
            {
                x.Time,
                x.Request.Url,
                x.Request.Method,
                x.Response.Status
            });

            manager.ExportToCsv("testFile.csv", logEntires);
        }
    }
}
