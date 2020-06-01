using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Random = UnityEngine.Random;

public class Mover : MonoBehaviour
{
    /// <summary>
    /// Moves the game oject
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        // get the game object moving
        /*
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(1,0),
            ForceMode2D.Impulse);
        */

        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);
    }

    /// Called on a colision
    void OnCollisionEnter2D(Collision2D col1)
    {
        print("Ouch");
        /*
        if (col1.gameObject.tag == "Enemy")
            col1.gameObject.SendMessage("Apply Damage", 10);
            */
    }

}
