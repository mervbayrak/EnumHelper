using System;
using EnumHelper.Classes.Enums;
namespace EnumHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            string status= StatusHelper.stToString( Status.Open);   // "Open"
            Status status2 = StatusHelper.stGetValue( "Open" );   // Status.Open
        }
    }
}
