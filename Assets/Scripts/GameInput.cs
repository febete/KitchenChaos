using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    PlayerInputActions playerInputActions;


    private void Awake()
    {
        playerInputActions =  new PlayerInputActions();
        playerInputActions.Player.Enable();
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
