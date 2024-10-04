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
    string filePath = @"..\references\wsc.txt";
    string[] lines = File.ReadAllLines(filePath);
    string reference = args["input0"].ToString();
    string arg_userId = args["userId"].ToString();
    string textname = "Westminster Shorter Catechism";
    string commandname = "!wsc";
    int wsc_counter = CPH.GetTwitchUserVarById<int>(arg_userId, "wsc_counter",true);
    //convert this to a hash map
    var referenceMap = new Dictionary<string, int>
    {
      { "q1", 0 },
      { "a1", 1 },
      { "q2", 2 },
      { "a2", 3 },
      { "q3", 4 },
      { "a3", 5 },
      { "q4", 6 },
      { "a4", 7 },
      { "q5", 8 },
      { "a5", 9 },
      { "q6", 10 },
      { "a6", 11 },
      { "q7", 12 },
      { "a7", 13 },
      { "q8", 14 },
      { "a8", 15 },
      { "q9", 16 },
      { "a9", 17 },
      { "q10", 18 },
      { "a10", 19 },
      { "q11", 20 },
      { "a11", 21 },
      { "q12", 22 },
      { "a12", 23 },
      { "q13", 24 },
      { "a13", 25 },
      { "q14", 26 },
      { "a14", 27 },
      { "q15", 28 },
      { "a15", 29 },
      { "q16", 30 },
      { "a16", 31 },
      { "q17", 32 },
      { "a17", 33 },
      { "q18", 34 },
      { "a18", 35 },
      { "q19", 36 },
      { "a19", 37 },
      { "q20", 38 },
      { "a20", 39 },
      { "q21", 40 },
      { "a21", 41 },
      { "q22", 42 },
      { "a22", 43 },
      { "q23", 44 },
      { "a23", 45 },
      { "q24", 46 },
      { "a24", 47 },
      { "q25", 48 },
      { "a25", 49 },
      { "q26", 50 },
      { "a26", 51 },
      { "q27", 52 },
      { "a27", 53 },
      { "q28", 54 },
      { "a28", 55 },
      { "q29", 56 },
      { "a29", 57 },
      { "q30", 58 },
      { "a30", 59 },
      { "q31", 60 },
      { "a31", 61 },
      { "q32", 62 },
      { "a32", 63 },
      { "q33", 64 },
      { "a33", 65 },
      { "q34", 66 },
      { "a34", 67 },
      { "q35", 68 },
      { "a35", 69 },
      { "q36", 70 },
      { "a36", 71 },
      { "q37", 72 },
      { "a37", 73 },
      { "q38", 74 },
      { "a38", 75 },
      { "q39", 76 },
      { "a39", 77 },
      { "q40", 78 },
      { "a40", 79 },
      { "q41", 80 },
      { "a41", 81 },
      { "q42", 82 },
      { "a42", 83 },
      { "q43", 84 },
      { "a43", 85 },
      { "q44", 86 },
      { "a44", 87 },
      { "q45", 88 },
      { "a45", 89 },
      { "q46", 90 },
      { "a46", 91 },
      { "q47", 92 },
      { "a47", 93 },
      { "q48", 94 },
      { "a48", 95 },
      { "q49", 96 },
      { "a49", 97 },
      { "q50", 98 },
      { "a50", 99 },
      { "q51", 100 },
      { "a51", 101 },
      { "q52", 102 },
      { "a52", 103 },
      { "q53", 104 },
      { "a53", 105 },
      { "q54", 106 },
      { "a54", 107 },
      { "q55", 108 },
      { "a55", 109 },
      { "q56", 110 },
      { "a56", 111 },
      { "q57", 112 },
      { "a57", 113 },
      { "q58", 114 },
      { "a58", 115 },
      { "q59", 116 },
      { "a59", 117 },
      { "q60", 118 },
      { "a60", 119 },
      { "q61", 120 },
      { "a61", 121 },
      { "q62", 122 },
      { "a62", 123 },
      { "q63", 124 },
      { "a63", 125 },
      { "q64", 126 },
      { "a64", 127 },
      { "q65", 128 },
      { "a65", 129 },
      { "q66", 130 },
      { "a66", 131 },
      { "q67", 132 },
      { "a67", 133 },
      { "q68", 134 },
      { "a68", 135 },
      { "q69", 136 },
      { "a69", 137 },
      { "q70", 138 },
      { "a70", 139 },
      { "q71", 140 },
      { "a71", 141 },
      { "q72", 142 },
      { "a72", 143 },
      { "q73", 144 },
      { "a73", 145 },
      { "q74", 146 },
      { "a74", 147 },
      { "q75", 148 },
      { "a75", 149 },
      { "q76", 150 },
      { "a76", 151 },
      { "q77", 152 },
      { "a77", 153 },
      { "q78", 154 },
      { "a78", 155 },
      { "q79", 156 },
      { "a79", 157 },
      { "q80", 158 },
      { "a80", 159 },
      { "q81", 160 },
      { "a81", 161 },
      { "q82", 162 },
      { "a82", 163 },
      { "q83", 164 },
      { "a83", 165 },
      { "q84", 166 },
      { "a84", 167 },
      { "q85", 168 },
      { "a85", 169 },
      { "q86", 170 },
      { "a86", 171 },
      { "q87", 172 },
      { "a87", 173 },
      { "q88", 174 },
      { "a88", 175 },
      { "q89", 176 },
      { "a89", 177 },
      { "q90", 178 },
      { "a90", 179 },
      { "q91", 180 },
      { "a91", 181 },
      { "q92", 182 },
      { "a92", 183 },
      { "q93", 184 },
      { "a93", 185 },
      { "q94", 186 },
      { "a94", 187 },
      { "q95", 188 },
      { "a95", 189 },
      { "q96", 190 },
      { "a96", 191 },
      { "q97", 192 },
      { "a97", 193 },
      { "q98", 194 },
      { "a98", 195 },
      { "q99", 196 },
      { "a99", 197 },
      { "q100", 198 },
      { "a100", 199 },
      { "q101", 200 },
      { "a101", 201 },
      { "q102", 202 },
      { "a102", 203 },
      { "q103", 204 },
      { "a103", 205 },
      { "q104", 206 },
      { "a104", 207 },
      { "q105", 208 },
      { "a105", 209 },
      { "q106", 210 },
      { "a106", 211 },
      { "q107", 212 },
      { "a107", 213 },
    };
    if (referenceMap.TryGetValue(reference, out int map_var)){
      //Console.WriteLine($"The wsc_counter for reference '{reference}' is: {wsc_counter}");
      //CPH.SendMessage(map_var.ToString());
      wsc_counter = map_var;
    }
    else if (reference == "next"){
      if (wsc_counter != lines.Length - 1)
      wsc_counter++;
    }
    else if (reference == "prev"){
      if (wsc_counter != 0)
      wsc_counter--;
    }
    else if (reference == ""){
      CPH.SendMessage("Instructions: The " + textname + " is formatted in question and answer form. For example " + commandname + " q1 or " + commandname + " a4 , use !next to see the answer to the question or the next question after.", false);
      return true;
    }
    else {
      CPH.SendMessage("The " + textname + " doesn't seem to have a " + TruncateString(reference,2) + ".... Try " + commandname + " q1", false);
      return true;
    }
    //CPH.SendMessage(wsc_counter.ToString());
    //CPH.SendMessage(lines.Length.ToString());
    //CPH.SendMessage("Lines length: " + lines.Length.ToString() + " wsc_counter: "+ wsc_counter);
    //lines[wsc_counter].Replace("|", "")
    if (lines[wsc_counter].Length >= 500)
    {
      int chunkSize = 500;
      int stringLength = lines[wsc_counter].Length;
      for (int i = 0; i < stringLength ; i += chunkSize)
      {
        if (i + chunkSize > stringLength) chunkSize = stringLength  - i;
        CPH.SendMessage(lines[wsc_counter].Substring(i, chunkSize),false);
        int milliseconds = 1000;
        Thread.Sleep(milliseconds);
      }

    }
    else
    {
      CPH.SendMessage(lines[wsc_counter], false);
    }
    CPH.SetTwitchUserVarById(arg_userId, "wsc_counter", wsc_counter);
    return true;
  }
  public static string TruncateString(string input, int maxLength)
  {
    if (string.IsNullOrEmpty(input)) return input;
    return input.Length <= maxLength ? input : input.Substring(0, maxLength);
  }
}
