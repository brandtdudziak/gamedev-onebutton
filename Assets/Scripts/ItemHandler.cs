using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHandler : MonoBehaviour
{
    GameObject pickedItem;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            if (pickedItem == null)
            {
                pickedItem = other.gameObject;
                pickedItem.transform.SetParent(transform);
                pickedItem.transform.position = transform.position + Vector3.right * 0.5f;
            }
        }
    }
}
