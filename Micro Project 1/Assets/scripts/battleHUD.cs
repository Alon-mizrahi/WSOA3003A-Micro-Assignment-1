using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battleHUD : MonoBehaviour
{
    public Text nameText;
    public Slider HpSlider;

    public void setHUD(unit unit)
    {
        nameText.text = unit.UnitName;
        HpSlider.maxValue = unit.maxHP;
        HpSlider.value = unit.currentHP;
    }

    public void SetHP(int hp)
    {
        HpSlider.value = hp;
    }

}
