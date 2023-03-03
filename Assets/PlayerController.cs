using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D cam;

    public float moveSpeed = 5f;

    public Animator animator;

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
            //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            //ReycastHit2D hit;
            //
            //if (Physics2D.Raycast(ray, out hit, 100));
            //{
            //    Interactable interactable = hit.collider.GetComponent<Interactable>();
            //    if(interactable != null)
            //    {
            //        interactable.OnFocused(transform);
            //    }
            //}

             
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider.gameObject.GetComponent<Interactable>() != null)
            {
                hit.collider.gameObject.GetComponent<Interactable>().isFocus = true;
            }


        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        cam.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
