using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUnit : MonoBehaviour
{
    public string CardName;
    public string CardDiscription;

    public float PHVal;
    public float JoyVal;
    public float MeaningVal;

    //actual text elements
    public Text cardName;
    public Text cardDiscription;
    public Text PhValtxt;
    public Text JoyValtxt;
    public Text meaningValtxt;

    battleSystem battleSystem;
    public GameObject battlesystm;
    private void Start()
    {
        battleSystem = battlesystm.GetComponent<battleSystem>();

        cardName.text = CardName;
        cardDiscription.text = CardDiscription;
        PhValtxt.text = ""+PHVal;
        JoyValtxt.text = ""+JoyVal;
        meaningValtxt.text = ""+MeaningVal;
    }


    //defense card used
    public void ATKCardUsed()
    {
        // send card unit data to attack card script
        //battleSystem.OnAttackCard(PHVal, MeaningVal, JoyVal);
    }

    //attack card used
    public void DEFCardUsed()
    {
        // send card unit data to defense card script
        // battleSystem.OnDefenseCard(PHVal, MeaningVal, JoyVal);
    }



}
