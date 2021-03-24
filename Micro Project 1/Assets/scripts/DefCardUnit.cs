using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefCardUnit : MonoBehaviour
{
    public int DefCardNum;

    public string DefCardName;
    public string DefCardDiscription;

    public float DefPHVal;
    public float DefJoyVal;
    public float DefMeaningVal;

    //actual text elements
    public Text cardName;
    public Text cardDiscription;
    public Text PhValtxt;
    public Text JoyValtxt;
    public Text meaningValtxt;


    private void Start()
    {
        cardName.text = DefCardName;
        cardDiscription.text = DefCardDiscription;
        PhValtxt.text = ""+DefPHVal;
        JoyValtxt.text = ""+DefJoyVal;
        meaningValtxt.text = ""+DefMeaningVal;
    }



}
