using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float jumpSpeed, playerSpeed;

    public bool isJumping;
    private bool isShoot;
    private float move;

    [SerializeField]
    private float shootDelay = 1f;

    private Rigidbody2D rb;
    private Animator anim;
    public GameObject bullet;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * playerSpeed, rb.velocity.y);


        if (move < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (move > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isShoot) return;
            anim.Play("shoot_anim");
            isShoot = true;

            GameObject Shoot = Instantiate(bullet, transform.position, transform.rotation);
            Shoot.GetComponent<PeluruScript>().StartShoot(move);

            Invoke("ResetShoot", shootDelay);

        }

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
            isJumping = true;
        }

        RunAnimations();
    }

    void RunAnimations()
    {
        anim.SetFloat("Movement", Mathf.Abs(move));
        anim.SetBool("isJumping", isJumping);
    }

    void ResetShoot()
    {
        isShoot = false;
        anim.Play("idle_anim");
    }

}