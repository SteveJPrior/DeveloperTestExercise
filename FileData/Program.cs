using System;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("usage: this functionality filename");
                return 1;
            }

            var functionality = args[0];
            var filename = args[1];

            var details = new FileDetails();

            var parser = new MainArgParser();
            if (parser.IsSize(functionality))
            {
                var size = details.Size(filename);
                Console.WriteLine($"Size: {size}");
            }
            else if (parser.IsVersion(functionality))
            {
                var version = details.Version(filename);
                Console.WriteLine($"Version: {version}");
            }
            else
            {
                Console.WriteLine("Functionality unknown");
                return 2;
            }

            return 0;
        }
    }
}
