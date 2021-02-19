using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WheelController : MonoBehaviour
{
    private Rigidbody wheel_rb;
    private CapsuleCollider wheel_collider;
    public GameObject[] wheel_Spokes;
    public bool IsPressed = false;

    public void Awake()
    {
        wheel_rb = GetComponent<Rigidbody>();
        wheel_collider = GetComponent<CapsuleCollider>();
    }

    public void Update()
    {
        wheel_rb.angularVelocity = transform.right * 10;
    }

    public void FixedUpdate()
    {
        if(wheel_collider.radius > 1 && !IsPressed)
        {
            wheel_collider.radius -= Time.fixedDeltaTime;
            wheel_Spokes[0].transform.localScale = new Vector3(0.25f, (wheel_collider.radius - 1) / 2, 0.25f);
            wheel_Spokes[1].transform.localScale = new Vector3(0.25f, (wheel_collider.radius - 1) / 2, 0.25f);
            wheel_Spokes[2].transform.localScale = new Vector3(0.25f, (wheel_collider.radius - 1) / 2, 0.25f);
            wheel_Spokes[3].transform.localScale = new Vector3(0.25f, (wheel_collider.radius - 1) / 2, 0.25f);

        }
        if (IsPressed)
        {
            wheel_collider.radius += Time.fixedDeltaTime;
            wheel_Spokes[0].transform.localScale = new Vector3(0.25f, (wheel_collider.radius - 1) / 2, 0.25f);
            wheel_Spokes[1].transform.localScale = new Vector3(0.25f, (wheel_collider.radius - 1) / 2, 0.25f);
            wheel_Spokes[2].transform.localScale = new Vector3(0.25f, (wheel_collider.radius - 1) / 2, 0.25f);
            wheel_Spokes[3].transform.localScale = new Vector3(0.25f, (wheel_collider.radius - 1) / 2, 0.25f);
        }
    }

    public void Input(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            IsPressed = true;
        }
        if(context.canceled)
        {
            IsPressed = false;
        }
       
    }

}

