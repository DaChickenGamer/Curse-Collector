using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEditor;
using UnityEngine;

public class PlayerValues : MonoBehaviour
{
    [SerializeField] public static int playerCoins = 200;
    public static int playerCurses = 0;
    private int curseIncrementAmount;

    [SerializeField] private TextMeshProUGUI coinTextBox;
    [SerializeField] private TextMeshProUGUI curseTextBox;

    public static bool isInteracting = false;
    private void Update()
    {
        coinTextBox.text = "Coins: " + playerCoins;
        curseTextBox.text = "Curses: " + playerCurses;

        curseIncrementAmount = playerCurses;

        GiveCurses();
    }
    public void OnInteract()
    {
        if (isInteracting == true)
            isInteracting = false;
        else
            isInteracting = true;
    }
    private IEnumerator GiveCurses()
    {
        playerCoins += curseIncrementAmount;
        yield return new WaitForSeconds(10);
    }
}
