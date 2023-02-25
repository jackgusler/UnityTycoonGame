using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyLandBtn : GameScript
{
    //GameScript g = new GameScript();
    public float LandPrice = 5;
    public float LandBought = 0;
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
        if(LandBought >= 1)
        {
            return;
        }
        if(GameManager.Money<LandPrice)
        {
            return;
        }
        //BuyLandBtn
        GameManager.Money = GameManager.Money - 5;
        Destroy(GameManager.MoneyText);
        LandBought = 1;
    }
}
