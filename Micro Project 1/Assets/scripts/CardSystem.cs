using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSystem : MonoBehaviour
{
    public GameObject[] deck;
    private int deckIterator=0;

    public GameObject PlayerCardHolder1;
    public GameObject PlayerCardHolder2;
    public GameObject PlayerCardHolder3;

    private bool isTruePlayerCardHolder1 = false;
    private bool isTruePlayerCardHolder2 = false;
    private bool isTruePlayerCardHolder3 = false;

    //access to states
    public GameObject battleSystem;
    battleSystem battlescript;
    private GameObject TempGO;

    void Start()
    {
        
        battlescript = battleSystem.GetComponent<battleSystem>();
        Shuffle(); 
        //Debug.Log(battlescript.state);
    }

    public void OnDrawCard()
    {
        if (battlescript.state == BattleState.PLAYERTURN) {
            //check player doesnt have 3 cards already
            if (isTruePlayerCardHolder1 == false)
            {
                deck[deckIterator].transform.position = PlayerCardHolder1.transform.position;
                deckIterator++;
                isTruePlayerCardHolder1 = true;
                battlescript.OnDrawButton();
            }
            else if (isTruePlayerCardHolder2 == false)
            {
                deck[deckIterator].transform.position = PlayerCardHolder2.transform.position;
                deckIterator++;
                isTruePlayerCardHolder2 = true;
                battlescript.OnDrawButton();
            }
            else if (isTruePlayerCardHolder3 == false)
            {
                deck[deckIterator].transform.position = PlayerCardHolder3.transform.position;
                deckIterator++;
                isTruePlayerCardHolder3 = true;
                battlescript.OnDrawButton();
            }
        }
        //Debug.Log("button push cardsystem says high");
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

    //card attacks and heals
 
    //card clicked
    //call function based on atk or def
    //look at state to see who played
    // affect changes via another function called from battle system script/ or this script since here balancing numbers

    //using card make sure to use data value balancing numbers



}
