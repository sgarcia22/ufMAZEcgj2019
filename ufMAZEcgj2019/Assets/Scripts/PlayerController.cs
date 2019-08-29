using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private GeneralInput controls;
    private Vector2 move;
    private Vector2 look;
    private float cameraAngle = 0f;
    private Interactable interactableWithinReach;

    public bool alive;

    [SerializeField] private float movementSpeed = 10f;
    [SerializeField] private float horizontalCameraSensitivity = 4f;
    [SerializeField] private float verticalCameraSensitivity = 2f;
    [SerializeField] private float minCameraAngle = -120f;
    [SerializeField] private float maxCameraAngle = 120f;
    [SerializeField] private float jumpHeight = 10f;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Rigidbody rigidBody;

    public void Awake()
    {
        controls = new GeneralInput();
        mainCamera = transform.GetComponentInChildren<Camera>();
        rigidBody = transform.GetComponentInChildren<Rigidbody>();
        interactableWithinReach = null;
        Cursor.lockState = CursorLockMode.Locked;
        alive = true;
    }

    public void Update()
    {
        if (!alive)
            return;

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
        controls.KeyboardInput.Jump.performed += PlayerJump;
        controls.KeyboardInput.Interact.performed += PlayerInteract;
        controls.KeyboardInput.Enable();

        controls.MouseInput.VerticalLook.performed += VerticalLookInput;
        controls.MouseInput.HorizontalLook.performed += HorizontalLookInput;
        controls.MouseInput.Enable();
    }

    public void OnDisable()
    {
        controls.KeyboardInput.ForwardBackwardMovement.performed -= ForwardBackwardMovementInput;
        controls.KeyboardInput.SidewaysMovement.performed -= SidewaysMovementInput;
        controls.KeyboardInput.Jump.performed -= PlayerJump;
        controls.KeyboardInput.Interact.performed -= PlayerInteract;
        controls.KeyboardInput.Disable();

        controls.MouseInput.VerticalLook.performed -= VerticalLookInput;
        controls.MouseInput.HorizontalLook.performed -= HorizontalLookInput;
        controls.MouseInput.Disable();
    }

    public void setInteractableWithinReach(Interactable interactable)
    {
        interactableWithinReach = interactable;
    }

    public void removeInteractableWithinReach(Interactable interactable)
    {
        if(interactableWithinReach = interactable)
        {
            interactableWithinReach = null;
        }
    }

    private void PlayerMovement()
    {
        Vector3 appliedMovement = Vector3.zero;
        appliedMovement += transform.forward * movementSpeed * Time.deltaTime * move.y;
        appliedMovement += transform.right * movementSpeed * Time.deltaTime * move.x;
        transform.Translate(appliedMovement, Space.World);
    }

    private void PlayerInteract(InputAction.CallbackContext ctx)
    {
        if (interactableWithinReach != null)
        {
            interactableWithinReach.Interact();
        }
    }

    private void PlayerRotationUpdate()
    {
        float rotateAngle = look.x * Time.deltaTime * horizontalCameraSensitivity;
        transform.Rotate(transform.up, rotateAngle);
        look.x = 0f;
    }

    private void PlayerCameraUpdate()
    {
        cameraAngle += look.y * Time.deltaTime * verticalCameraSensitivity;
        cameraAngle = Mathf.Clamp(cameraAngle, minCameraAngle, maxCameraAngle);
        mainCamera.transform.localEulerAngles = new Vector3(-cameraAngle, 0f, 0f);
        look.y = 0f;
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

    private void PlayerJump(InputAction.CallbackContext ctx)
    {
        rigidBody.AddForce(new Vector3(0f, jumpHeight, 0f));
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            alive = false;
            Debug.Log("Rip Player");
            //TODO: Game Over Here
        }
    }
}
