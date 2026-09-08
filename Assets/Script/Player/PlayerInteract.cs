using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private float interactRage = 2f;
    [SerializeField] private LayerMask LayerMask;
    private PlayerUI playerUI;
    private InputManager inputManager;
    [SerializeField] private GameStateManager gameStateManager;
    private void Start()
    {
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
    }

    private void Update()
    {
        playerUI.TextUpdate("");
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRage, LayerMask);
        if (gameStateManager.CurrentState == Gamestate.Playing)
        {
            foreach (Collider collider in colliderArray)
            {
                Interactable interactable = collider.GetComponent<Interactable>();
                playerUI.TextUpdate(interactable.interactMessage);

                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();

                }
            }
        }
    }
}
