using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // Hold rigidbody 2D
    Rigidbody2D rigidBody;

    // Varibles of direction, force and degrees
    Vector2 thrustDirection;
    float ThrustForce = 5;
    float rotateDegreesPerSecond = 200;

    //get radious of Circle Colider 2D
    float radiousOfCircleCollider;

    /// <summary>
    /// A ship will destroy all rocks!
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        //RigidBody 2D
        rigidBody = GetComponent<Rigidbody2D>();

        //Circle Collider 2D
        CircleCollider2D circleCollider = GetComponent<CircleCollider2D>();
        radiousOfCircleCollider = circleCollider.radius;

    }

    // Update is called once per frame
    void Update()
    {
        // calculate rotation amount and apply rotation
        float rotationInput = Input.GetAxis("Rotate");
        float rotationAmount = rotateDegreesPerSecond * Time.deltaTime;

        if (rotationInput != 0)
        {
            float radians = transform.eulerAngles.z * Mathf.Deg2Rad;
            thrustDirection.x = Mathf.Cos(radians);
            thrustDirection.y = Mathf.Sin(radians);
            if (rotationInput < 0)
            {
                rotationAmount *= -1;
                transform.Rotate(Vector3.forward, rotationAmount);
            }
            else if (rotationInput > 0)
            {
                transform.Rotate(Vector3.forward, rotationAmount);
            }
        }
    }

    void FixedUpdate()
    {
        // Apply yhe Thrust
        if(Input.GetAxis("Thrust") > 0)
        {
            rigidBody.AddForce(ThrustForce * thrustDirection, ForceMode2D.Force);
        }
    }

    void OnBecameInvisible()
    {
        //Find screen limits
        Vector2 position = transform.position;
        if (position.x - radiousOfCircleCollider < ScreenUtils.ScreenLeft)
        {
            position.x = -position.x;
        }
        else if (position.x + radiousOfCircleCollider > ScreenUtils.ScreenRight)
        {
            position.x = -position.x;
        }
        if (position.y + radiousOfCircleCollider > ScreenUtils.ScreenTop)
        {
            position.y = -position.y;
        }
        else if (position.y - radiousOfCircleCollider < ScreenUtils.ScreenBottom)
        {
            position.y = -position.y;
        }
        transform.position = position;
    }


}
