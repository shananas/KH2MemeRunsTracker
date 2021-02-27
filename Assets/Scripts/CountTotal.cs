using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class CountTotal : MonoBehaviour
{

    [SerializeField]
    public GameObject thing;
    [SerializeField]
    public TextMeshProUGUI total;
    public int totalnumber;
    [SerializeField]
    Count count;
    bool hmmm = false;

    private void Update()
    {
        if (count.fuck && !hmmm)
        {
            totalnumber = int.Parse(total.text);
        }
    }


    public void Plus()
    {
        if (thing.gameObject.name == "Total")
        {
            totalnumber = int.Parse(total.text);
            totalnumber++;
            total.text = totalnumber.ToString();
        }
    }

    public void Minus()
    {
        if (totalnumber > 1)
        {
            totalnumber = int.Parse(total.text);
            totalnumber--;
            total.text = totalnumber.ToString();
        }
    }
}
