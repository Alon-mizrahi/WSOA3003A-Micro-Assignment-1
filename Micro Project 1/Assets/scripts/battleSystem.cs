using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class battleSystem : MonoBehaviour
{
    public battleHUD playerHUD;
    public battleHUD enemyHUD;


    public BattleState state;

    public Text enemyNameText;
    public Text DialogText;
    public Transform enemySpawnPt;
    public Transform playerSpawnPt;

    unit playerUnit;
    unit enemyUnit;

    public GameObject enemyprefab;
    public GameObject playerprefab;

//SETTING UP AND START STATE------------------------------------------------------------
    void Start()
    {
        state = BattleState.START;
        StartCoroutine(setupBattle());
    }

    IEnumerator setupBattle()
    {
        GameObject playerGO = Instantiate(playerprefab, playerSpawnPt);
        playerUnit = playerGO.GetComponent<unit>();

        GameObject enemyGO = Instantiate(enemyprefab, enemySpawnPt);
        enemyUnit = enemyGO.GetComponent<unit>();

        enemyNameText.text = enemyUnit.UnitName;

        playerHUD.setHUD(playerUnit);
        enemyHUD.setHUD(enemyUnit);

        DialogText.text = "lifes hand";

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

//ENEMYTURN STATE---------------------------------------------------------------------
   IEnumerator EnemyTurn()
    {
        DialogText.text = "Enemy's turn";
        yield return new WaitForSeconds(2f);
    }
    //how am i making the enemy do things?? AI of some kind. potential random between draw and card play. basic function. hardcode?



//PLAYERTURN STATE--------------------------------------------------------------

    void PlayerTurn() // can play card to attack or heal
    {
        DialogText.text = "Player 1's Turn";
        //they can now draw or play a card.

        //create function called on button click outside of player turn
    }

    //somefunction called when playing card
    //in this function apply card stats.
    //check if enemy dies
    //if true move to won state and call won function
    //StartCoroutine(WonFunction());
    //
    //check if player dies
    //if true move to lost state and call lost function
    //StartCoroutine(LostFunction());
    //
    //else move to enemy turn state and call enemy turn function


    IEnumerator DrawCard()
    {
        //draw card and add to deck on cardsystem script

        yield return new WaitForSeconds(2f);
        // interact with stats if needed
        state = BattleState.ENEMYTURN;
        StartCoroutine(EnemyTurn());
    }

    public void OnDrawButton() //draw card and end turn
    {
        if (state != BattleState.PLAYERTURN) { return; }

        StartCoroutine(DrawCard());
    }

    //WON STATE---------------------------------------------------------------------------
    IEnumerator WonFunction()
    {
        DialogText.text = "You Won!";
        yield return new WaitForSeconds(2f);
        //reset scene
    }

    //LOST STATE------------------------------------------------------------------------
    IEnumerator LostFunction()
    {
        DialogText.text = "You Lost!";
        yield return new WaitForSeconds(2f);
        //reset scene
    }

}
