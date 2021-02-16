using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    [SerializeField]
    Pnach pnach;
    string world;
    Count count;
    List<string> worlds = new List<string>
    {
        "STT",
        "TT",
        "HB",
        "LoD",
        "BC",
        "OC",
        "DC",
        "PR",
        "AG",
        "HT",
        "PL",
        "AT",
        "100",
        "SP",
        "TWTNW",
        "Forms",
        "Levels",
    };
    List<List<string>> items;
    List<int> Count;
    bool once = false;
    int index = -1;

    void Update()
    {
        if (pnach.doneread && !once)
        {
            once = true;
            items = new List<List<string>>
            {
                pnach.STTItems,
                pnach.TTItems,
                pnach.HBItems,
                pnach.LoDItems,
                pnach.BCItems,
                pnach.OCItems,
                pnach.DCItems,
                pnach.PRItems,
                pnach.AGItems,
                pnach.HTItems,
                pnach.PLItems,
                pnach.ATItems,
                pnach.HundredItems,
                pnach.SPItems,
                pnach.TWTNWItems,
                pnach.FormItems,
                pnach.LevelItems
            };

            Count = new List<int>
            {
                count.STTCount,
                count.TTCount,
                count.HBCount,
                count.LoDCount,
                count.BCCount,
                count.OCCount,
                count.DCCount,
                count.PRCount,
                count.AGCount,
                count.HTCount,
                count.PLCount,
                count.AtlanticaCount,
                count.hundredacreCount,
                count.SPCount,
                count.TWTNWCount,
                count.FormsCount,
                count.LevelsCount
            };
        }
    }

    public void World(string loc, Count a)
    {
        count = a;
        world = loc;  
    }

    public void Fire()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Fire"))
            {
                items[index].Remove("Fire");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Blizzard()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Blizzard"))
            {
                items[index].Remove("Blizzard");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Thunder()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Thunder"))
            {
                items[index].Remove("Thunder");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Cure()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Cure"))
            {
                items[index].Remove("Cure");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Reflect()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Reflect"))
            {
                items[index].Remove("Reflect");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Magnet()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Magnet"))
            {
                items[index].Remove("Magnet");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Valor()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Valor"))
            {
                items[index].Remove("Valor");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Wisdom()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Wisdom"))
            {
                items[index].Remove("Wisdom");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Limit()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Limit"))
            {
                items[index].Remove("Limit");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Master()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Master"))
            {
                items[index].Remove("Master");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Final()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Final"))
            {
                items[index].Remove("Final");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void OMore()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("OMore"))
            {
                items[index].Remove("OMore");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void SChance()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("SChance"))
            {
                items[index].Remove("SChance");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Page()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Pages"))
            {
                items[index].Remove("Pages");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Genie()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Genie"))
            {
                items[index].Remove("Genie");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Stitch()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Stitch"))
            {
                items[index].Remove("Stitch");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Chicken()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Chicken"))
            {
                items[index].Remove("Chicken");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void Peter()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("Peter"))
            {
                items[index].Remove("Peter");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void NProof()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("NProof"))
            {
                items[index].Remove("NProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void CProof()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("CProof"))
            {
                items[index].Remove("CProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void TProof()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("TProof"))
            {
                items[index].Remove("TProof");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }
    public void PCharm()
    {
        index = worlds.IndexOf(world);
        if (index >= 0)
        {
            if (items[index].Contains("PCharm"))
            {
                items[index].Remove("PCharm");
                count.number = int.Parse(count.text.text);
                count.number++;
                count.text.text = count.number.ToString();
                gameObject.SetActive(false);
                if (count.number == Count[index])
                {
                    count.checks.gameObject.SetActive(true);
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        index = -1;
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
