using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItems : MonoBehaviour
{
    public GameObject inventorySlot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItem(GameObject item)
    {
        //inventorySlot.GetComponent<SpriteRenderer>() = item.GetComponent<SpriteRenderer>();
        Debug.Log("SUUUUUUUUUUUUUUUUU");
        Destroy(item);
    }
}
