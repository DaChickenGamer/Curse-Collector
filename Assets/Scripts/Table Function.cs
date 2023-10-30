using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableFunction : MonoBehaviour
{
    [SerializeField] private Collider2D playerCollider;

    private GameObject icon;
    private ItemClass item;

    private bool inTableArea;

    // Update is called once per frame
    void Update()
    {
        if (PlayerValues.isInteracting && item == null)
        {

        }
        if (icon == null)
        {
            icon.GetComponent<SpriteRenderer>().Equals(item.itemIcon);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == playerCollider)
            inTableArea = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider == playerCollider)
            inTableArea = false;
    }
}
