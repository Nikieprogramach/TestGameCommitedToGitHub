using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressButton : Interactable
{
    public GameObject UIToShow;

    public override void Interact()
    {
        base.Interact();

        float distance = Vector2.Distance(player.position, transform.position);
        if (distance <= radius)
        {
            OnButtonPressed();
        }
    }

    public void OnButtonPressed()
    {
        if (UIToShow.active)
        {
            UIToShow.SetActive(false);
        }
        else
        {
            UIToShow.SetActive(true);
        }

    }
}
