using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RioInteract : Interactable
{
    private DialogueManager dialogueManager;
    public Dialogue dialogue;

    private void Awake()
    {
        dialogueManager = GetComponent<DialogueManager>();
    }

    protected override void Interact()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
