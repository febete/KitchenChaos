using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameInput : MonoBehaviour
{

    public event EventHandler OnInteractAction;


    PlayerInputActions playerInputActions;


    private void Awake()
    {
        playerInputActions =  new PlayerInputActions();
        playerInputActions.Player.Enable();

        playerInputActions.Player.Interact.performed += Interact_performed;
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnInteractAction?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetMovementVectorNormalized()
    {

       
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();



        //sa�a sola ayn� anda t�klanmamas� i�in , birim vekt�r haline getiriyor
        inputVector = inputVector.normalized;

        //Debug.Log(inputVector);

        return inputVector;
    }




}
