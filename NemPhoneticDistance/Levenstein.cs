using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Recognition.SrgsGrammar;

namespace NemPhoneticDistance {
  public static class Levenstein {
    public static double GetDistance(string str1, string str2) {
      //Get IPA representation
      string ipa1 = GetIpa(str1);


      throw new NotImplementedException();
    }

    private static string GetIpa(string lexicalStr) {
      SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
      SrgsItem item = new SrgsItem(lexicalStr);
    }
  }
}
