using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit : MonoBehaviour
{
    public string UnitName;

    //add the three types of HP and there current levels
    public int maxPysicality;
    public int currentPysicality;

    public int maxJoy;
    public int currentJoy;

    public int maxMeaning;
    public int currentMeaning;


    public bool Dead(int dmg)
    {
        currentPysicality -= dmg;

        if (currentPysicality <= 0) { return true; } else { return false; }
    }


}
