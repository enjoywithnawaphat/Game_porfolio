using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.Rendering;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    public PlayerInput.OnFootActions onFoot;
    public PlayerInput.DialogueActions dialogue;
    private static InputManager _instance;
    public static InputManager Instance { get { return _instance; } }
    
    private PlayerController playerController;
    private CameraSwitch cameraSwitch;
    //private PlayerLook look;
    public bool isRunning;

    private void Awake()
    {
        _instance = this;
        playerInput = new PlayerInput();
        onFoot = playerInput.onFoot;
        dialogue = playerInput.dialogue;


        playerController = GetComponent<PlayerController>();
        //look = GetComponent<PlayerLook>();
        cameraSwitch = GetComponent<CameraSwitch>();

        onFoot.Jump.performed += ctx => playerController.Jump();
        onFoot.SwitchCam.performed += ctx => cameraSwitch.SwitchCamera();

        onFoot.Run.performed += ctx => isRunning = true;
        onFoot.Run.canceled += ctx => isRunning = false;
        
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        playerController.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
        if (isRunning)
        {
            playerController.speed = 5f;
        }
        else
        {
            playerController.speed = 2f;
        }
    }

    public Vector2 GetMouseDelta()
    {
        return onFoot.Look.ReadValue<Vector2>();
    }

    private void LateUpdate()
    {
        //look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }
    private void OnDisable()
    {
        onFoot.Disable();
    }

    public bool IsRunning()
    {
        return isRunning;
    }
}
