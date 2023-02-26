using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyLandBtn : GameScript
{
    //GameScript g = new GameScript();
    public double LandPrice = 5;
    public int LandBought = 0;
    public GameScript GameManager;
    public GameObject BuyLand1;
    public GameObject TreesLevel1;
    // Start is called before the first frame update
    void Start()
    {
        BuyLand1.SetActive(false);
        TreesLevel1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Money >= 5 && LandBought == 0)
        {
            BuyLand1.SetActive(true);
        }else{
            BuyLand1.SetActive(false);
        }
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
        TreesLevel1.SetActive(false);
        GameManager.Money = GameManager.Money - LandPrice;
        //Test
        //Remove(GameManager.BuyLandPNG);
    }
}
