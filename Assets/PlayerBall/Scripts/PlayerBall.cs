using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Collections.Specialized;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBall : MonoBehaviour
{
    [Header("Input Actions")]
    [SerializeField] InputActionReference move;
    [SerializeField] float force;
    [SerializeField] InputActionReference jump;

    Camera cam;

    private Rigidbody rb;
    Vector2 moveValue;
    private void Awake()
    { 
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    private void OnEnable()
    {
        move.action.Enable();
        jump.action.Enable();

        move.action.performed += OnMove;
        move.action.canceled += OnMove;
    }
    void OnMove(InputAction.CallbackContext ctx)
    {
       moveValue = move.action.ReadValue<Vector2>();
    }
    private void OnDisable()
    {
        move.action.Disable();
        jump.action.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
     
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        float moveValueMagnitude = moveValue.magnitude;
        Vector3 camforward = cam.transform.forward;
        Vector3 proyectedF = Vector3.ProjectOnPlane(camforward, Vector3.up);

        Vector3 camRight = cam.transform.right;
        Vector3 proyectedR = Vector3.ProjectOnPlane(camRight, Vector3.up);

        Vector3 movementDirection = (moveValue.y * proyectedF) + (moveValue.x * proyectedR);

        movementDirection = movementDirection.normalized * moveValueMagnitude;

        rb.AddForce(movementDirection * DoubleTheForce(force));
    }
    float DoubleTheForce(float force)
    {
        return MultiplyByTwo(force);
    }
    float MultiplyByTwo(float f)
    {
        return f * 2F;
    }
}
