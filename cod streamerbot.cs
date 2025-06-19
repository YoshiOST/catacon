using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;

public class CPHInline
{
  public bool Execute()
  {
    // your main code goes here
    //parameter 1
    string filePath = @"C:\cod.txt";
    try
	{
		// Attempt to read all lines from the file
		string[] lines = File.ReadAllLines(filePath);
		string reference = args["input0"].ToString();
		string arg_userId = args["userId"].ToString();
		string textname = "Canons of Dort";
		string commandname = "!cod";
		int cod_counter = CPH.GetTwitchUserVarById<int>(arg_userId, "cod_counter",true);
		//convert this to a hash map
		var referenceMap = new Dictionary<string, int>
		{
			{ "1a1", 0 },
			{ "1a2", 1 },
			{ "1a3", 2 },
			{ "1a4", 3 },
			{ "1a5", 4 },
			{ "1a6", 5 },
			{ "1a7", 6 },
			{ "1a8", 7 },
			{ "1a9", 8 },
			{ "1a10", 9 },
			{ "1a11", 10 },
			{ "1a12", 11 },
			{ "1a13", 12 },
			{ "1a14", 13 },
			{ "1a15", 14 },
			{ "1a16", 15 },
			{ "1a17", 16 },
			{ "1a18", 17 },
			{ "1r1", 18 },
			{ "1r2", 19 },
			{ "1r3", 20 },
			{ "1r4", 21 },
			{ "1r5", 22 },
			{ "1r6", 23 },
			{ "1r7", 24 },
			{ "1r8", 25 },
			{ "1r9", 26 },
			{ "2a1", 27 },
			{ "2a2", 28 },
			{ "2a3", 29 },
			{ "2a4", 30 },
			{ "2a5", 31 },
			{ "2a6", 32 },
			{ "2a7", 33 },
			{ "2a8", 34 },
			{ "2r1", 35 },
			{ "2r2", 36 },
			{ "2r3", 37 },
			{ "2r4", 38 },
			{ "2r5", 39 },
			{ "2r6", 40 },
			{ "2r7", 41 },
			{ "3a1", 42 },
			{ "3a2", 43 },
			{ "3a3", 44 },
			{ "3a4", 45 },
			{ "3a5", 46 },
			{ "3a6", 47 },
			{ "3a7", 48 },
			{ "3a8", 49 },
			{ "3a9", 50 },
			{ "3a10", 51 },
			{ "3a11", 52 },
			{ "3a12", 53 },
			{ "3a13", 54 },
			{ "3a14", 55 },
			{ "3a15", 56 },
			{ "3a16", 57 },
			{ "3a17", 58 },
			{ "3r1", 59 },
			{ "3r2", 60 },
			{ "3r3", 61 },
			{ "3r4", 62 },
			{ "3r5", 63 },
			{ "3r6", 64 },
			{ "3r7", 65 },
			{ "3r8", 66 },
			{ "3r9", 67 },
			{ "4a1", 68 },
			{ "4a2", 69 },
			{ "4a3", 70 },
			{ "4a4", 71 },
			{ "4a5", 72 },
			{ "4a6", 73 },
			{ "4a7", 74 },
			{ "4a8", 75 },
			{ "4a9", 76 },
			{ "4a10", 77 },
			{ "4a11", 78 },
			{ "4a12", 79 },
			{ "4a13", 80 },
			{ "4a14", 81 },
			{ "4a15", 82 },
			{ "4r1", 83 },
			{ "4r2", 84 },
			{ "4r3", 85 },
			{ "4r4", 86 },
			{ "4r5", 87 },
			{ "4r6", 88 },
			{ "4r7", 89 },
			{ "4r8", 90 },
			{ "4r9", 91 },
			{ "5a1", 92 },
			{ "5a2", 93 },
			{ "5a3", 94 },
			{ "1", 95 },
			{ "2", 96 },
			{ "3", 97 },
			{ "4", 98 },
			{ "5", 99 },

		};
		if (referenceMap.TryGetValue(reference, out int map_var)){
		  //Console.WriteLine($"The wcf_counter for reference '{reference}' is: {wcf_counter}");
		  //CPH.SendMessage(map_var.ToString());
		  cod_counter = map_var;
		}
		else if (reference == "next"){
		  if (cod_counter != lines.Length - 1)
		  cod_counter++;
		}
		else if (reference == "prev"){
		  if (cod_counter != 0)
		  cod_counter--;
		}
		else if (reference == ""){
		  CPH.SendMessage("Instructions: The " + textname + " is formatted in sections starting with articles and then rejections. For example " + commandname + " 1a1 or " + commandname + " 1r1 , use !next to see the next part. If there's a fraction, there's more to the section!", false);
		  return true;
		}
		else {
		  CPH.SendMessage("The " + textname + " doesn't seem to have a " + TruncateString(reference,2) + ".... Try " + commandname + " 1a1", false);
		  return true;
		}
		//CPH.SendMessage(wcf_counter.ToString());
		//CPH.SendMessage(lines.Length.ToString());
		//CPH.SendMessage("Lines length: " + lines.Length.ToString() + " wcf_counter: "+ wcf_counter);
		//lines[wcf_counter].Replace("|", "")
		if (lines[cod_counter].Length >= 500)
		{
		  int chunkSize = 500;
		  int stringLength = lines[cod_counter].Length;
		  for (int i = 0; i < stringLength ; i += chunkSize)
		  {
			if (i + chunkSize > stringLength) chunkSize = stringLength  - i;
			CPH.SendMessage(lines[cod_counter].Substring(i, chunkSize),false);
			int milliseconds = 1000;
			Thread.Sleep(milliseconds);
		  }

		}
		else
		{
		  //CPH.SendMessage(lines[cod_counter], false, true);
		  CPH.SendMessage(lines[cod_counter], false);
		}
		CPH.SetTwitchUserVarById(arg_userId, "cod_counter", cod_counter);
		return true;

	}
	catch (FileNotFoundException)
	{
		// Handle case where the file does not exist
		CPH.SendMessage($"Error: The file was not found.", false);
		//Console.WriteLine($"Error: The file '{filePath}' was not found.");
		return true;
	}
  }
  public static string TruncateString(string input, int maxLength)
  {
    if (string.IsNullOrEmpty(input)) return input;
    return input.Length <= maxLength ? input : input.Substring(0, maxLength);
  }
}
