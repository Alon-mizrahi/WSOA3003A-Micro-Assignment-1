using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtkCardUnit : MonoBehaviour
{
    public int AtkCardNum;

    public string AtkCardName;
    public string AtkCardDiscription;

    public float AtkPHVal;
    public float AtkJoyVal;
    public float AtkMeaningVal;


    //actual text elements
    public Text cardName;
    public Text cardDiscription;
    public Text PhValtxt;
    public Text JoyValtxt;
    public Text meaningValtxt;


    private void Start()
    {
        cardName.text = AtkCardName;
        cardDiscription.text = AtkCardDiscription;
        PhValtxt.text = "" + AtkPHVal;
        JoyValtxt.text = "" + AtkJoyVal;
        meaningValtxt.text = "" + AtkMeaningVal;
    }

}
