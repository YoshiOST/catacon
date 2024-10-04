using System;
using System.IO;
using System.Collections.Generic;

public class CPHInline
{
  public bool Execute()
  {
    // your main code goes here
    //parameter 1
    string filePath = @"..\references\Belgic.txt";
    string[] lines = File.ReadAllLines(filePath);
    string reference = args["input0"].ToString();
    string arg_userId = args["userId"].ToString();
    string textname = "Belgic Confession";
    string commandname = "!bcf";
    int bcf_counter = CPH.GetTwitchUserVarById<int>(arg_userId, "bcf_counter",true);
    //convert this to a hash map
    var referenceMap = new Dictionary<string, int>
    {
      { "1", 0 },
      { "2", 1 },
      { "2.1", 1 },
      { "2.2", 2 },
      { "3", 3 },
      { "3.1", 3 },
      { "3.2", 4 },
      { "4", 5 },
      { "4.1", 5 },
      { "4.2", 6 },
      { "4.3", 7 },
      { "4.4", 8 },
      { "5", 9 },
      { "5.1", 9 },
      { "5.2", 10 },
      { "6", 11 },
      { "6.1", 11 },
      { "6.2", 12 },
      { "7", 13 },
      { "7.1", 13 },
      { "7.2", 14 },
      { "7.3", 15 },
      { "7.4", 16 },
      { "8", 17 },
      { "8.1", 17 },
      { "8.2", 18 },
      { "8.3", 19 },
      { "8.4", 20 },
      { "8.5", 21 },
      { "9", 22 },
      { "9.1", 22 },
      { "9.2", 23 },
      { "9.3", 24 },
      { "9.4", 25 },
      { "9.5", 26 },
      { "9.6", 27 },
      { "9.7", 28 },
      { "9.8", 29 },
      { "10", 30 },
      { "10.1", 30 },
      { "10.2", 31 },
      { "10.3", 32 },
      { "11", 33 },
      { "12", 34 },
      { "12.1", 34 },
      { "12.2", 35 },
      { "12.3", 36 },
      { "12.4", 37 },
      { "13", 38 },
      { "13.1", 38 },
      { "13.2", 39 },
      { "13.3", 40 },
      { "13.4", 41 },
      { "13.5", 42 },
      { "14", 43 },
      { "14.1", 43 },
      { "14.2", 44 },
      { "14.3", 45 },
      { "14.4", 46 },
      { "14.5", 47 },
      { "14.6", 48 },
      { "15", 49 },
      { "15.1", 49 },
      { "15.2", 50 },
      { "15.3", 51 },
      { "16", 52 },
      { "17", 53 },
      { "18", 54 },
      { "18.1", 54 },
      { "18.2", 55 },
      { "18.3", 56 },
      { "18.4", 57 },
      { "18.5", 58 },
      { "19", 59 },
      { "19.1", 59 },
      { "19.2", 60 },
      { "19.3", 61 },
      { "19.4", 62 },
      { "19.5", 63 },
      { "20", 64 },
      { "20.1", 64 },
      { "20.2", 65 },
      { "20.3", 66 },
      { "21", 67 },
      { "21.1", 67 },
      { "21.2", 68 },
      { "21.3", 69 },
      { "21.4", 70 },
      { "22", 71 },
      { "22.1", 71 },
      { "22.2", 72 },
      { "22.3", 73 },
      { "22.4", 74 },
      { "23", 75 },
      { "23.1", 75 },
      { "23.2", 76 },
      { "23.3", 77 },
      { "23.4", 78 },
      { "24", 79 },
      { "24.1", 79 },
      { "24.2", 80 },
      { "24.3", 81 },
      { "24.4", 82 },
      { "25", 83 },
      { "25.1", 83 },
      { "25.2", 84 },
      { "25.3", 85 },
      { "26", 86 },
      { "26.1", 86 },
      { "26.2", 87 },
      { "26.3", 88 },
      { "26.4", 89 },
      { "26.5", 90 },
      { "26.6", 91 },
      { "26.7", 92 },
      { "26.8", 93 },
      { "26.9", 94 },
      { "26.10", 95 },
      { "26.11", 96 },
      { "26.12", 97 },
      { "26.13", 98 },
      { "27", 99 },
      { "27.1", 99 },
      { "27.2", 100 },
      { "27.3", 101 },
      { "27.4", 102 },
      { "28", 103 },
      { "28.1", 103 },
      { "28.2", 104 },
      { "28.3", 105 },
      { "28.4", 106 },
      { "29", 107 },
      { "29.1", 107 },
      { "29.2", 108 },
      { "29.3", 109 },
      { "29.4", 110 },
      { "29.5", 111 },
      { "29.6", 112 },
      { "29.7", 113 },
      { "30", 114 },
      { "30.1", 114 },
      { "30.2", 115 },
      { "30.3", 116 },
      { "30.4", 117 },
      { "31", 118 },
      { "31.1", 118 },
      { "31.2", 119 },
      { "31.3", 120 },
      { "31.4", 121 },
      { "32", 122 },
      { "32.1", 122 },
      { "32.2", 123 },
      { "32.3", 124 },
      { "32.4", 125 },
      { "33", 126 },
      { "33.1", 126 },
      { "33.2", 127 },
      { "33.3", 128 },
      { "33.4", 129 },
      { "34", 130 },
      { "34.1", 130 },
      { "34.2", 131 },
      { "34.3", 132 },
      { "34.4", 133 },
      { "34.5", 134 },
      { "34.6", 135 },
      { "34.7", 136 },
      { "34.8", 137 },
      { "34.9", 138 },
      { "34.10", 139 },
      { "34.11", 140 },
      { "34.12", 141 },
      { "34.13", 142 },
      { "34.14", 143 },
      { "34.15", 144 },
      { "35", 145 },
      { "35.1", 145 },
      { "35.2", 146 },
      { "35.3", 147 },
      { "35.4", 148 },
      { "35.5", 149 },
      { "35.6", 150 },
      { "35.7", 151 },
      { "35.8", 152 },
      { "35.9", 153 },
      { "35.10", 154 },
      { "35.11", 155 },
      { "35.12", 156 },
      { "35.13", 157 },
      { "35.14", 158 },
      { "35.15", 159 },
      { "35.16", 160 },
      { "36", 161 },
      { "36.1", 161 },
      { "36.2", 162 },
      { "36.3", 163 },
      { "36.4", 164 },
      { "37.1", 165 },
      { "37.2", 166 },
      { "37.3", 167 },
      { "37.4", 168 },
      { "37.5", 169 },
      { "37.6", 170 },
    };
    if (referenceMap.TryGetValue(reference, out int map_var)){
      //Console.WriteLine($"The bcf_counter for reference '{reference}' is: {bcf_counter}");
      //CPH.SendMessage(map_var.ToString());
      bcf_counter = map_var;
    }
    else if (reference == "next"){
      if (bcf_counter != lines.Length - 1)
      bcf_counter++;
    }
    else if (reference == "prev"){
      if (bcf_counter != 0)
      bcf_counter--;
    }
    else if (reference == ""){
      CPH.SendMessage("Instructions: The " + textname + " is formatted in sections. For example " + commandname + " 1 or " + commandname + " 4.4 , use !next to see the next part. If there's a fraction, there's more to the section!", false);
      return true;
    }
    else {
      CPH.SendMessage("The " + textname + " doesn't seem to have a " + reference + ". Try " + commandname + " 1 or " + commandname + " 15.2", false);
      return true;
    }
    //CPH.SendMessage(bcf_counter.ToString());
    //CPH.SendMessage(lines.Length.ToString());
    //CPH.SendMessage("Lines length: " + lines.Length.ToString() + " bcf_counter: "+ bcf_counter);
    CPH.SendMessage(lines[bcf_counter].Replace("|", ""), false);
    CPH.SetTwitchUserVarById(arg_userId, "bcf_counter", bcf_counter);
    return true;
  }
}
