using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private GeneralInput controls;
    private Vector2 move;
    private Vector2 look;
    private float cameraAngle = 0f;

    [SerializeField] private float movementSpeed = 10f;
    [SerializeField] private float horizontalCameraSensitivity = 4f;
    [SerializeField] private float verticalCameraSensitivity = 2f;
    [SerializeField] private float minCameraAngle = -120f;
    [SerializeField] private float maxCameraAngle = 120f;
    [SerializeField] private Camera mainCamera;

    public void Awake()
    {
        controls = new GeneralInput();
        mainCamera = transform.GetComponentInChildren<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Update()
    {
        if (move != Vector2.zero)
        {
            PlayerMovement();
        }

        PlayerRotationUpdate();
        PlayerCameraUpdate();
    }

    public void OnEnable()
    {
        controls.KeyboardInput.ForwardBackwardMovement.performed += ForwardBackwardMovementInput;
        controls.KeyboardInput.SidewaysMovement.performed += SidewaysMovementInput;
        controls.KeyboardInput.Enable();

        controls.MouseInput.VerticalLook.performed += VerticalLookInput;
        controls.MouseInput.HorizontalLook.performed += HorizontalLookInput;
        controls.MouseInput.Enable();
    }

    public void OnDisable()
    {
        controls.KeyboardInput.ForwardBackwardMovement.performed -= ForwardBackwardMovementInput;
        controls.KeyboardInput.SidewaysMovement.performed -= SidewaysMovementInput;
        controls.KeyboardInput.Disable();

        controls.MouseInput.VerticalLook.performed -= VerticalLookInput;
        controls.MouseInput.HorizontalLook.performed -= HorizontalLookInput;
        controls.MouseInput.Disable();
    }

    private void PlayerMovement()
    {
        Vector3 appliedMovement = Vector3.zero;
        appliedMovement += transform.forward * movementSpeed * Time.deltaTime * move.y;
        appliedMovement += transform.right * movementSpeed * Time.deltaTime * move.x;
        // Remove comment if we want gravity.
        // appliedMovement += Physics.gravity;
        transform.Translate(appliedMovement, Space.World);
    }

    private void PlayerRotationUpdate()
    {
        float rotateAngle = look.x * Time.deltaTime * horizontalCameraSensitivity;
        transform.Rotate(transform.up, rotateAngle);
    }

    private void PlayerCameraUpdate()
    {
        cameraAngle += look.y * Time.deltaTime * verticalCameraSensitivity;
        cameraAngle = Mathf.Clamp(cameraAngle, minCameraAngle, maxCameraAngle);
        mainCamera.transform.localEulerAngles = new Vector3(-cameraAngle, 0f, 0f);
    }

    private void VerticalLookInput(InputAction.CallbackContext ctx)
    {
        look.y = ctx.ReadValue<float>();
    }

    private void HorizontalLookInput(InputAction.CallbackContext ctx)
    {
        look.x = ctx.ReadValue<float>();
    }

    private void ForwardBackwardMovementInput(InputAction.CallbackContext ctx)
    {
        move.y = ctx.ReadValue<float>();
    }

    private void SidewaysMovementInput(InputAction.CallbackContext ctx)
    {
        move.x = ctx.ReadValue<float>();
    }
}
