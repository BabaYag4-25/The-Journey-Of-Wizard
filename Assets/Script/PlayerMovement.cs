using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float jumpSpeed, playerSpeed;

    private bool isJumping;
    private float move;
    private Rigidbody2D rb;
    private Animator anim;
    public GameObject bullet;
    public float Force;
    Vector3 dir;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * playerSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.M))
        {
            Shoot();
        }

        if (move < 0)
        {
            dir = Quaternion.AngleAxis(180, Vector3.forward) * Vector3.right;
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (move > 0)
        {
            dir = Quaternion.AngleAxis(0, Vector3.forward) * Vector3.right;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
            isJumping = true;
        }

        RunAnimations();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    void RunAnimations()
    {
        anim.SetFloat("Movement", Mathf.Abs(move));
        anim.SetBool("isJumping", isJumping);
    }

    void Shoot()
    {
        GameObject Shoot = Instantiate(bullet, transform.position, transform.rotation);
        Rigidbody2D rb = Shoot.GetComponent<Rigidbody2D>();

        rb.AddForce(dir * Force, ForceMode2D.Impulse);

    }

}