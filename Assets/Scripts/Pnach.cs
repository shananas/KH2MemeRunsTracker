using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Pnach : MonoBehaviour
{
    int STTCount = 0;
    int TTCount = 0;
    int HBCount = 0;
    int LoDCount = 0;
    int BCCount = 0;
    int OCCount = 0;
    int DCCount = 0;
    int PRCount = 0;
    int AGCount = 0;
    int HTCount = 0;
    int PLCount = 0;
    int AtlanticaCount = 0;
    int hundredacreCount = 0;
    int SPCount = 0;
    int TWTNWCount = 0;
    int FormsCount = 0;
    int LevelsCount = 0;
    List<string> keyItems = new List<string>
    {
        "0000002A",
        "0000002B",
        "000001E0",
        "000001E1",
        "000001E4",
        "000001E5",
        "000001E6",
        "000001E7",
        "000001E8",
        "000001E9",
        "000001EA",
        "000001EB",
        "000001EC",
        "000001ED",
        "000001EF",
        "000001F0",
        "000001EE",
        "000001F2",
        "0000021F",
        "000001F1",
        "000001F3",
        "000001F4",
        "00000220",
        "0000001A",
        "0000001F",
        "0000001D"
    };
    List<string> keyItemsNames = new List<string>
    {
        "Oathkeeper",
        "Oblivion",
        "Star Seeker",
        "Hidden Dragon",
        "Heros Crest",
        "Monochrome",
        "Follow the Wind",
        "Circle of Life",
        "Photon Debugger",
        "Gull Wing",
        "Rumbling Rose",
        "Guardian Soul",
        "Wishing Lamp",
        "Decisive Pumpkin",
        "Sweet Memories",
        "Mysterious Abyss",
        "Sleeping Lion",
        "Bond of Flame",
        "Fatal Crest",
        "Two Become One",
        "Fenrir",
        "Ultima Weapon",
        "Winners Proof",
        "Valor",
        "Master",
        "Final"
    };
    List<string> Free = new List<string>
    {
        "11CE05E2",
        "11CE05EE",
        "11CE05FA",
        "11D18DDE",
        "11D18DDC",
        "11D18DE8",
        "11D18DE4",
        "11D18DE6",
        "11D18DE0",
        "11D18DE2"
    };
    List<string> STT = new List<string>
    {   "11CE016E",
        "11CE017A",
        "11CE0186",
        "11CE0192",
        "11CE019E",
        "11CE01AA",
        "11CE01B6",
        "11CE01C2",
        "11CE01CE",
        "11CE01DA",
        "11CE01E6",
        "11CE01F2",
        "11CE01FE",
        "11CE020A",
        "11CE0216",
        "11CE0222",
        "21D10FA8",
        "21D10CB8",
        "21D11278",
        "11CE0636",
        "11CE0606",
        "11CE0612", //champion belt
        "11CE061E", //medal
        "11CE062A",
        "11CE0642",
        "11CE064E",
        "11CE0B0A" //data roxas
    };
    public List<string> STTItems = new List<string>();
    List<string> TT = new List<string>
    {
        "11CE022E",
        "11CE023A",
        "11CE0246",
        "11CE0252",
        "11CE025E",
        "11CE026A",
        "11CE0276",
        "11CE0282",
        "11CE028E",
        "11CE029A",
        "11CE02A6",
        "11CE02B2",
        "11CE02BE",
        "11CE02CA",
        "11CE02D6",
        "11CE02E2",
        "11CE02EE",
        "11CE02FA",
        "11CE0306",
        "11CE0312",
        "11CE031E",
        "11CE032A",
        "11CE0336",
        "11CE0342",
        "11CE034E",
        "11CE035A",
        "11CE0366",
        "11CE0372",
        "11CE037E",
        "11CE038A",
        "11CE0396",
        "11CE03A2",
        "11CE03AE",
        "11CE03BA",
        "11CE03C6",
        "11CE03D2",
        "11CE03DE",
        "11CE03EA",
        "11CE03F6",
        "21D110E8",
        "11CE065A",
        "11CE0666",
        "11CE0672",
        "11CE067E",
        "11CE07E6",
        "11CE07F2",
        "11CE07FE",
        "11CE0966",
        "11CE09AE",
        "11CE0A0E",
        "11CE0ACE" //data axel
    };
    public List<string> TTItems = new List<string>();
    List<string> HB = new List<string>
    {
        "11CDFF3A",
        "11CDFF46",
        "11CDFF52",
        "11CDFF5E",
        "11CDFF6A",
        "11CDFF76",
        "11CDFF82",
        "11CDFF8E",
        "11CDFF9A",
        "11CDFFA6",
        "11CDFFB2",
        "11CDFFBE",
        "11CDFFCA",
        "11CDFFD6",
        "11CDFFE2",
        "11CDFFEE",
        "11CDFFFA",
        "11CE0006",
        "11CE0012",
        "11CE001E",
        "11CE002A",
        "11CE0036",
        "21D10E98",
        "21D10BA8",
        "21D11068",
        "11CE068A",
        "11CE0696",
        "11CE06A2",
        "11CE0702",
        "11CE080A",
        "11CE0822",
        "11CE082E",
        "11CE083A",
        "11CE0936",
        "11CE0942",
        "11CE09A2",
        "11CE09EA",
        "11CE0B3A", //shroom
        "11CE0B2E", //shroom
        "11CE0AB6", //data demyx
        "11CE04E6", //cor
        "11CE04F2",
        "11CE04FE",
        "11CE050A",
        "11CE0516",
        "11CE0522",
        "11CE052E",
        "11CE053A",
        "11CE0546",
        "11CE0552",
        "11CE055E",
        "11CE056A",
        "11CE0576",
        "11CE0582",
        "11CE058E",
        "11CE059A",
        "11CE05A6",
        "11CE05B2",
        "11CE05BE",
        "11CE05CA",
        "11CE05D6"
    };
    public List<string> HBItems = new List<string>();
    List<string> LoD = new List<string>
    {
        "11CDF72A",
        "11CDF736",
        "11CDF742",
        "11CDF74E",
        "11CDF75A",
        "11CDF766",
        "11CDF772",
        "11CDF77E",
        "11CDF78A",
        "11CDF796",
        "11CDF7A2",
        "11CDF7AE",
        "11CDF7BA",
        "11CDF7C6",
        "11CDF7D2",
        "11CDF7DE",
        "11CDF7EA",
        "11CDF7F6",
        "11CDF802",
        "11CDF80E",
        "11CDF81A",
        "21D10DF8",
        "21D108C8",
        "21D10908",
        "11CE06D2",
        "11CE06C6",
        "11CE06DE",
        "11CE06EA",
        "11CE0AE6" //data xigbar
    };
    public List<string> LoDItems = new List<string>();
    List<string> BC = new List<string>
    {
        "11CDFBF2",
        "11CDFBFE",
        "11CDFC0A",
        "11CDFC16",
        "11CDFC22",
        "11CDFC2E",
        "11CDFC3A",
        "11CDFC46",
        "11CDFC52",
        "11CDFC5E",
        "11CDFC6A",
        "11CDFC76",
        "11CDFC82",
        "11CDFC8E",
        "11CDFC9A",
        "11CDFCA6",
        "11CDFCB2",
        "11CDFCBE",
        "11CDFCCA",
        "11CDFCD6",
        "11CDFCE2",
        "21D10758",
        "21D10788",
        "21D107C8",
        "11CE06F6",
        "11CE0852",
        "11CE085E",
        "11CE09C6",
        "11CE0AC2" //data xaldin
    };
    public List<string> BCItems = new List<string>();
    List<string> OC = new List<string>
    {
        "11CDFB02",
        "11CDFB0E",
        "11CDFB1A",
        "11CDFB26",
        "11CDFB32",
        "11CDFB3E",
        "11CDFB4A",
        "11CDFB56",
        "11CDFB62",
        "11CDFB6E",
        "11CDFB7A",
        "11CDFB86",
        "11CDFB92",
        "11CDFB9E",
        "11CDFBAA",
        "11CDFBB6",
        "11CDFBC2",
        "11CDFBCE",
        "11CDFBDA",
        "11CDFBE6",
        "21D10808",
        "21D10FE8",
        "21D10828",
        "21D10858",
        "21D10888",
        "11CE070E",
        "11CE071A",
        "11CE09D2",
        "11CE0726",
        "11CE0882",
        "11CE088E",
        "11CE073E", //cups
        "11CE074A",
        "11CE07CE",
        "11CE07DA",
        "11CE089A",
        "11CE08A6",
        "11CE094E",
        "11CE095A",
        "11CE0996", //hades cup
        "11CE0A56", //AS zexion
        "11CE0A92" //data zexion
    };
    public List<string> OCItems = new List<string>();
    List<string> DC = new List<string> 
    {
        "11CDF9B2",
        "11CDF9BE",
        "11CDF9CA",
        "11CDF9D6",
        "11CDF9E2",
        "11CDF9EE",
        "11CDF9FA",
        "11CDFA06",
        "21D10D28",
        "11CE0756",
        "11CE0B16", //terra
        "11CE0B22", //terra
        "11CDF95E", //timeless river
        "11CDF96A",
        "11CDF976",
        "11CDF982",
        "11CDF98E",
        "11CDF99A",
        "11CDF9A6",
        "21D10988",
        "21D109B8",
        "11CE076E",
        "11CE0732",
        "11CE0762",
        "11CE0A6E", //AS marluxia
        "11CE0AAA" //data marluxia
    };
    public List<string> DCItems = new List<string>();
    List<string> PR = new List<string> 
    {
        "11CDFE3E",
        "11CDFE4A",
        "11CDFE56",
        "11CDFE62",
        "11CDFE6E",
        "11CDFE7A",
        "11CDFE86",
        "11CDFE92",
        "11CDFE9E",
        "11CDFEAA",
        "11CDFEB6",
        "11CDFEC2",
        "11CDFECE",
        "11CDFEDA",
        "11CDFEE6",
        "11CDFEF2",
        "11CDFEFE",
        "11CDFF0A",
        "11CDFF16",
        "11CDFF22",
        "11CDFF2E",
        "21D110B8",
        "21D10AA8",
        "21D11028",
        "21D10AE8",
        "11CE077A",
        "11CE0786",
        "11CE086A",
        "11CE0876",
        "11CE09DE",
        "11CE0AFE" //data luxord
    };
    public List<string> PRItems = new List<string>();
    List<string> AG = new List<string>
    {
        "11CDF826",
        "11CDF832",
        "11CDF83E",
        "11CDF84A",
        "11CDF856",
        "11CDF862",
        "11CDF86E",
        "11CDF87A",
        "11CDF886",
        "11CDF892",
        "11CDF89E",
        "11CDF8AA",
        "11CDF8B6",
        "11CDF8C2",
        "11CDF8CE",
        "11CDF8DA",
        "11CDF8E6",
        "11CDF8F2",
        "11CDF8FE",
        "11CDF90A",
        "11CDF916",
        "11CDF922",
        "11CDF92E",
        "11CDF93A",
        "11CDF946",
        "11CDF952",
        "21D10DB8",
        "21D10CE8",
        "21D10978",
        "11CE0792",
        "11CE079E",
        "11CE08B2",
        "11CE0A4A", //AS lexaeus
        "11CE0A86" //data lexaeus
    };
    public List<string> AGItems = new List<string>();
    List<string> HT = new List<string>
    {
        "11CDFD96",
        "11CDFDA2",
        "11CDFDAE",
        "11CDFDBA",
        "11CDFDC6",
        "11CDFDD2",
        "11CDFDDE",
        "11CDFDEA",
        "11CDFDF6",
        "11CDFE02",
        "11CDFE0E",
        "11CDFE1A",
        "11CDFE26",
        "11CDFE32",
        "21D109E8",
        "11CE07AA",
        "11CE08BE",
        "11CE08CA",
        "11CE08D6",
        "11CE0A3E", //AS vexen
        "11CE0A7A" //data vexen
    };
    public List<string> HTItems = new List<string>();
    List<string> PL = new List<string>
    {
        "11CE0042",
        "11CE004E",
        "11CE005A",
        "11CE0066",
        "11CE0072",
        "11CE007E",
        "11CE008A",
        "11CE0096",
        "11CE00A2",
        "11CE00AE",
        "11CE00BA",
        "11CE00C6",
        "11CE00D2",
        "11CE00DE",
        "11CE00EA",
        "11CE00F6",
        "11CE0102",
        "11CE010E",
        "11CE011A",
        "11CE0126",
        "11CE0132",
        "11CE013E",
        "11CE014A",
        "11CE0156",
        "11CE0162",
        "21D10C18",
        "11CE07B6",
        "11CE07C2",
        "11CE0AF2" //data saix
    };
    public List<string> PLItems = new List<string>();
    List<string> Atlantica = new List<string>
    {
        "11CE0846",
        "11CE08E2",
        "11CE08EE",
        "11CE08FA"
    };
    public List<string> ATItems = new List<string>();
    List<string> hundredacre = new List<string>
    {
        "11CDFA12",
        "11CDFA1E",
        "11CDFA2A",
        "11CDFA36",
        "11CDFA42",
        "11CDFA4E",
        "11CDFA5A",
        "11CDFA66",
        "11CDFA72",
        "11CDFA7E",
        "11CDFA8A",
        "11CDFA96",
        "11CDFAA2",
        "11CDFAAE",
        "11CDFABA",
        "11CDFAC6",
        "11CDFAD2",
        "11CDFADE",
        "11CDFAEA",
        "11CDFAF6",
        "11CE0906",
        "11CE0912",
        "11CE091E",
        "11CE092A"
    };
    public List<string> HundredItems = new List<string>();
    List<string> SP = new List<string>
    {
        "11CDFCEE",
        "11CDFCFA",
        "11CDFD06",
        "11CDFD12",
        "11CDFD1E",
        "11CDFD2A",
        "11CDFD36",
        "11CDFD42",
        "11CDFD4E",
        "11CDFD5A",
        "11CDFD66",
        "11CDFD72",
        "11CDFD7E",
        "11CDFD8A",
        "21D10C38",
        "21D11078",
        "21D10C78",
        "11CE0816",
        "11CE0A62", //AS larxene
        "11CE0A9E" //data larxene
    };
    public List<string> SPItems = new List<string>();
    List<string> TWTNW = new List<string>
    {
        "11CE0402",
        "11CE040E",
        "11CE041A",
        "11CE0426",
        "11CE0432",
        "11CE043E",
        "11CE044A",
        "11CE0456",
        "11CE0462",
        "11CE046E",
        "11CE047A",
        "11CE0486",
        "11CE0492",
        "11CE049E",
        "11CE04AA",
        "11CE04B6",
        "11CE04C2",
        "11CE04CE",
        "11CE04DA",
        "21D111E8",
        "21D10B58",
        "11CE0972",
        "11CE097E",
        "11CE098A",
        "11CE09BA",
        "11CE09F6",
        "11CE0A02",
        "11CE0A1A",
        "11CE0A26",
        "11CE0A32",
        "11CE0ADA" //data xemnas
    };
    public List<string> TWTNWItems = new List<string>();
    List<string> Forms = new List<string>
    {
        "11D1A22E", //valor
        "11D1A236",
        "11D1A23E",
        "11D1A246",
        "11D1A24E",
        "11D1A256",
        "11D1A266", //wisdom
        "11D1A26E",
        "11D1A276",
        "11D1A27E",
        "11D1A286",
        "11D1A28E",
        "11D1A29E", //limit
        "11D1A2A6",
        "11D1A2AE",
        "11D1A2B6",
        "11D1A2BE",
        "11D1A2C6",
        "11D1A2D6", //master
        "11D1A2DE",
        "11D1A2E6",
        "11D1A2EE",
        "11D1A2F6",
        "11D1A2FE",
        "11D1A30E", //Final
        "11D1A316",
        "11D1A31E",
        "11D1A326",
        "11D1A32E",
        "11D1A336"
    };
    public List<string> FormItems = new List<string>();
    List<string> Levels = new List<string>
    {
        "11D0B6C0", //Lvl 2
        "11D0B6E0", //Lvl 4
        "11D0B710", //Lvl 7
        "11D0B730", //Lvl 9
        "11D0B740", //Lvl 10
        "11D0B760", //Lvl 12
        "11D0B780", //Lvl 14
        "11D0B790", //Lvl 15
        "11D0B7B0", //Lvl 17
        "11D0B7E0", //Lvl 20
        "11D0B810", //Lvl 23
        "11D0B830", //Lvl 25
        "11D0B860", //Lvl 28
        "11D0B880", //Lvl 30
        "11D0B8A0", //Lvl 32
        "11D0B8C0", //Lvl 34
        "11D0B8E0", //Lvl 36
        "11D0B910", //Lvl 39
        "11D0B930", //Lvl 41
        "11D0B960", //Lvl 44
        "11D0B980", //Lvl 46
        "11D0B9A0", //Lvl 48
        "11D0B9C0", //Lvl 50

        "11D0B6D0", //Lvl 3
        "11D0B6F0", //Lvl 5
        "11D0B700", //Lvl 6
        "11D0B720", //Lvl 8
        "11D0B750", //Lvl 11
        "11D0B770", //Lvl 13
        "11D0B7A0", //Lvl 16
        "11D0B7C0", //Lvl 18
        "11D0B7D0", //Lvl 19
        "11D0B7F0", //Lvl 21
        "11D0B800", //Lvl 22
        "11D0B820", //Lvl 24
        "11D0B840", //Lvl 26
        "11D0B850", //Lvl 27
        "11D0B870", //Lvl 29
        "11D0B890", //Lvl 31
        "11D0B8B0", //Lvl 33
        "11D0B8D0", //Lvl 35
        "11D0B8F0", //Lvl 37
        "11D0B920", //Lvl 40
        "11D0B940", //Lvl 42
        "11D0B950", //Lvl 43
        "11D0B970", //Lvl 45
        "11D0B990", //Lvl 47
        "11D0B9B0", //Lvl 49

        "11D0B9D0", //Lvl 51-99
        "11D0B9E0",
        "11D0B9F0",
        "11D0BA00",
        "11D0BA10",
        "11D0BA20",
        "11D0BA30",
        "11D0BA40",
        "11D0BA50",
        "11D0BA60",
        "11D0BA70",
        "11D0BA80",
        "11D0BA90",
        "11D0BAA0",
        "11D0BAB0",
        "11D0BAC0",
        "11D0BAD0",
        "11D0BAE0",
        "11D0BAF0",
        "11D0BB00",
        "11D0BB10",
        "11D0BB20",
        "11D0BB30",
        "11D0BB40",
        "11D0BB50",
        "11D0BB60",
        "11D0BB70",
        "11D0BB80",
        "11D0BB90",
        "11D0BBA0",
        "11D0BBB0",
        "11D0BBC0",
        "11D0BBD0",
        "11D0BBE0",
        "11D0BBF0",
        "11D0BC00",
        "11D0BC10",
        "11D0BC20",
        "11D0BC30",
        "11D0BC40",
        "11D0BC50",
        "11D0BC60",
        "11D0BC70",
        "11D0BC80",
        "11D0BC90",
        "11D0BCA0",
        "11D0BCB0",
        "11D0BCC0",
        "11D0BCD0"
    };
    public List<string> LevelItems = new List<string>();
    List<string> importantchecks = new List<string>();
    string pnachpath;
    string hintpath;
    string pnachpath2;
    string pnachpath3;
    public bool read = false;

    // Start is called before the first frame update
    void Start()
    {
        pnachpath = Application.persistentDataPath;
        hintpath = Application.persistentDataPath;
        pnachpath2 = pnachpath + "/FAF99301.pnach";
        pnachpath3 = pnachpath + "/B7398B17.pnach";
        pnachpath += "/F266B00B.pnach";
        hintpath += "/Help.txt";
        read = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!read)
        {
            Function();
            read = true;
        }
    }


    void Function()
    {
        if (File.Exists(pnachpath))
        {
            StreamReader sr = new StreamReader(pnachpath);
            string line;
            do
            {
                line = sr.ReadLine();
                string[] parts = line.Split(new[] { ',' });
                if (parts.Length == 5)
                {
                    for (int i = 0; i < keyItems.Count; i++)
                    {
                        if (parts[4] == keyItems[i])
                        {
                            importantchecks.Add(line);
                        }
                    }
                }

            } while (!sr.EndOfStream);
            sr.Close();
        }
        else if (File.Exists(pnachpath2))
        {
            StreamReader sr = new StreamReader(pnachpath2);
            string line;
            do
            {
                line = sr.ReadLine();
                string[] parts = line.Split(new[] { ',' });
                if (parts.Length == 5)
                {
                    for (int i = 0; i < keyItems.Count; i++)
                    {
                        if (parts[4] == keyItems[i])
                        {
                            importantchecks.Add(line);
                        }
                    }
                }
            } while (!sr.EndOfStream);
            sr.Close();
        }
        else if (File.Exists(pnachpath3))
        {
            StreamReader sr = new StreamReader(pnachpath3);
            string line;
            do
            {
                line = sr.ReadLine();
                string[] parts = line.Split(new[] { ',' });
                if (parts.Length == 5)
                {
                    for (int i = 0; i < keyItems.Count; i++)
                    {
                        if (parts[4] == keyItems[i])
                        {
                            importantchecks.Add(line);
                        }
                    }
                }
            } while (!sr.EndOfStream);
            sr.Close();
        }



        for (int i = 0; i < importantchecks.Count; i++)
        {
            string[] parts = importantchecks[i].Split(new[] { ',' });
            for (int j = 0; j < STT.Count; j++)
            {
                if (parts[2] == STT[j])
                {
                    STTCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        STTItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < TT.Count; j++)
            {
                if (parts[2] == TT[j])
                {
                    TTCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        TTItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < HB.Count; j++)
            {
                if (parts[2] == HB[j])
                {
                    HBCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        HBItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < HT.Count; j++)
            {
                if (parts[2] == HT[j])
                {
                    HTCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        HTItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < SP.Count; j++)
            {
                if (parts[2] == SP[j])
                {
                    SPCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        SPItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < PR.Count; j++)
            {
                if (parts[2] == PR[j])
                {
                    PRCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        PRItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < OC.Count; j++)
            {
                if (parts[2] == OC[j])
                {
                    OCCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        OCItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < LoD.Count; j++)
            {
                if (parts[2] == LoD[j])
                {
                    LoDCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        LoDItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < TWTNW.Count; j++)
            {
                if (parts[2] == TWTNW[j])
                {
                    TWTNWCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        TWTNWItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < BC.Count; j++)
            {
                if (parts[2] == BC[j])
                {
                    BCCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        BCItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < AG.Count; j++)
            {
                if (parts[2] == AG[j])
                {
                    AGCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        AGItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < PL.Count; j++)
            {
                if (parts[2] == PL[j])
                {
                    PLCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        PLItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < DC.Count; j++)
            {
                if (parts[2] == DC[j])
                {
                    DCCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        DCItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < hundredacre.Count; j++)
            {
                if (parts[2] == hundredacre[j])
                {
                    hundredacreCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        HundredItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < Atlantica.Count; j++)
            {
                if (parts[2] == Atlantica[j])
                {
                    AtlanticaCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        ATItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < Levels.Count; j++)
            {
                if (parts[2] == Levels[j])
                {
                    LevelsCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        LevelItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }
            for (int j = 0; j < Forms.Count; j++)
            {
                if (parts[2] == Forms[j])
                {
                    FormsCount++;
                    if (keyItems.Contains(parts[4]))
                    {
                        FormItems.Add(keyItemsNames[keyItems.IndexOf(parts[4])]);
                    }
                }
            }

        }



        StreamWriter sw = new StreamWriter(hintpath);
        sw.WriteLine(STTCount); //STT
        sw.WriteLine(DCCount); //DC
        sw.WriteLine(HBCount); //HB
        sw.WriteLine(PLCount); //PL
        sw.WriteLine(AGCount); //AG
        sw.WriteLine(BCCount); //BC
        sw.WriteLine(TWTNWCount);  //TWTNW
        sw.WriteLine(LoDCount); //LoD
        sw.WriteLine(HTCount); //HT
        sw.WriteLine(OCCount); //OC
        sw.WriteLine(TTCount); //TT
        sw.WriteLine(PRCount); //PR
        sw.WriteLine(SPCount); //SP
        sw.WriteLine(AtlanticaCount); //Atlantica
        sw.WriteLine(hundredacreCount); //100acre
        sw.WriteLine(LevelsCount); //level
        sw.WriteLine(FormsCount); //forms
        sw.WriteLine("Total Count " + (STTCount + DCCount + HBCount + PLCount + AGCount + BCCount + TWTNWCount + LoDCount + HTCount + OCCount + TTCount + PRCount + SPCount + AtlanticaCount + hundredacreCount + LevelsCount + FormsCount));
        sw.Close();
        //for (int i = 0; i < OCItems.Count; i++)
        //{
        //    Debug.Log(OCItems[i]);
        //}

    }
}
