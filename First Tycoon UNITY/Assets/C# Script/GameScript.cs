using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{

    public double Money = 0.00;
    public double MoneyAdded = 0.25;
    public int StartTimer = 0;
    public Text MoneyText;
    //public Button BuyLand1 = new Button();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Money
        MoneyText.text = Money.ToString("C2");
        if(StartTimer == 1)
        {
            Money += MoneyAdded;
            StartTimer = 0;
        }
    }
    public void StartBtnClicked()
    {
        StartTimer = 1;
    }
}