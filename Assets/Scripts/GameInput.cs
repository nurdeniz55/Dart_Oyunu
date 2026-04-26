using System;
using UnityEngine;
using UnityEngine.Animations;

public class GameInput : MonoBehaviour
{
    public static GameInput Instance { get; private set; }
    public event EventHandler OnShootAction;
    private PlayerInputActions playerInputActions;
    private void Awake()
    {
        Instance = this;
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Shoot.performed += Shoot_performed;
    }

    private void Shoot_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
       OnShootAction?.Invoke(this, EventArgs.Empty);
    }
    public Vector2 GetMouseInputX()
    {
        Vector2 inputVector = playerInputActions.Player.LookX.ReadValue<Vector2>();
        Debug.Log(inputVector);
        return inputVector;
    }
}
