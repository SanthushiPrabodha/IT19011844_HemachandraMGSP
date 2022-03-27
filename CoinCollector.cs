using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{

    public int coinCount = 0;
    public int coinvalue;
    //public Counter Count;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.transform.tag == "Player")
        {
            Destroy(this.gameObject);

            coinCount++;

           //Counter.AddCoinCount(coinvalue);
        }

    }

    public int GetCellCount()
    {
        return coinCount;
    }

    public void SetCellCount(int CoinCount)
    {

        coinCount = CoinCount;
    }

}


