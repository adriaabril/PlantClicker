using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public TextMeshProUGUI tapsUI;
    public TextMeshProUGUI multiplierUI;
    public Sprite[] plantState;
    public Image plant;
    private int statusCounter = 0; 

    public void Tap()
    {
        GameManager.taps = (GameManager.taps + 1) * GameManager.multiplier;

        if(GameManager.taps % 10 == 0 && statusCounter < plantState.Length)
        {
            plant.sprite = plantState[statusCounter];
            statusCounter++;
        }
    }

    public void Buy()
    {
        //TODO implement objects to modify multiplier
    }

    public void Update()
    {

        tapsUI.text = "Taps: " + GameManager.taps;
        multiplierUI.text = "Multiplier: " + GameManager.multiplier;

    }
}
