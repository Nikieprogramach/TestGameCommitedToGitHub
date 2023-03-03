using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 2;
    public Transform interactionTransform;

    public bool isFocus = false;
    public Transform player;

    bool hasInteracted = false;

    void Update()
    {
        if(isFocus)
        {
            float distance = Vector2.Distance(player.position, transform.position);
            if(distance <= radius)
            {
                Interact();
            }
        }
    }

    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
    }

    public virtual void Interact()
    {
        Debug.Log("Interacting with:" + transform.name);
    }

    void OnDrawGizmosSelected()
    {
        if(interactionTransform == null)
        {
            interactionTransform = transform;
        }

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
