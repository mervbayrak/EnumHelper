using System;
using System.Collections.Generic;
using EnumHelper.Classes.Enums.Helper;

namespace EnumHelper.Classes.Enums
{
	public enum Status : sbyte
	{
		Open = 1, 
        	Pending = 2, 
        	InProgress = 3, 
        	Done = 4, 
        	Close = 5
	}

	public class StatusHelper : IEnumHelpers<Status>
	{
	    	static SortedDictionary<Status, String> Enum2String = new SortedDictionary<Status, string>() {
			{ Status.Open,          "Open"          },
			{ Status.Pending,       "Pending"       },
			{ Status.InProgress,    "InProgress"    },
			{ Status.Done,          "Done"          },
			{ Status.Close,         "Close"         },
		};

		static SortedDictionary<String, Status> String2Enum = new SortedDictionary<string, Status>() {
			{ "Open",               Status.Open         },
			{ "Pending",            Status.Pending      },
			{ "InProgress",         Status.InProgress   },
			{ "Done",               Status.Done         },
			{ "Close",              Status.Close        },
		};

        	public String ToString(Status ct)
        	{
        	    return Enum2String[ct];
        	}
        	public static String stToString(Status ct)
        	{
        	    return Enum2String[ct];
        	}
        	public Status GetValue(string t)
        	{
        	    return String2Enum[t];
        	}
        	public static Status stGetValue(string t)
        	{
        	    return String2Enum[t];
        	}
	}
}
