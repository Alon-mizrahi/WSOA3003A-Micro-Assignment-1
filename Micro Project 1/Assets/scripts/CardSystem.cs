using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSystem : MonoBehaviour
{

    //the balancing data desing numbers
    public float BalanceAtkPHVal = 1f;
    public float BalanceAtkJoyVal = 1f;
    public float BalanceAtkMeaningVal = 1f;

    //the balancing data desing numbers
    public float BalanceDefPHVal = 1f;
    public float BalanceDefJoyVal = 1f;
    public float BalanceDefMeaningVal = 1f;


    public GameObject[] deck;
    private int deckIterator=0;

    public GameObject PlayerCardHolder1;
    public GameObject PlayerCardHolder2;
    public GameObject PlayerCardHolder3;

    private bool isTruePlayerCardHolder1 = false;
    private bool isTruePlayerCardHolder2 = false;
    private bool isTruePlayerCardHolder3 = false;

    private GameObject TempGO;

    void Start()
    {
        Shuffle();
    }

    public void OnDrawCard()
    {
        //check player doesnt have 3 cards already
        if (isTruePlayerCardHolder1 == false)
        {
            deck[deckIterator].transform.position = PlayerCardHolder1.transform.position;
            deckIterator++;
            isTruePlayerCardHolder1 = true;
        }
        else if (isTruePlayerCardHolder2 == false)
        {
            deck[deckIterator].transform.position = PlayerCardHolder2.transform.position;
            deckIterator++;
            isTruePlayerCardHolder2 = true;
        }
        else if (isTruePlayerCardHolder3 == false)
        {
            deck[deckIterator].transform.position = PlayerCardHolder3.transform.position;
            deckIterator++;
            isTruePlayerCardHolder3 = true;
        }


        //draw from begining of array. then increment deck iterator
        //draw card
        //
        //place on players side at open holder

        //change battle state state to enemy turn on battle system script

        Debug.Log("button push cardsystem sas high");
    }


    void Shuffle()
    {
        for (int i = 0; i < deck.Length - 1; i++)
        {
            int rnd = Random.Range(i, deck.Length);
            TempGO = deck[rnd];
            deck[rnd] = deck[i];
            deck[i] = TempGO;
        }

    }


    //using card make sure to use data value balancing numbers

}
