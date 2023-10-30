using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    private bool inShopArea;
    private Collider2D shop;

    [SerializeField] private GameObject shopUI; 

    public void OnInteract()
    {
        if (inShopArea)
        {
            shopUI.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "House")
        {
            inShopArea = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "House")
        {
            inShopArea = false;
        }
    }
}
