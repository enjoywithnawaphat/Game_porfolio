using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private CameraSwitch cameraSwitch;
    private Vector3 playerVelocity;
    public bool isGrounded;
    [SerializeField] public float speed = 2f;
    [SerializeField] private float gravity = -9.8f;
    [SerializeField] private float jumpHeight = 0.4f;
    [SerializeField] private Transform cameraTransform;
    private float rotateSpeed = 10f;
    private Animator animator;
    private bool camType;
    private bool isWalking;

    private Inventory inventory;
    [SerializeField] private UI_Invetory uiInvetory;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        cameraSwitch = GetComponent<CameraSwitch>();

        inventory = new Inventory();
        uiInvetory.SetInventory(inventory);
    }

    public void AddItem(Item.ItemType item, int amount)
    {
        inventory.AddItem(new Item { itemType = item, amount = amount } );
    }


    void Update()
    {
        isGrounded = controller.isGrounded;
        animator.SetBool("IsGrounded", isGrounded);
        camType = cameraSwitch.isFristPerson;
    }

    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDir = Vector3.zero;
        moveDir = cameraTransform.forward * input.y
        + cameraTransform.right * input.x;

        moveDir.y = 0f;
        controller.Move(moveDir * speed * Time.deltaTime);

        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }
        playerVelocity.y += gravity * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        isWalking = moveDir != Vector3.zero;
        if (input.y > 0.01f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDir, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotateSpeed);
        }
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
            animator.SetTrigger("Jump");
        }
    }
    public bool IsWalking()
    {
        return isWalking;
    }
}
