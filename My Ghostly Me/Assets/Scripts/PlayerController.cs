using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    [Range(1, 5)]
    float speed;

    float moveX;
    float moveY;
    Vector2 move;

    Rigidbody2D rb;
    PolygonCollider2D coll;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<PolygonCollider2D>();
    }

    void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        move = new Vector2(moveX * speed, moveY * speed);

        rb.AddForce(move);
    }
}
