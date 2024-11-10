using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public static int coinCount = 0;

    void Update()
    {
        coinText.text = "Points: " + coinCount;
    }

    public void AddCoin()
    {
        coinCount++;
    }
}