using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator aniamtor;
    private InputManager inputManager;
    private PlayerController playerController;

    private void Awake()
    {
        aniamtor = GetComponent<Animator>();
        inputManager = GetComponent<InputManager>();
        playerController = GetComponent<PlayerController>();
    }
 
    void Update()
    {
        ProcessAnimation();
    }

    public void ProcessAnimation()
    {
        bool isRunning = playerController.IsWalking() && inputManager.isRunning;
        aniamtor.SetBool("IsWalking", playerController.IsWalking());
        aniamtor.SetBool("IsRunning", isRunning);  
    }
}
