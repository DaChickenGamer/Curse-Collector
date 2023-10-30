using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopFunction : MonoBehaviour
{
    private int itemValue;
    private int itemCurseAmount;

    [SerializeField] private TextMeshProUGUI buyPrice;
    [SerializeField] private Image itemImage;

    private ItemClass currentItem;

    [SerializeField] private GameObject playerInventory;

    public List<ItemClass> itemsToChooseFrom = new List<ItemClass>();

    private void Update()
    {
        if (currentItem == null)
        {
            int randomNum = Random.Range(0, itemsToChooseFrom.Count);
            currentItem = itemsToChooseFrom[randomNum];
            itemImage.sprite = currentItem.itemIcon;
            buyPrice.text = currentItem.value + " Coins";

        }
    }
    public void OnBuy()
    {
        PlayerValues.playerCurses += currentItem.curseRate;
        PlayerValues.playerCoins -= currentItem.value;

        playerInventory.GetComponent<InventoryManager>().Add(currentItem);

        currentItem = null;
    }
}
