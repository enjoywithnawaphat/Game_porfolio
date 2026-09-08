using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string interactMessage;
    protected PlayerController playerController;

    private void Awake()
    {
        playerController = FindFirstObjectByType<PlayerController>();
    }

    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        
    }

}
