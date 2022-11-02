using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{ 
    PlayerAction inputAction;
    Vector3 move;
    Rigidbody rb;

    public float walkSpeed = 5f;
    public Camera playerCamera;

    private void Awake()
    {
        inputAction = new PlayerAction();
        //inputAction = PlayerInputController.controller.InputAction;
        //PlayerInputController.controller.InputAction.Player.Walk.performed += cntxt => move = cntxt.ReadValue<Vector2>();
        //PlayerInputController.controller.InputAction.Player.Walk.canceled += cntxt => move = Vector2.zero;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * move.x * walkSpeed, Space.Self);
        transform.Translate(Vector3.up * Time.deltaTime * move.y * walkSpeed, Space.Self);

        Vector3 m = new Vector3(move.x, move.y, 0);
    }
}
