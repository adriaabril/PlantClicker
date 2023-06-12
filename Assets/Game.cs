using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public TextMeshProUGUI tapsUI;
    public TextMeshProUGUI multiplierUI;

    public void Tap()
    {
        GameManager.taps = (GameManager.taps + 1) * GameManager.multiplier;
    }

    public void Buy()
    {

    }

    public void Update()
    {

        tapsUI.text = "Taps: " + GameManager.taps;
        multiplierUI.text = "Multiplier: " + GameManager.multiplier;

    }
}
