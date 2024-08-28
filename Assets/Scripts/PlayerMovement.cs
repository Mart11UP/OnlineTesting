using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10;
    float input;
    PlayerInput playerInput;
    Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input = playerInput.actions["Movement"].ReadValue<float>();
    }

    private void FixedUpdate()
    {
        Vector2 velocity = new(input * speed, rb2D.velocity.y);
        rb2D.velocity = velocity;
    }
}
