using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    public static PlayerInputController controller;

    public PlayerAction InputAction { get; private set; }

    private void OnEnable()
    {
        InputAction.Enable();
    }

    private void OnDisable()
    {
        InputAction.Disable();
    }

    // Start is called before the first frame update
    void Awake()
    {
        if (controller == null)
        {
            controller = this;
        }

        InputAction = new PlayerAction();
    }
}
