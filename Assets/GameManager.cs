using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int taps;
    public static int multiplier;

    // Start is called before the first frame update
    void Start()
    {
        taps = 0;
        multiplier = 1;
    }
}
