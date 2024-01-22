using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody2D;
    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }
    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= 5;

        _rigidbody2D.velocity = direction;
    }
}

//[SerializeField] private float speed = 5f;
//public SpriteRenderer spriteRenderer;
//// Start is called before the first frame update
//void Start()
//{
//    spriteRenderer = GetComponent<SpriteRenderer>();
//}

//// Update is called once per frame
//void Update()
//{
//    float x = Input.GetAxisRaw("Horizontal");
//    float y = Input.GetAxisRaw("Vertical");

//    transform.position += (new Vector3(x, y)).normalized * speed * Time.deltaTime;

//    Vector3 mousePos = Input.mousePosition;

//    if (mousePos.x > Screen.width / 2)
//    {
//        spriteRenderer.flipX = false;
//    }
//    else if (mousePos.x < Screen.width / 2)
//    {
//        spriteRenderer.flipX = true;
//    }

//}
