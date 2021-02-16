using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    [SerializeField]
    Pnach pnach;
    string world;
    Count count;

    public void World(string loc, Count a)
    {
        count = a;
        world = loc;  
    }

    public void Fire()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Fire"))
            {
                pnach.STTItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Fire"))
            {
                pnach.HundredItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Fire"))
            {
                pnach.AGItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Fire"))
            {
                pnach.ATItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Fire"))
            {
                pnach.BCItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Fire"))
            {
                pnach.DCItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Fire"))
            {
                pnach.FormItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Fire"))
            {
                pnach.HTItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Fire"))
            {
                pnach.HBItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Fire"))
            {
                pnach.PRItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Fire"))
            {
                pnach.LevelItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Fire"))
            {
                pnach.PLItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Fire"))
            {
                pnach.SPItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Fire"))
            {
                pnach.TWTNWItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Fire"))
            {
                pnach.OCItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Fire"))
            {
                pnach.TTItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Fire"))
            {
                pnach.LoDItems.Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Blizzard()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Blizzard"))
            {
                pnach.STTItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Blizzard"))
            {
                pnach.HundredItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Blizzard"))
            {
                pnach.AGItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Blizzard"))
            {
                pnach.ATItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Blizzard"))
            {
                pnach.BCItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Blizzard"))
            {
                pnach.DCItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Blizzard"))
            {
                pnach.FormItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Blizzard"))
            {
                pnach.HTItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Blizzard"))
            {
                pnach.HBItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Blizzard"))
            {
                pnach.PRItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Blizzard"))
            {
                pnach.LevelItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Blizzard"))
            {
                pnach.PLItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Blizzard"))
            {
                pnach.SPItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Blizzard"))
            {
                pnach.TWTNWItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Blizzard"))
            {
                pnach.OCItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Blizzard"))
            {
                pnach.TTItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Blizzard"))
            {
                pnach.LoDItems.Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Thunder()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Thunder"))
            {
                pnach.STTItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Thunder"))
            {
                pnach.HundredItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Thunder"))
            {
                pnach.AGItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Thunder"))
            {
                pnach.ATItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Thunder"))
            {
                pnach.BCItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Thunder"))
            {
                pnach.DCItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Thunder"))
            {
                pnach.FormItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Thunder"))
            {
                pnach.HTItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Thunder"))
            {
                pnach.HBItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Thunder"))
            {
                pnach.PRItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Thunder"))
            {
                pnach.LevelItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Thunder"))
            {
                pnach.PLItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Thunder"))
            {
                pnach.SPItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Thunder"))
            {
                pnach.TWTNWItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Thunder"))
            {
                pnach.OCItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Thunder"))
            {
                pnach.TTItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Thunder"))
            {
                pnach.LoDItems.Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Cure()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Cure"))
            {
                pnach.STTItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Cure"))
            {
                pnach.HundredItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Cure"))
            {
                pnach.AGItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Cure"))
            {
                pnach.ATItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Cure"))
            {
                pnach.BCItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Cure"))
            {
                pnach.DCItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Cure"))
            {
                pnach.FormItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Cure"))
            {
                pnach.HTItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Cure"))
            {
                pnach.HBItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Cure"))
            {
                pnach.PRItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Cure"))
            {
                pnach.LevelItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Cure"))
            {
                pnach.PLItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Cure"))
            {
                pnach.SPItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Cure"))
            {
                pnach.TWTNWItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Cure"))
            {
                pnach.OCItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Cure"))
            {
                pnach.TTItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Cure"))
            {
                pnach.LoDItems.Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Reflect()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Reflect"))
            {
                pnach.STTItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Reflect"))
            {
                pnach.HundredItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Reflect"))
            {
                pnach.AGItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Reflect"))
            {
                pnach.ATItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Reflect"))
            {
                pnach.BCItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Reflect"))
            {
                pnach.DCItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Reflect"))
            {
                pnach.FormItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Reflect"))
            {
                pnach.HTItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Reflect"))
            {
                pnach.HBItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Reflect"))
            {
                pnach.PRItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Reflect"))
            {
                pnach.LevelItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Reflect"))
            {
                pnach.PLItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Reflect"))
            {
                pnach.SPItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Reflect"))
            {
                pnach.TWTNWItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Reflect"))
            {
                pnach.OCItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Reflect"))
            {
                pnach.TTItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Reflect"))
            {
                pnach.LoDItems.Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Magnet()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Magnet"))
            {
                pnach.STTItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Magnet"))
            {
                pnach.HundredItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Magnet"))
            {
                pnach.AGItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Magnet"))
            {
                pnach.ATItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Magnet"))
            {
                pnach.BCItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false); 
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Magnet"))
            {
                pnach.DCItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Magnet"))
            {
                pnach.FormItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Magnet"))
            {
                pnach.HTItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Magnet"))
            {
                pnach.HBItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Magnet"))
            {
                pnach.PRItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Magnet"))
            {
                pnach.LevelItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Magnet"))
            {
                pnach.PLItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Magnet"))
            {
                pnach.SPItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Magnet"))
            {
                pnach.TWTNWItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Magnet"))
            {
                pnach.OCItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Magnet"))
            {
                pnach.TTItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Magnet"))
            {
                pnach.LoDItems.Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Valor()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Valor"))
            {
                pnach.STTItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Valor"))
            {
                pnach.HundredItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Valor"))
            {
                pnach.AGItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Valor"))
            {
                pnach.ATItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Valor"))
            {
                pnach.BCItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false); 
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Valor"))
            {
                pnach.DCItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Valor"))
            {
                pnach.FormItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Valor"))
            {
                pnach.HTItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Valor"))
            {
                pnach.HBItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Valor"))
            {
                pnach.PRItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Valor"))
            {
                pnach.LevelItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Valor"))
            {
                pnach.PLItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Valor"))
            {
                pnach.SPItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Valor"))
            {
                pnach.TWTNWItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Valor"))
            {
                pnach.OCItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Valor"))
            {
                pnach.TTItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Valor"))
            {
                pnach.LoDItems.Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Wisdom()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Wisdom"))
            {
                pnach.STTItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Wisdom"))
            {
                pnach.HundredItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Wisdom"))
            {
                pnach.AGItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Wisdom"))
            {
                pnach.ATItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Wisdom"))
            {
                pnach.BCItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Wisdom"))
            {
                pnach.DCItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Wisdom"))
            {
                pnach.FormItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Wisdom"))
            {
                pnach.HTItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Wisdom"))
            {
                pnach.HBItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Wisdom"))
            {
                pnach.PRItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Wisdom"))
            {
                pnach.LevelItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Wisdom"))
            {
                pnach.PLItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Wisdom"))
            {
                pnach.SPItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Wisdom"))
            {
                pnach.TWTNWItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Wisdom"))
            {
                pnach.OCItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Wisdom"))
            {
                pnach.TTItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Wisdom"))
            {
                pnach.LoDItems.Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Limit()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Limit"))
            {
                pnach.STTItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Limit"))
            {
                pnach.HundredItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Limit"))
            {
                pnach.AGItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Limit"))
            {
                pnach.ATItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Limit"))
            {
                pnach.BCItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Limit"))
            {
                pnach.DCItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Limit"))
            {
                pnach.FormItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Limit"))
            {
                pnach.HTItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Limit"))
            {
                pnach.HBItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Limit"))
            {
                pnach.PRItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Limit"))
            {
                pnach.LevelItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Limit"))
            {
                pnach.PLItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Limit"))
            {
                pnach.SPItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Limit"))
            {
                pnach.TWTNWItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Limit"))
            {
                pnach.OCItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Limit"))
            {
                pnach.TTItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Limit"))
            {
                pnach.LoDItems.Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Master()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Master"))
            {
                pnach.STTItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Master"))
            {
                pnach.HundredItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Master"))
            {
                pnach.AGItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Master"))
            {
                pnach.ATItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Master"))
            {
                pnach.BCItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Master"))
            {
                pnach.DCItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Master"))
            {
                pnach.FormItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Master"))
            {
                pnach.HTItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Master"))
            {
                pnach.HBItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Master"))
            {
                pnach.PRItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Master"))
            {
                pnach.LevelItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Master"))
            {
                pnach.PLItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Master"))
            {
                pnach.SPItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Master"))
            {
                pnach.TWTNWItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Master"))
            {
                pnach.OCItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Master"))
            {
                pnach.TTItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Master"))
            {
                pnach.LoDItems.Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Final()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Final"))
            {
                pnach.STTItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Final"))
            {
                pnach.HundredItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Final"))
            {
                pnach.AGItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Final"))
            {
                pnach.ATItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Final"))
            {
                pnach.BCItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Final"))
            {
                pnach.DCItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Final"))
            {
                pnach.FormItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Final"))
            {
                pnach.HTItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Final"))
            {
                pnach.HBItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Final"))
            {
                pnach.PRItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Final"))
            {
                pnach.LevelItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Final"))
            {
                pnach.PLItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Final"))
            {
                pnach.SPItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Final"))
            {
                pnach.TWTNWItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Final"))
            {
                pnach.OCItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Final"))
            {
                pnach.TTItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Final"))
            {
                pnach.LoDItems.Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void OMore()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("OMore"))
            {
                pnach.STTItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("OMore"))
            {
                pnach.HundredItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("OMore"))
            {
                pnach.AGItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("OMore"))
            {
                pnach.ATItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("OMore"))
            {
                pnach.BCItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("OMore"))
            {
                pnach.DCItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("OMore"))
            {
                pnach.FormItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("OMore"))
            {
                pnach.HTItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("OMore"))
            {
                pnach.HBItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("OMore"))
            {
                pnach.PRItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("OMore"))
            {
                pnach.LevelItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("OMore"))
            {
                pnach.PLItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("OMore"))
            {
                pnach.SPItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("OMore"))
            {
                pnach.TWTNWItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("OMore"))
            {
                pnach.OCItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("OMore"))
            {
                pnach.TTItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("OMore"))
            {
                pnach.LoDItems.Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void SChance()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("SChance"))
            {
                pnach.STTItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("SChance"))
            {
                pnach.HundredItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("SChance"))
            {
                pnach.AGItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("SChance"))
            {
                pnach.ATItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("SChance"))
            {
                pnach.BCItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("SChance"))
            {
                pnach.DCItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("SChance"))
            {
                pnach.FormItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("SChance"))
            {
                pnach.HTItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("SChance"))
            {
                pnach.HBItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("SChance"))
            {
                pnach.PRItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("SChance"))
            {
                pnach.LevelItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("SChance"))
            {
                pnach.PLItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("SChance"))
            {
                pnach.SPItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("SChance"))
            {
                pnach.TWTNWItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("SChance"))
            {
                pnach.OCItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("SChance"))
            {
                pnach.TTItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("SChance"))
            {
                pnach.LoDItems.Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Page()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Pages"))
            {
                pnach.STTItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Pages"))
            {
                pnach.HundredItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Pages"))
            {
                pnach.AGItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Pages"))
            {
                pnach.ATItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Pages"))
            {
                pnach.BCItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Pages"))
            {
                pnach.DCItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Pages"))
            {
                pnach.FormItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Pages"))
            {
                pnach.HTItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Pages"))
            {
                pnach.HBItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Pages"))
            {
                pnach.PRItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Pages"))
            {
                pnach.LevelItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Pages"))
            {
                pnach.PLItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Pages"))
            {
                pnach.SPItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Pages"))
            {
                pnach.TWTNWItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Pages"))
            {
                pnach.OCItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Pages"))
            {
                pnach.TTItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Pages"))
            {
                pnach.LoDItems.Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Genie()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Genie"))
            {
                pnach.STTItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Genie"))
            {
                pnach.HundredItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Genie"))
            {
                pnach.AGItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Genie"))
            {
                pnach.ATItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Genie"))
            {
                pnach.BCItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Genie"))
            {
                pnach.DCItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Genie"))
            {
                pnach.FormItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Genie"))
            {
                pnach.HTItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Genie"))
            {
                pnach.HBItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Genie"))
            {
                pnach.PRItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Genie"))
            {
                pnach.LevelItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Genie"))
            {
                pnach.PLItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Genie"))
            {
                pnach.SPItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Genie"))
            {
                pnach.TWTNWItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Genie"))
            {
                pnach.OCItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Genie"))
            {
                pnach.TTItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Genie"))
            {
                pnach.LoDItems.Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Stitch()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Stitch"))
            {
                pnach.STTItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Stitch"))
            {
                pnach.HundredItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Stitch"))
            {
                pnach.AGItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Stitch"))
            {
                pnach.ATItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Stitch"))
            {
                pnach.BCItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Stitch"))
            {
                pnach.DCItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Stitch"))
            {
                pnach.FormItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Stitch"))
            {
                pnach.HTItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Stitch"))
            {
                pnach.HBItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Stitch"))
            {
                pnach.PRItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Stitch"))
            {
                pnach.LevelItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Stitch"))
            {
                pnach.PLItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Stitch"))
            {
                pnach.SPItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Stitch"))
            {
                pnach.TWTNWItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Stitch"))
            {
                pnach.OCItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Stitch"))
            {
                pnach.TTItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Stitch"))
            {
                pnach.LoDItems.Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Chicken()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Chicken"))
            {
                pnach.STTItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Chicken"))
            {
                pnach.HundredItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Chicken"))
            {
                pnach.AGItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Chicken"))
            {
                pnach.ATItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Chicken"))
            {
                pnach.BCItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Chicken"))
            {
                pnach.DCItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Chicken"))
            {
                pnach.FormItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Chicken"))
            {
                pnach.HTItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Chicken"))
            {
                pnach.HBItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Chicken"))
            {
                pnach.PRItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Chicken"))
            {
                pnach.LevelItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Chicken"))
            {
                pnach.PLItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Chicken"))
            {
                pnach.SPItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWNTW")
        {
            if (pnach.TWTNWItems.Contains("Chicken"))
            {
                pnach.TWTNWItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Chicken"))
            {
                pnach.OCItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Chicken"))
            {
                pnach.TTItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Chicken"))
            {
                pnach.STTItems.Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void Peter()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("Peter"))
            {
                pnach.STTItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("Peter"))
            {
                pnach.HundredItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("Peter"))
            {
                pnach.AGItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("Peter"))
            {
                pnach.ATItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("Peter"))
            {
                pnach.BCItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("Peter"))
            {
                pnach.DCItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("Peter"))
            {
                pnach.FormItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("Peter"))
            {
                pnach.HTItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("Peter"))
            {
                pnach.HBItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("Peter"))
            {
                pnach.PRItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("Peter"))
            {
                pnach.LevelItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("Peter"))
            {
                pnach.PLItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("Peter"))
            {
                pnach.SPItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("Peter"))
            {
                pnach.TWTNWItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("Peter"))
            {
                pnach.OCItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("Peter"))
            {
                pnach.TTItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("Peter"))
            {
                pnach.LoDItems.Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void NProof()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("NProof"))
            {
                pnach.STTItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("NProof"))
            {
                pnach.HundredItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("NProof"))
            {
                pnach.AGItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("NProof"))
            {
                pnach.ATItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("NProof"))
            {
                pnach.BCItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("NProof"))
            {
                pnach.DCItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("NProof"))
            {
                pnach.FormItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("NProof"))
            {
                pnach.HTItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("NProof"))
            {
                pnach.HBItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("NProof"))
            {
                pnach.PRItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("NProof"))
            {
                pnach.LevelItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("NProof"))
            {
                pnach.PLItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("NProof"))
            {
                pnach.SPItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("NProof"))
            {
                pnach.TWTNWItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("NProof"))
            {
                pnach.OCItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("NProof"))
            {
                pnach.TTItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("NProof"))
            {
                pnach.LoDItems.Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void CProof()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("CProof"))
            {
                pnach.STTItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("CProof"))
            {
                pnach.HundredItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("CProof"))
            {
                pnach.AGItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("CProof"))
            {
                pnach.ATItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("CProof"))
            {
                pnach.BCItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("CProof"))
            {
                pnach.DCItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("CProof"))
            {
                pnach.FormItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("CProof"))
            {
                pnach.HTItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("CProof"))
            {
                pnach.HBItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("CProof"))
            {
                pnach.PRItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("CProof"))
            {
                pnach.LevelItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("CProof"))
            {
                pnach.PLItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("CProof"))
            {
                pnach.SPItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("CProof"))
            {
                pnach.TWTNWItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("CProof"))
            {
                pnach.OCItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("CProof"))
            {
                pnach.TTItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("CProof"))
            {
                pnach.LoDItems.Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void TProof()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("TProof"))
            {
                pnach.STTItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("TProof"))
            {
                pnach.HundredItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("TProof"))
            {
                pnach.AGItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("TProof"))
            {
                pnach.ATItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("TProof"))
            {
                pnach.BCItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("TProof"))
            {
                pnach.DCItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("TProof"))
            {
                pnach.FormItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("TProof"))
            {
                pnach.HTItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("TProof"))
            {
                pnach.HBItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("TProof"))
            {
                pnach.PRItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("TProof"))
            {
                pnach.LevelItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("TProof"))
            {
                pnach.PLItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("TProof"))
            {
                pnach.SPItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("TProof"))
            {
                pnach.TWTNWItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("TProof"))
            {
                pnach.OCItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("TProof"))
            {
                pnach.TTItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("TProof"))
            {
                pnach.LoDItems.Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    public void PCharm()
    {
        if (world == "STT")
        {
            if (pnach.STTItems.Contains("PCharm"))
            {
                pnach.STTItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.STTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "100")
        {
            if (pnach.HundredItems.Contains("PCharm"))
            {
                pnach.HundredItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.hundredacreCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AG")
        {
            if (pnach.AGItems.Contains("PCharm"))
            {
                pnach.AGItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AGCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "AT")
        {
            if (pnach.ATItems.Contains("PCharm"))
            {
                pnach.ATItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.AtlanticaCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "BC")
        {
            if (pnach.BCItems.Contains("PCharm"))
            {
                pnach.BCItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.BCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "DC")
        {
            if (pnach.DCItems.Contains("PCharm"))
            {
                pnach.DCItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.DCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Forms")
        {
            if (pnach.FormItems.Contains("PCharm"))
            {
                pnach.FormItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.FormsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HT")
        {
            if (pnach.HTItems.Contains("PCharm"))
            {
                pnach.HTItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "HB")
        {
            if (pnach.HBItems.Contains("PCharm"))
            {
                pnach.HBItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.HBCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PR")
        {
            if (pnach.PRItems.Contains("PCharm"))
            {
                pnach.PRItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PRCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "Levels")
        {
            if (pnach.LevelItems.Contains("PCharm"))
            {
                pnach.LevelItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LevelsCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "PL")
        {
            if (pnach.PLItems.Contains("PCharm"))
            {
                pnach.PLItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.PLCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "SP")
        {
            if (pnach.SPItems.Contains("PCharm"))
            {
                pnach.SPItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.SPCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TWTNW")
        {
            if (pnach.TWTNWItems.Contains("PCharm"))
            {
                pnach.TWTNWItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TWTNWCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "OC")
        {
            if (pnach.OCItems.Contains("PCharm"))
            {
                pnach.OCItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.OCCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "TT")
        {
            if (pnach.TTItems.Contains("PCharm"))
            {
                pnach.TTItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.TTCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else if (world == "LoD")
        {
            if (pnach.LoDItems.Contains("PCharm"))
            {
                pnach.LoDItems.Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == count.LoDCount)
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
