using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public Camera cam;

    public bool isInObject = false;

    Vector2 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (isInObject == false)
        {
            isInObject = true;
        }
        else
        {
            isInObject = false;
        }
        if(Input.GetButtonDown("Fire1") == true && collider.GetComponent<Interactable>() != null && isInObject == true)
        {
            Debug.Log("ItemClickedOn");
        }
    }
}
