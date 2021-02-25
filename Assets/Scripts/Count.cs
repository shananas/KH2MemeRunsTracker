using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class Count : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI text;
    public int number;
    [SerializeField]
    public TextMeshProUGUI checks;
    string hintpath;
    public int STTCount = 0;
    public int TTCount = 0;
    public int HBCount = 0;
    public int LoDCount = 0;
    public int BCCount = 0;
    public int OCCount = 0;
    public int DCCount = 0;
    public int PRCount = 0;
    public int AGCount = 0;
    public int HTCount = 0;
    public int PLCount = 0;
    public int AtlanticaCount = 0;
    public int hundredacreCount = 0;
    public int SPCount = 0;
    public int TWTNWCount = 0;
    public int FormsCount = 0;
    public int LevelsCount = 0;
    [SerializeField]
    public Pnach done;
    bool why = false;
    [SerializeField]
    public GameObject thing;
    bool because = true;
    [SerializeField]
    GameObject canvas;
    [SerializeField]
    Items item;
    [SerializeField]
    public TextMeshProUGUI total;
    public int totalnumber;

    private void Start()
    {
        hintpath = Application.persistentDataPath;
        hintpath += "/Help.txt";              

    }
    private void Update()
    {

        if (done.read  && !why)
        {
            StreamReader sr = new StreamReader(hintpath);
            string line;
            int linecount = 0;
            do
            {
                
                line = sr.ReadLine();
                if (linecount == 0)
                {
                    STTCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 1)
                {
                    DCCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 2)
                {
                    HBCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 3)
                {
                    PLCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 4)
                {
                    AGCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 5)
                {
                    BCCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 6)
                {
                    TWTNWCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 7)
                {
                    LoDCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 8)
                {
                    HTCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 9)
                {
                    OCCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 10)
                {
                    TTCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 11)
                {
                    PRCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 12)
                {
                    SPCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 13)
                {
                    AtlanticaCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 14)
                {
                    hundredacreCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 15)
                {
                    LevelsCount = int.Parse(line);
                    linecount++;
                }
                else if (linecount == 16)
                {
                    FormsCount = int.Parse(line);
                    linecount++;
                }

            } while (!sr.EndOfStream);
            sr.Close();
            why = true;

            if (why && because)
            {
                if (thing.gameObject.name == "STT" && STTCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "100 Acre" && hundredacreCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Agrabah" && AGCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Atlantica" && AtlanticaCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Beast Castle" && BCCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Disney Castle" && DCCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Drive Form" && FormsCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Halloween Town" && HTCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Hollow Bastion" && HBCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Port Royal" && PRCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Levels" && LevelsCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Pride Lands" && PLCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Space Parinoids" && SPCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "TWTNW" && TWTNWCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Olympus Collesium" && OCCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Twilight Town" && TTCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }
                if (thing.gameObject.name == "Land of Dragons" && LoDCount == 0)
                {
                    checks.gameObject.SetActive(true);
                }  
            }
        }
       

    }

    public void Plus()
    {    
        if (thing.gameObject.name == "STT" && number < STTCount)
        {
            if(done.STTItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == STTCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }           
        }        
        else if (thing.gameObject.name == "100 Acre" && number < hundredacreCount)
        {
            if (done.HundredItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == hundredacreCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Agrabah" && number < AGCount)
        {
            if (done.AGItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == AGCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Atlantica" && number < AtlanticaCount)
        {
            if (done.ATItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == AtlanticaCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Beast Castle" && number < BCCount)
        {
            if (done.BCItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == BCCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Disney Castle" && number < DCCount)
        {
            if (done.DCItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == DCCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Drive Form" && number < FormsCount)
        {
            if (done.FormItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == FormsCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Halloween Town" && number < HTCount)
        {
            if (done.HTItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == HTCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Hollow Bastion" && number < HBCount)
        {
            if (done.HBItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == HBCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Port Royal" && number < PRCount)
        {
            if (done.PRItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == PRCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Pride Lands" && number < PLCount)
        {
            if (done.PLItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == PLCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Levels" && number < LevelsCount)
        {
            if (done.LevelItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == LevelsCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Space Parinoids" && number < SPCount)
        {
            if (done.SPItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == SPCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "TWTNW" && number < TWTNWCount)
        {
            if (done.TWTNWItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == TWTNWCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Olympus Collesium" && number < OCCount)
        {
            if (done.OCItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == OCCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Twilight Town" && number < TTCount)
        {
            if (done.TTItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == TTCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Land of Dragons" && number < LoDCount)
        {
            if (done.LoDItems.Count > 0)
            {
                number = int.Parse(text.text);
                number++;
                text.text = number.ToString();
                totalnumber = int.Parse(total.text);
                totalnumber++;
                total.text = totalnumber.ToString();
                if (number == LoDCount)
                {
                    checks.gameObject.SetActive(true);
                }
            }
        }
        else if (thing.gameObject.name == "Total")
        {
            totalnumber = int.Parse(total.text);
            totalnumber++;
            total.text = totalnumber.ToString();

        }
        because = false;
    }

    //public void Minus()
    //{
    //    if (number > 0)
    //    {
    //        number = int.Parse(text.text);
    //        number--;
    //        text.text = number.ToString();
    //    }
    //}

}
