using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private float interactRage = 2f;
    [SerializeField] private float distance = 2f;
    [SerializeField] private LayerMask LayerMask;
    private PlayerUI playerUI;
    private InputManager inputManager;
    [SerializeField] private GameStateManager gameStateManager;
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private Camera playerCamera; 

    private void Start()
    {
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
    }

    private void Update()
    {
        Vector3 screenCenter = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);
        Ray cameraRay = playerCamera.ScreenPointToRay(screenCenter);
        Vector3 targetPoint = cameraRay.origin + cameraRay.direction * 10f;
        Vector3 direction = (targetPoint - interactionPoint.position).normalized;
        Ray interactionRay = new Ray(interactionPoint.position, direction);

        Debug.DrawRay(interactionRay.origin, interactionRay.direction * distance, Color.red);
        RaycastHit hitInfo;

        playerUI.TextUpdate(string.Empty);
        if (Physics.Raycast(interactionRay, out hitInfo, distance, LayerMask))
        {
            if (hitInfo.collider.GetComponentInParent<Interactable>() && gameStateManager.CurrentState == Gamestate.Playing)
            {
                Debug.Log(hitInfo);
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.TextUpdate(interactable.interactMessage);
 
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();
                }
            }
        }
    }  
}
