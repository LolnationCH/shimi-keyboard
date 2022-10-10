public static class KeyboardLayoutConverter
{
  /// <summary>
  /// This method is used to convert a layout code to a layout name.
  /// </summary>
  /// <param name="code">The code to convert</param>
  /// <returns>The name of the layout</returns>
  public static String CodeToName(string code)
  {
    switch (code)
    {
      case "0000041C":
        return "Albanian";
      case "00000401":
        return "Arabic (101)";
      case "00010401":
        return "Arabic (102)";
      case "00020401":
        return "Arabic (102) Azerty";
      case "0000042B":
        return "Armenian eastern";
      case "0001042B":
        return "Armenian Western";
      case "0000044D":
        return "Assamese - inscript";
      case "0000082C":
        return "Azeri Cyrillic";
      case "0000042C":
        return "Azeri Latin";
      case "0000046D":
        return "Bashkir";
      case "00000423":
        return "Belarusian";
      case "0000080C":
        return "Belgian French";
      case "00000813":
        return "Belgian (period)";
      case "0001080C":
        return "Belgian (comma)";
      case "00000445":
        return "Bengali";
      case "00010445":
        return "Bengali - inscript (legacy)";
      case "00020445":
        return "Bengali - inscript";
      case "0000201A":
        return "Bosnian (cyrillic)";
      case "00030402":
        return "Bulgarian";
      case "00000402":
        return "Bulgarian(typewriter)";
      case "00010402":
        return "Bulgarian (latin)";
      case "00020402":
        return "Bulgarian (phonetic)";
      case "00040402":
        return "Bulgarian (phonetic traditional)";
      case "00011009":
        return "Canada Multilingual";
      case "00001009":
        return "Canada French";
      case "00000C0C":
        return "Canada French (legacy)";
      case "00000404":
        return "Chinese (traditional) - us keyboard";
      case "00000804":
        return "Chinese (simplified) -us keyboard";
      case "00000C04":
        return "Chinese (traditional, hong kong s.a.r.) - us keyboard";
      case "00001004":
        return "Chinese (simplified, singapore) - us keyboard";
      case "00001404":
        return "Chinese (traditional, macao s.a.r.) - us keyboard";
      case "00000405":
        return "Czech";
      case "00020405":
        return "Czech programmers";
      case "00010405":
        return "Czech (qwerty)";
      case "0000041A":
        return "Croatian";
      case "00000439":
        return "Deanagari - inscript";
      case "00000406":
        return "Danish";
      case "00000465":
        return "Divehi phonetic";
      case "00010465":
        return "Divehi typewriter";
      case "00000413":
        return "Dutch";
      case "00000425":
        return "Estonian";
      case "00000438":
        return "Faeroese";
      case "0000040B":
        return "Finnish";
      case "0001083B":
        return "Finnish with sami";
      case "0000040C":
        return "French";
      case "00011809":
        return "Gaelic";
      case "00000437":
        return "Georgian";
      case "00020437":
        return "Georgian (ergonomic)";
      case "00010437":
        return "Georgian (qwerty)";
      case "00000407":
        return "German";
      case "00010407":
        return "German (ibm)";
      case "0000046F":
        return "Greenlandic";
      case "00000468":
        return "Hausa";
      case "0000040D":
        return "Hebrew";
      case "00010439":
        return "Hindi traditional";
      case "00000408":
        return "Greek";
      case "00010408":
        return "Greek (220)";
      case "00030408":
        return "Greek (220) latin";
      case "00020408":
        return "Greek (319)";
      case "00040408":
        return "Greek (319) latin";
      case "00050408":
        return "Greek latin";
      case "00060408":
        return "Greek polyonic";
      case "00000447":
        return "Gujarati";
      case "0000040E":
        return "Hungarian";
      case "0001040E":
        return "Hungarian 101 key";
      case "0000040F":
        return "Icelandic";
      case "00000470":
        return "Igbo";
      case "0000085D":
        return "Inuktitut - latin";
      case "0001045D":
        return "Inuktitut - naqittaut";
      case "00001809":
        return "Irish";
      case "00000410":
        return "Italian";
      case "00010410":
        return "Italian (142)";
      case "00000411":
        return "Japanese";
      case "0000044B":
        return "Kannada";
      case "0000043F":
        return "Kazakh";
      case "00000453":
        return "Khmer";
      case "00000412":
        return "Korean";
      case "00000440":
        return "Kyrgyz cyrillic";
      case "00000454":
        return "Lao";
      case "0000080A":
        return "Latin america";
      case "00000426":
        return "Latvian";
      case "00010426":
        return "Latvian (qwerty)";
      case "00010427":
        return "Lithuanian";
      case "00000427":
        return "Lithuanian ibm";
      case "00020427":
        return "Lithuanian standard";
      case "0000046E":
        return "Luxembourgish";
      case "0000042F":
        return "Macedonian (fyrom)";
      case "0001042F":
        return "Macedonian (fyrom) - standard";
      case "0000044C":
        return "Malayalam";
      case "0000043A":
        return "Maltese 47-key";
      case "0001043A":
        return "Maltese 48-key";
      case "0000044E":
        return "Marathi";
      case "00000481":
        return "Maroi";
      case "00000450":
        return "Mongolian cyrillic";
      case "00000850":
        return "Mongolian (mongolian script)";
      case "00000461":
        return "Nepali";
      case "00000414":
        return "Norwegian";
      case "0000043B":
        return "Norwegian with sami";
      case "00000448":
        return "Oriya";
      case "00000463":
        return "Pashto (afghanistan)";
      case "00000429":
        return "Persian";
      case "00000415":
        return "Polish (programmers)";
      case "00010415":
        return "Polish (214)";
      case "00000816":
        return "Portuguese";
      case "00000416":
        return "Portuguese (brazillian abnt)";
      case "00010416":
        return "Portuguese (brazillian abnt2)";
      case "00000446":
        return "Punjabi";
      case "00010418":
        return "Romanian (standard)";
      case "00000418":
        return "Romanian (legacy)";
      case "00020418":
        return "Romanian (programmers)";
      case "00000419":
        return "Russian";
      case "00010419":
        return "Russian (typewriter)";
      case "0002083B":
        return "Sami extended finland-sweden";
      case "0001043B":
        return "Sami extended norway";
      case "00000C1A":
        return "Serbian (cyrillic)";
      case "0000081A":
        return "Serbian (latin)";
      case "0000046C":
        return "Sesotho sa Leboa";
      case "00000432":
        return "Setswana";
      case "0000045B":
        return "Sinhala";
      case "0001045B":
        return "Sinhala -Wij 9";
      case "0000041B":
        return "Slovak";
      case "0001041B":
        return "Slovak (qwerty)";
      case "00000424":
        return "Slovenian";
      case "0001042E":
        return "Sorbian extended";
      case "0002042E":
        return "Sorbian standard";
      case "0000042E":
        return "Sorbian standard (legacy)";
      case "0000040A":
        return "Spanish";
      case "0001040A":
        return "Spanish variation";
      case "0000041D":
        return "Swedish";
      case "0000083B":
        return "Swedish with sami";
      case "00000807":
        return "Swiss german";
      case "0000100C":
        return "Swiss french";
      case "0000045A":
        return "Syriac";
      case "0001045A":
        return "Syriac phonetic";
      case "00000428":
        return "Tajik";
      case "00000449":
        return "Tamil";
      case "00000444":
        return "Tatar";
      case "0000044A":
        return "Telugu";
      case "0000041E":
        return "Thai Kedmanee";
      case "0002041E":
        return "Thai Kedmanee (non-shiftlock)";
      case "0001041E":
        return "Thai Pattachote";
      case "0003041E":
        return "Thai Pattachote (non-shiftlock)";
      case "00000451":
        return "Tibetan (prc)";
      case "0001041F":
        return "Turkish F";
      case "0000041F":
        return "Turkish Q";
      case "00000442":
        return "Turkmen";
      case "00000422":
        return "Ukrainian";
      case "00020422":
        return "Ukrainian (enhanced)";
      case "00000809":
        return "United Kingdom";
      case "00000452":
        return "United Kingdom Extended";
      case "00000409":
        return "United States";
      case "00010409":
        return "United States - dvorak";
      case "00030409":
        return "United States - dvorak left hand";
      case "00050409":
        return "United States - dvorak right hand";
      case "00004009":
        return "United States - india";
      case "00020409":
        return "United States - international";
      case "00000420":
        return "Urdu";
      case "00010480":
        return "Uyghur";
      case "00000480":
        return "Uyghur (legacy)";
      case "00000843":
        return "Uzbek cyrillic";
      case "0000042A":
        return "Vietnamese";
      case "00000485":
        return "Yakut";
      case "0000046A":
        return "Yoruba";
      case "00000488":
        return "Wolof";

      default:
        return "unknown";
    }
  }

  /// <summary>
  /// Returns the code of the keyboard layout for the given keyboard layout name. If the name is not found, we return the name as the code.
  /// </summary>
  /// <param name="name">The name of the keyboard layout.</param>
  /// <returns>The code of the keyboard layout.</returns>
  public static string NameToCode(string name)
  {
    switch (name)
    {
      case "Albanian":
        return "0000041C";
      case "Arabic (101)":
        return "00000401";
      case "Arabic (102)":
        return "00010401";
      case "Arabic (102) Azerty":
        return "00020401";
      case "Armenian eastern":
        return "0000042B";
      case "Armenian Western":
        return "0001042B";
      case "Assamese - inscript":
        return "0000044D";
      case "Azeri Cyrillic":
        return "0000082C";
      case "Azeri Latin":
        return "0000042C";
      case "Bashkir":
        return "0000046D";
      case "Belarusian":
        return "00000423";
      case "Belgian French":
        return "0000080C";
      case "Belgian (period)":
        return "00000813";
      case "Belgian (comma)":
        return "0001080C";
      case "Bengali":
        return "00000445";
      case "Bengali - inscript (legacy)":
        return "00010445";
      case "Bengali - inscript":
        return "00020445";
      case "Bosnian (cyrillic)":
        return "0000201A";
      case "Bulgarian":
        return "00030402";
      case "Bulgarian(typewriter)":
        return "00000402";
      case "Bulgarian (latin)":
        return "00010402";
      case "Bulgarian (phonetic)":
        return "00020402";
      case "Bulgarian (phonetic traditional)":
        return "00040402";
      case "Canada Multilingual":
        return "00011009";
      case "Canada French":
        return "00001009";
      case "Canada French (legacy)":
        return "00000C0C";
      case "Chinese (traditional) - us keyboard":
        return "00000404";
      case "Chinese (simplified) -us keyboard":
        return "00000804";
      case "Chinese (traditional, hong kong s.a.r.) - us keyboard":
        return "00000C04";
      case "Chinese (simplified, singapore) - us keyboard":
        return "00001004";
      case "Chinese (traditional, macao s.a.r.) - us keyboard":
        return "00001404";
      case "Czech":
        return "00000405";
      case "Czech programmers":
        return "00020405";
      case "Czech (qwerty)":
        return "00010405";
      case "Croatian":
        return "0000041A";
      case "Deanagari - inscript":
        return "00000439";
      case "Danish":
        return "00000406";
      case "Divehi phonetic":
        return "00000465";
      case "Divehi typewriter":
        return "00010465";
      case "Dutch":
        return "00000413";
      case "Estonian":
        return "00000425";
      case "Faeroese":
        return "00000438";
      case "Finnish":
        return "0000040B";
      case "Finnish with sami":
        return "0001083B";
      case "French":
        return "0000040C";
      case "Gaelic":
        return "00011809";
      case "Georgian":
        return "00000437";
      case "Georgian (ergonomic)":
        return "00020437";
      case "Georgian (qwerty)":
        return "00010437";
      case "German":
        return "00000407";
      case "German (ibm)":
        return "00010407";
      case "Greenlandic":
        return "0000046F";
      case "Hausa":
        return "00000468";
      case "Hebrew":
        return "0000040D";
      case "Hindi traditional":
        return "00010439";
      case "Greek":
        return "00000408";
      case "Greek (220)":
        return "00010408";
      case "Greek (220) latin":
        return "00030408";
      case "Greek (319)":
        return "00020408";
      case "Greek (319) latin":
        return "00040408";
      case "Greek latin":
        return "00050408";
      case "Greek polyonic":
        return "00060408";
      case "Gujarati":
        return "00000447";
      case "Hungarian":
        return "0000040E";
      case "Hungarian 101 key":
        return "0001040E";
      case "Icelandic":
        return "0000040F";
      case "Igbo":
        return "00000470";
      case "Inuktitut - latin":
        return "0000085D";
      case "Inuktitut - naqittaut":
        return "0001045D";
      case "Irish":
        return "00001809";
      case "Italian":
        return "00000410";
      case "Italian (142)":
        return "00010410";
      case "Japanese":
        return "00000411";
      case "Kannada":
        return "0000044B";
      case "Kazakh":
        return "0000043F";
      case "Khmer":
        return "00000453";
      case "Korean":
        return "00000412";
      case "Kyrgyz cyrillic":
        return "00000440";
      case "Lao":
        return "00000454";
      case "Latin america":
        return "0000080A";
      case "Latvian":
        return "00000426";
      case "Latvian (qwerty)":
        return "00010426";
      case "Lithuanian":
        return "00010427";
      case "Lithuanian ibm":
        return "00000427";
      case "Lithuanian standard":
        return "00020427";
      case "Luxembourgish":
        return "0000046E";
      case "Macedonian (fyrom)":
        return "0000042F";
      case "Macedonian (fyrom) - standard":
        return "0001042F";
      case "Malayalam":
        return "0000044C";
      case "Maltese 47-key":
        return "0000043A";
      case "Maltese 48-key":
        return "0001043A";
      case "Marathi":
        return "0000044E";
      case "Maroi":
        return "00000481";
      case "Mongolian cyrillic":
        return "00000450";
      case "Mongolian (mongolian script)":
        return "00000850";
      case "Nepali":
        return "00000461";
      case "Norwegian":
        return "00000414";
      case "Norwegian with sami":
        return "0000043B";
      case "Oriya":
        return "00000448";
      case "Pashto (afghanistan)":
        return "00000463";
      case "Persian":
        return "00000429";
      case "Polish (programmers)":
        return "00000415";
      case "Polish (214)":
        return "00010415";
      case "Portuguese":
        return "00000816";
      case "Portuguese (brazillian abnt)":
        return "00000416";
      case "Portuguese (brazillian abnt2)":
        return "00010416";
      case "Punjabi":
        return "00000446";
      case "Romanian (standard)":
        return "00010418";
      case "Romanian (legacy)":
        return "00000418";
      case "Romanian (programmers)":
        return "00020418";
      case "Russian":
        return "00000419";
      case "Russian (typewriter)":
        return "00010419";
      case "Sami extended finland-sweden":
        return "0002083B";
      case "Sami extended norway":
        return "0001043B";
      case "Serbian (cyrillic)":
        return "00000C1A";
      case "Serbian (latin)":
        return "0000081A";
      case "Sesotho sa Leboa":
        return "0000046C";
      case "Setswana":
        return "00000432";
      case "Sinhala":
        return "0000045B";
      case "Sinhala -Wij 9":
        return "0001045B";
      case "Slovak":
        return "0000041B";
      case "Slovak (qwerty)":
        return "0001041B";
      case "Slovenian":
        return "00000424";
      case "Sorbian extended":
        return "0001042E";
      case "Sorbian standard":
        return "0002042E";
      case "Sorbian standard (legacy)":
        return "0000042E";
      case "Spanish":
        return "0000040A";
      case "Spanish variation":
        return "0001040A";
      case "Swedish":
        return "0000041D";
      case "Swedish with sami":
        return "0000083B";
      case "Swiss german":
        return "00000807";
      case "Swiss french":
        return "0000100C";
      case "Syriac":
        return "0000045A";
      case "Syriac phonetic":
        return "0001045A";
      case "Tajik":
        return "00000428";
      case "Tamil":
        return "00000449";
      case "Tatar":
        return "00000444";
      case "Telugu":
        return "0000044A";
      case "Thai Kedmanee":
        return "0000041E";
      case "Thai Kedmanee (non-shiftlock)":
        return "0002041E";
      case "Thai Pattachote":
        return "0001041E";
      case "Thai Pattachote (non-shiftlock)":
        return "0003041E";
      case "Tibetan (prc)":
        return "00000451";
      case "Turkish F":
        return "0001041F";
      case "Turkish Q":
        return "0000041F";
      case "Turkmen":
        return "00000442";
      case "Ukrainian":
        return "00000422";
      case "Ukrainian (enhanced)":
        return "00020422";
      case "United Kingdom":
        return "00000809";
      case "United Kingdom Extended":
        return "00000452";
      case "United States":
        return "00000409";
      case "United States - dvorak":
        return "00010409";
      case "United States - dvorak left hand":
        return "00030409";
      case "United States - dvorak right hand":
        return "00050409";
      case "United States - india":
        return "00004009";
      case "United States - international":
        return "00020409";
      case "Urdu":
        return "00000420";
      case "Uyghur":
        return "00010480";
      case "Uyghur (legacy)":
        return "00000480";
      case "Uzbek cyrillic":
        return "00000843";
      case "Vietnamese":
        return "0000042A";
      case "Yakut":
        return "00000485";
      case "Yoruba":
        return "0000046A";
      case "Wolof":
        return "00000488";

      default:
        return name;
    }
  }
}