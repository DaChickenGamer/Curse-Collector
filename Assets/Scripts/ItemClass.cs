using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class ItemClass : ScriptableObject
{
    public string itemName;
    public int value;
    public int curseRate; // Tempt Value to Apply Curse Rate
    public Sprite itemIcon;
    public string itemText;
}
