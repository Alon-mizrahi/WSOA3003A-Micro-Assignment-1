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


    //the balancing data desing numbers
    public float BalanceAtkPHVal = 1f;
    public float BalanceAtkJoyVal = 1f;
    public float BalanceAtkMeaningVal = 1f;

    //the balancing data desing numbers
    public float BalanceDefPHVal = 1f;
    public float BalanceDefJoyVal = 1f;
    public float BalanceDefMeaningVal = 1f;


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
    }

    public void OnDrawButton() //draw card and end turn
    {
        StartCoroutine(DrawCard());
    }

    IEnumerator DrawCard()
    {
        //draw card and add to deck on cardsystem script
        Debug.Log("cross call worked");
        state = BattleState.ENEMYTURN;
        yield return new WaitForSeconds(2f);
        StartCoroutine(EnemyTurn());
    }


    public void CardUsed(float PHVal)
    {
        Debug.Log("This is the cards PH Value: " +PHVal);
    }

//Attack and defens play funcitons---------------------------------------------------------------

    public void OnAttackCard(float PHVal, float MeaningVal, float JoyVal)
    {

    }


    public void OnDefenseCard(float PHVal, float MeaningVal, float JoyVal)
    {

    }


    //----------------------------------------------------------------------


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
