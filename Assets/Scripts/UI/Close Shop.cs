using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseShop : MonoBehaviour
{
    [SerializeField] private GameObject shop;

    public void ShopClose()
    {
        shop.SetActive(false);
    }
}
