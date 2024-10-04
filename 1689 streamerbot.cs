using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;

public class CPHInline
{
  public bool Execute()
  {
    // your main code goes here
    //file path ... "@"C:\"
    string filePath = @"..\references\1689lbcf.txt";
    string[] lines = File.ReadAllLines(filePath);
    string reference = args["input0"].ToString();
    string arg_userId = args["userId"].ToString();
    string textname = "1689 London Baptist Confession of Faith";
    string commandname = "!lbcf";
    int lbcf1689_counter = CPH.GetTwitchUserVarById<int>(arg_userId, "lbcf1689_counter",true);
    //convert this to a hash map
    var referenceMap = new Dictionary<string, int>
    {
      { "1", 0 },
      { "2", 10 },
      { "3", 13 },
      { "4", 20 },
      { "5", 23 },
      { "6", 30 },
      { "7", 35 },
      { "8", 38 },
      { "9", 48 },
      { "10", 53 },
      { "11", 57 },
      { "12", 63 },
      { "13", 64 },
      { "14", 67 },
      { "15", 70 },
      { "16", 75 },
      { "17", 82 },
      { "18", 85 },
      { "19", 89 },
      { "20", 96 },
      { "21", 100 },
      { "22", 103 },
      { "23", 111 },
      { "24", 116 },
      { "25", 119 },
      { "26", 123 },
      { "27", 138 },
      { "28", 140 },
      { "29", 142 },
      { "30", 146 },
      { "31", 154 },
      { "32", 157 },
      { "1.1", 0 },
      { "1.2", 1 },
      { "1.3", 2 },
      { "1.4", 3 },
      { "1.5", 4 },
      { "1.6", 5 },
      { "1.7", 6 },
      { "1.8", 7 },
      { "1.9", 8 },
      { "1.10", 9 },
      { "2.1", 10 },
      { "2.2", 11 },
      { "2.3", 12 },
      { "3.1", 13 },
      { "3.2", 14 },
      { "3.3", 15 },
      { "3.4", 16 },
      { "3.5", 17 },
      { "3.6", 18 },
      { "3.7", 19 },
      { "4.1", 20 },
      { "4.2", 21 },
      { "4.3", 22 },
      { "5.1", 23 },
      { "5.2", 24 },
      { "5.3", 25 },
      { "5.4", 26 },
      { "5.5", 27 },
      { "5.6", 28 },
      { "5.7", 29 },
      { "6.1", 30 },
      { "6.2", 31 },
      { "6.3", 32 },
      { "6.4", 33 },
      { "6.5", 34 },
      { "7.1", 35 },
      { "7.2", 36 },
      { "7.3", 37 },
      { "8.1", 38 },
      { "8.2", 39 },
      { "8.3", 40 },
      { "8.4", 41 },
      { "8.5", 42 },
      { "8.6", 43 },
      { "8.7", 44 },
      { "8.8", 45 },
      { "8.9", 46 },
      { "8.10", 47 },
      { "9.1", 48 },
      { "9.2", 49 },
      { "9.3", 50 },
      { "9.4", 51 },
      { "9.5", 52 },
      { "10.1", 53 },
      { "10.2", 54 },
      { "10.3", 55 },
      { "10.4", 56 },
      { "11.1", 57 },
      { "11.2", 58 },
      { "11.3", 59 },
      { "11.4", 60 },
      { "11.5", 61 },
      { "11.6", 62 },
      { "12.1", 63 },
      { "13.1", 64 },
      { "13.2", 65 },
      { "13.3", 66 },
      { "14.1", 67 },
      { "14.2", 68 },
      { "14.3", 69 },
      { "15.1", 70 },
      { "15.2", 71 },
      { "15.3", 72 },
      { "15.4", 73 },
      { "15.5", 74 },
      { "16.1", 75 },
      { "16.2", 76 },
      { "16.3", 77 },
      { "16.4", 78 },
      { "16.5", 79 },
      { "16.6", 80 },
      { "16.7", 81 },
      { "17.1", 82 },
      { "17.2", 83 },
      { "17.3", 84 },
      { "18.1", 85 },
      { "18.2", 86 },
      { "18.3", 87 },
      { "18.4", 88 },
      { "19.1", 89 },
      { "19.2", 90 },
      { "19.3", 91 },
      { "19.4", 92 },
      { "19.5", 93 },
      { "19.6", 94 },
      { "19.7", 95 },
      { "20.1", 96 },
      { "20.2", 97 },
      { "20.3", 98 },
      { "20.4", 99 },
      { "21.1", 100 },
      { "21.2", 101 },
      { "21.3", 102 },
      { "22.1", 103 },
      { "22.2", 104 },
      { "22.3", 105 },
      { "22.4", 106 },
      { "22.5", 107 },
      { "22.6", 108 },
      { "22.7", 109 },
      { "22.8", 110 },
      { "23.1", 111 },
      { "23.2", 112 },
      { "23.3", 113 },
      { "23.4", 114 },
      { "23.5", 115 },
      { "24.1", 116 },
      { "24.2", 117 },
      { "24.3", 118 },
      { "25.1", 119 },
      { "25.2", 120 },
      { "25.3", 121 },
      { "25.4", 122 },
      { "26.1", 123 },
      { "26.2", 124 },
      { "26.3", 125 },
      { "26.4", 126 },
      { "26.5", 127 },
      { "26.6", 128 },
      { "26.7", 129 },
      { "26.8", 130 },
      { "26.9", 131 },
      { "26.10", 132 },
      { "26.11", 133 },
      { "26.12", 134 },
      { "26.13", 135 },
      { "26.14", 136 },
      { "26.15", 137 },
      { "27.1", 138 },
      { "27.2", 139 },
      { "28.1", 140 },
      { "28.2", 141 },
      { "29.1", 142 },
      { "29.2", 143 },
      { "29.3", 144 },
      { "29.4", 145 },
      { "30.1", 146 },
      { "30.2", 147 },
      { "30.3", 148 },
      { "30.4", 149 },
      { "30.5", 150 },
      { "30.6", 151 },
      { "30.7", 152 },
      { "30.8", 153 },
      { "31.1", 154 },
      { "31.2", 155 },
      { "31.3", 156 },
      { "32.1", 157 },
      { "32.2", 158 },
      { "32.3", 159 },
    };
    if (referenceMap.TryGetValue(reference, out int map_var)){
      //Console.WriteLine($"The lbcf1689_counter for reference '{reference}' is: {lbcf1689_counter}");
      //CPH.SendMessage(map_var.ToString());
      lbcf1689_counter = map_var;
    }
    else if (reference == "next"){
      if (lbcf1689_counter != lines.Length - 1)
      lbcf1689_counter++;
    }
    else if (reference == "prev"){
      if (lbcf1689_counter != 0)
      lbcf1689_counter--;
    }
    else if (reference == ""){
      CPH.SendMessage("Instructions: The " + textname + " is formatted in sections. For example " + commandname + " 1 or " + commandname + " 3.2 , use !next to see the next part. If there's a fraction, there's more to the section!", false);
      return true;
    }
    else {
      CPH.SendMessage("The " + textname + " doesn't seem to have a " + TruncateString(reference,2) + ".... Try " + commandname + " 1", false);
      return true;
    }
    // make sure the message is less than 500 characters

    //if line is greater than 500 characters, break up the message.
    if (lines[lbcf1689_counter].Length >= 500)
    {
      int chunkSize = 500;
      int stringLength = lines[lbcf1689_counter].Length;
      for (int i = 0; i < stringLength ; i += chunkSize)
      {
        if (i + chunkSize > stringLength) chunkSize = stringLength  - i;
        CPH.SendMessage(lines[lbcf1689_counter].Substring(i, chunkSize),false);
        int milliseconds = 1000;
        Thread.Sleep(milliseconds);
      }

    }
    else
    {
      CPH.SendMessage(lines[lbcf1689_counter], false);
    }

    //keep track of the latest counter
    CPH.SetTwitchUserVarById(arg_userId, "lbcf1689_counter", lbcf1689_counter);
    return true;
  }
  public static string TruncateString(string input, int maxLength)
  {
    if (string.IsNullOrEmpty(input)) return input;
    return input.Length <= maxLength ? input : input.Substring(0, maxLength);
  }
}
