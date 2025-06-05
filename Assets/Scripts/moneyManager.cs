using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyManager : MonoBehaviour
{
    public float money;
    public UI_MANAGER uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager.UpdateMoneyTxt(money.ToString());
    }

        public void UpdateMoney(float moneyToAdd)
    {
        if (money + moneyToAdd < 0)
        {
            Debug.Log("Dinero insuficiente");
            return;
        }
        money += moneyToAdd;
        uiManager.UpdateMoneyTxt(money.ToString());
    }
}
