using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class txtManager : MonoBehaviour
{
    public static Text Sliced;
    public static Text Missed;
    private void Start()
    {
        Sliced = GameObject.Find("txtSliced").GetComponent<Text>();
        Missed = GameObject.Find("txtMissed").GetComponent<Text>();
    }
    public static void setSliced()
    {
        string [] text = Sliced.text.Split();
        text[1] = GameStats.fruitSliced.ToString();
        Sliced.text = text[0] + " " + text[1];
    }
    public static void setMissed()
    {
        string[] text = Missed.text.Split();
        text[1] = GameStats.fruitMissed.ToString();
        Missed.text = text[0] + " " + text[1];
    }
}
