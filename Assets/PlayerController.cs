using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D cam;

    public float moveSpeed = 5f;

    public Animator animator;

    public LayerMask interactable;

    Vector2 movement;

    void Start()
    {
        
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);

        if (Input.GetButtonDown("Fire1"))
        {             
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, interactable);

            if ( hit.collider != null && hit.collider.gameObject.GetComponent<Interactable>() != null)
            {
                hit.collider.gameObject.GetComponent<Interactable>().Interact();
            }


        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        cam.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
