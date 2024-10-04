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
    string filePath = @"..\references\wcf.txt";
    string[] lines = File.ReadAllLines(filePath);
    string reference = args["input0"].ToString();
    string arg_userId = args["userId"].ToString();
    string textname = "Westminster Shorter Catechism";
    string commandname = "!wsc"
    int wcf_counter = CPH.GetTwitchUserVarById<int>(arg_userId, "wcf_counter",true);
    //convert this to a hash map
    var referenceMap = new Dictionary<string, int>
    {
      { "1", 0 },
      { "2", 10 },
      { "3", 13 },
      { "4", 21 },
      { "5", 23 },
      { "6", 30 },
      { "7", 36 },
      { "8", 42 },
      { "9", 50 },
      { "10", 55 },
      { "11", 59 },
      { "12", 65 },
      { "13", 66 },
      { "14", 69 },
      { "15", 72 },
      { "16", 78 },
      { "17", 85 },
      { "18", 88 },
      { "19", 92 },
      { "20", 99 },
      { "21", 103 },
      { "22", 111 },
      { "23", 118 },
      { "24", 122 },
      { "25", 128 },
      { "26", 134 },
      { "27", 137 },
      { "28", 142 },
      { "29", 149 },
      { "30", 157 },
      { "31", 161 },
      { "32", 166 },
      { "33", 169 },
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
      { "3.8", 20 },
      { "4.1", 21 },
      { "4.2", 22 },
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
      { "6.6", 35 },
      { "7.1", 36 },
      { "7.2", 37 },
      { "7.3", 38 },
      { "7.4", 39 },
      { "7.5", 40 },
      { "7.6", 41 },
      { "8.1", 42 },
      { "8.2", 43 },
      { "8.3", 44 },
      { "8.4", 45 },
      { "8.5", 46 },
      { "8.6", 47 },
      { "8.7", 48 },
      { "8.8", 49 },
      { "9.1", 50 },
      { "9.2", 51 },
      { "9.3", 52 },
      { "9.4", 53 },
      { "9.5", 54 },
      { "10.1", 55 },
      { "10.2", 56 },
      { "10.3", 57 },
      { "10.4", 58 },
      { "11.1", 59 },
      { "11.2", 60 },
      { "11.3", 61 },
      { "11.4", 62 },
      { "11.5", 63 },
      { "11.6", 64 },
      { "12.1", 65 },
      { "13.1", 66 },
      { "13.2", 67 },
      { "13.3", 68 },
      { "14.1", 69 },
      { "14.2", 70 },
      { "14.3", 71 },
      { "15.1", 72 },
      { "15.2", 73 },
      { "15.3", 74 },
      { "15.4", 75 },
      { "15.5", 76 },
      { "15.6", 77 },
      { "16.1", 78 },
      { "16.2", 79 },
      { "16.3", 80 },
      { "16.4", 81 },
      { "16.5", 82 },
      { "16.6", 83 },
      { "16.7", 84 },
      { "17.1", 85 },
      { "17.2", 86 },
      { "17.3", 87 },
      { "18.1", 88 },
      { "18.2", 89 },
      { "18.3", 90 },
      { "18.4", 91 },
      { "19.1", 92 },
      { "19.2", 93 },
      { "19.3", 94 },
      { "19.4", 95 },
      { "19.5", 96 },
      { "19.6", 97 },
      { "19.7", 98 },
      { "20.1", 99 },
      { "20.2", 100 },
      { "20.3", 101 },
      { "20.4", 102 },
      { "21.1", 103 },
      { "21.2", 104 },
      { "21.3", 105 },
      { "21.4", 106 },
      { "21.5", 107 },
      { "21.6", 108 },
      { "21.7", 109 },
      { "21.8", 110 },
      { "22.1", 111 },
      { "22.2", 112 },
      { "22.3", 113 },
      { "22.4", 114 },
      { "22.5", 115 },
      { "22.6", 116 },
      { "22.7", 117 },
      { "23.1", 118 },
      { "23.2", 119 },
      { "23.3", 120 },
      { "23.4", 121 },
      { "24.1", 122 },
      { "24.2", 123 },
      { "24.3", 124 },
      { "24.4", 125 },
      { "24.5", 126 },
      { "24.6", 127 },
      { "25.1", 128 },
      { "25.2", 129 },
      { "25.3", 130 },
      { "25.4", 131 },
      { "25.5", 132 },
      { "25.6", 133 },
      { "26.1", 134 },
      { "26.2", 135 },
      { "26.3", 136 },
      { "27.1", 137 },
      { "27.2", 138 },
      { "27.3", 139 },
      { "27.4", 140 },
      { "27.5", 141 },
      { "28.1", 142 },
      { "28.2", 143 },
      { "28.3", 144 },
      { "28.4", 145 },
      { "28.5", 146 },
      { "28.6", 147 },
      { "28.7", 148 },
      { "29.1", 149 },
      { "29.2", 150 },
      { "29.3", 151 },
      { "29.4", 152 },
      { "29.5", 153 },
      { "29.6", 154 },
      { "29.7", 155 },
      { "29.8", 156 },
      { "30.1", 157 },
      { "30.2", 158 },
      { "30.3", 159 },
      { "30.4", 160 },
      { "31.1", 161 },
      { "31.2", 162 },
      { "31.3", 163 },
      { "31.4", 164 },
      { "31.5", 165 },
      { "32.1", 166 },
      { "32.2", 167 },
      { "32.3", 168 },
      { "33.1", 169 },
      { "33.2", 170 },
      { "33.3", 171 },
    };
    if (referenceMap.TryGetValue(reference, out int map_var)){
      //Console.WriteLine($"The wcf_counter for reference '{reference}' is: {wcf_counter}");
      //CPH.SendMessage(map_var.ToString());
      wcf_counter = map_var;
    }
    else if (reference == "next"){
      if (wcf_counter != lines.Length - 1)
      wcf_counter++;
    }
    else if (reference == "prev"){
      if (wcf_counter != 0)
      wcf_counter--;
    }
	else if (reference == ""){
      CPH.SendMessage("Instructions: The " + textname + " is formatted in sections. For example " + commandname + " 1 or " + commandname + " 14.2 , use !next to see the next part. If there's a fraction, there's more to the section!", false);
      return true;
    }
    else {
      CPH.SendMessage("The " + textname + " doesn't seem to have a " + reference + ". Try " + commandname + " q1", false);
      return true;
    }
    //CPH.SendMessage(wcf_counter.ToString());
    //CPH.SendMessage(lines.Length.ToString());
    //CPH.SendMessage("Lines length: " + lines.Length.ToString() + " wcf_counter: "+ wcf_counter);
    //lines[wcf_counter].Replace("|", "")
    if (lines[wcf_counter].Length >= 500)
    {
      int chunkSize = 500;
      int stringLength = lines[wcf_counter].Length;
      for (int i = 0; i < stringLength ; i += chunkSize)
      {
        if (i + chunkSize > stringLength) chunkSize = stringLength  - i;
        CPH.SendMessage(lines[wcf_counter].Substring(i, chunkSize),false);
        int milliseconds = 1000;
        Thread.Sleep(milliseconds);
      }

    }
    else
    {
      CPH.SendMessage(lines[wcf_counter], false);
    }
    CPH.SetTwitchUserVarById(arg_userId, "wcf_counter", wcf_counter);
    return true;
  }
}
