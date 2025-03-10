using Fusion;
using Fusion.Addons.Physics;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{

    [SerializeField] private float PlayerSpeed = 5f;
    [SerializeField] private float JumpForce = 5f;
    [SerializeField] private float SprintSpeedScale = 1.5f;
    [SerializeField] private Camera Camera;
    
    private Rigidbody rb;
    private Vector3 moveInput;
    private bool jumpPressed;
    private bool sprintPressed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!HasStateAuthority) return;

        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (Input.GetButtonDown("Jump"))
        {
            jumpPressed = true;
        }

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            sprintPressed = true;
        }
    }

    public override void FixedUpdateNetwork()
    {
        if (!HasStateAuthority) return;

        Quaternion cameraRotationY = Quaternion.Euler(0, Camera.transform.rotation.eulerAngles.y, 0);
        Vector3 moveDirection = cameraRotationY * moveInput * (sprintPressed ? SprintSpeedScale : 1f);

        rb.velocity = new Vector3(moveDirection.x * PlayerSpeed, rb.velocity.y, moveDirection.z * PlayerSpeed);

        if (jumpPressed && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);
        }

        if (moveDirection.magnitude > 0.1f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirection), 0.1f);
        }

        jumpPressed = false;
        sprintPressed = false;
    }

    public override void Spawned()
    {
        if (HasStateAuthority)
        {
            Camera = Camera.main;
            if (Camera != null)
            {
                ThirdPersonCamera camScript = Camera.GetComponent<ThirdPersonCamera>();
                if (camScript != null)
                {
                    camScript.Target = transform;
                }
            }
        }
    }
}