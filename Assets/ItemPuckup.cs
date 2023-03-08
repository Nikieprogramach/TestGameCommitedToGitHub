using UnityEngine;

public class ItemPuckup : Interactable
{
    public Item item;

    public override void Interact ()
    {
        base.Interact ();

        float distance = Vector2.Distance(player.position, transform.position);
        if (distance <= radius)
        {
            PickUp();
        }
    }

    void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        bool wasPickedUp = Inventory.instance.AddItem(item);
        if(wasPickedUp)
        {
            Destroy(gameObject);
        }

    }
}
