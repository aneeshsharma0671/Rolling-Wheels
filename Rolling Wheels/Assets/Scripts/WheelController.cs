using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WheelController : MonoBehaviour
{
    public float radius_Limit=4.5f ;
    public float radius_multiplier = 2f;
    public float angular_Velocity = 10f;
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
        wheel_rb.angularVelocity = transform.right * angular_Velocity;
        Debug.Log(wheel_rb.angularVelocity);
    }

    public void FixedUpdate()
    {
        if(wheel_collider.radius > 1 && !IsPressed)
        {
            wheel_collider.radius -= Time.fixedDeltaTime*radius_multiplier;
            wheel_Spokes[0].transform.localScale = new Vector3(0.25f, (wheel_collider.radius - 1) / 2, 0.25f);
            wheel_Spokes[1].transform.localScale = new Vector3(0.25f, (wheel_collider.radius - 1) / 2, 0.25f);
            wheel_Spokes[2].transform.localScale = new Vector3(0.25f, (wheel_collider.radius - 1) / 2, 0.25f);
            wheel_Spokes[3].transform.localScale = new Vector3(0.25f, (wheel_collider.radius - 1) / 2, 0.25f);

        }
        if (wheel_collider.radius < radius_Limit && IsPressed)
        {
            wheel_collider.radius += Time.fixedDeltaTime*radius_multiplier;
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

