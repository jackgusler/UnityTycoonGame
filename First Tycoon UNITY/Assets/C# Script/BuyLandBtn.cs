using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyLandBtn : GameScript
{
    //GameScript g = new GameScript();
    public double LandPrice = 5;
    public int LandBought = 0;
    public GameScript GameManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuyLand()
    {
        if(LandBought == 1)
        {
            return;
        }
        if(GameManager.Money<LandPrice)
        {
            return;
        }
        LandBought = 1;
        GameManager.Money = GameManager.Money - LandPrice;
        //Test
        Destroy(GameManager.MoneyText);
    }
}