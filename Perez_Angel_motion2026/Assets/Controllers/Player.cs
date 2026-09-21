using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;

    

    public Vector3 currentVelocity = Vector3.right;

    public float maxspeed;

    public float accelerationTime;

    public float currentAcceleration;

    public float decelerationTime;

    public float deceleration;

    private void Start()
    {
        currentAcceleration = maxspeed / accelerationTime;

        deceleration = maxspeed / decelerationTime;
    }
    void Update()
    {
        PlayerMovement();

        // transform.position = transform.position + currentVelocity;
    }

    public void PlayerMovement()
    {
        Vector3 aDirection = Vector3.zero;

        if (Keyboard.current.upArrowKey.isPressed)
        {
            aDirection += Vector3.up;

        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            aDirection += Vector3.left;
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            aDirection += Vector3.right;
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            aDirection += Vector3.down;
        }
        currentVelocity += aDirection.normalized * currentAcceleration *Time.deltaTime;

        if(currentVelocity.magnitude > maxspeed)
        {
            currentVelocity = currentVelocity.normalized * maxspeed;
        }

        transform.position = transform.position + currentVelocity * Time.deltaTime;


    }
}
