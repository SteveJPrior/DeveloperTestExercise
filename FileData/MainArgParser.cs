using System;

namespace FileData
{
    public class MainArgParser
    {
        public bool IsVersion(string functionality)
        {
            return functionality == "-v";
        }

        public bool IsSize(string functionality)
        {
            return functionality == "-s";
        }
    }
}