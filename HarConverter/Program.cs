using HarToClr;

namespace HarConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new ConvertManager();
            var item = manager.ConvertToHar("D:\\tested.har");
        }
    }
}
