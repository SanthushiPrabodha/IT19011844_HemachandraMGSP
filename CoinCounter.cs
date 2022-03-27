using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public Text coinCount;
    public Text medallionCount;
    public int coin = 0;
    public int medallion;

    void Start()
    {
        coinCount.text = "Coin : 0";
        medallionCount.text = "Medallion : 0";
    }

    public void AddCellCount(int Count)
    {
        coin += Count;
        coinCount.text = "Coin - " + coin.ToString();
    }

    public void SetCellCount(int Count)
    {
        coin = Count;
        coinCount.text = "Coin - " + coin.ToString();
    }

    public void SetMedallionCount(int coinCount){
        coin = coinCount;
    }

    public int GetGateCount(){
        return medallion;
    }
}