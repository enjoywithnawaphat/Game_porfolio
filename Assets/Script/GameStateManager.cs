using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Gamestate
{
    Playing,
    Dialogue
}

public class GameStateManager : MonoBehaviour
{
    public Gamestate CurrentState { get; private set; }
    [SerializeField] private InputManager inputManager;

    private void Awake()
    {
        CurrentState = Gamestate.Playing;
    }

    private void Start()
    {
        
    }

    public void ChangeState(Gamestate newState)
    {
        CurrentState = newState;
    }

    private void Update()
    {
        switch (CurrentState)
        {
            case Gamestate.Playing:
                inputManager.onFoot.Enable();
                inputManager.dialogue.Disable();
                break;
            case Gamestate.Dialogue:
                inputManager.onFoot.Disable();
                inputManager.dialogue.Enable();
                break;
        }
    }
}
