using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
     Vector2 dest = Vector2.zero;

    private PlayerControl playerControl;
    private Rigidbody2D rb;

    //private SpriteRenderer spriteRenderer;
    
    void Start()
    {
         dest = transform.position;
    }

    private void Awake()
    {
        playerControl = new PlayerControl();
        rb = GetComponent<Rigidbody2D>();
       // spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        playerControl.Enable();
    }

    private void OnDisable()
    {
        playerControl.Disable();
    }
   
    void FixedUpdate()
    {
         //Move closer to Destination
         Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
         GetComponent<Rigidbody2D>().MovePosition(p);

        // Check for Input if not moving
        if ((Vector2)transform.position == dest)
        {
            if (Input.GetKey(KeyCode.W) && valid(Vector2.up))
                dest = (Vector2)transform.position + Vector2.up;
            if (Input.GetKey(KeyCode.D) && valid(Vector2.right))
                dest = (Vector2)transform.position + Vector2.right;
            if (Input.GetKey(KeyCode.S) && valid(-Vector2.up))
                dest = (Vector2)transform.position - Vector2.up;
            if (Input.GetKey(KeyCode.A) && valid(-Vector2.right))
                dest = (Vector2)transform.position - Vector2.right;

            // Movement input
            // Vector2 moveInput = playerControl.Cat.Move.ReadValue<Vector2>();
            //rb.velocity = moveInput * speed;

            //if (new Vector2 (moveInput) < 1)
            //    spriteRenderer.flipx = true;
            // else if (new Vector2 (moveInput) > 1)
            // spriteRenderer.flipx = false;


            // Animation Parameters
            Vector2 dir = dest - (Vector2)transform.position;
            GetComponent<Animator>().SetFloat("DirX", dir.x);
        }

        bool valid(Vector2 dir)
        {
            //  Cast Line from 'next to Pac-Man' to 'Pac-Man';
            Vector2 pos = transform.position;
            RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
            return (hit.collider == GetComponent<Collider2D>());
        }
    }

}
