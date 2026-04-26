using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    public bool CanLook { get; private set; } = true;

    [Header("Look Parameters")]
    [SerializeField, Range(1, 10)] private float lockSpeedX = 10f;
    [SerializeField, Range(1, 10)] private float lockSpeedY = 10f;
    [SerializeField, Range(1, 180)] private float upperLookLimit = 80f;
    [SerializeField, Range(1, 180)] private float lowerLookLimit = 80f;

    private Camera playerCamera;
    private CharacterController characterController;

    private float rotationX = 0;

    private void Awake()
    {
        playerCamera = GetComponentInChildren<Camera>();
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        if (CanLook)
        {
            HandleMouseLook();
        }
    }

    private void HandleMouseLook()
    {
        Debug.Log(GameInput.Instance.GetMouseInputX().x);
        rotationX -= GameInput.Instance.GetMouseInputX().y * lockSpeedY*Time.deltaTime;
        rotationX = Mathf.Clamp(rotationX, -upperLookLimit, lowerLookLimit);
        playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.rotation *= Quaternion.Euler(0, GameInput.Instance.GetMouseInputX().x * lockSpeedX * Time.deltaTime, 0);
    }


}

