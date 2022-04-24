using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    //Variables
    public float movementSpeed;
    public Rigidbody2D rb;
    public float jumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayers;
    public Animator anim;
    private int crashed;
    float mx;
    [HideInInspector] public bool isFacingRight = true;

    //Controls
    private void Update() {

        //I know that this is a lazy way of moving Left and Right, but hear me out
        //Fuck you
        mx = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.Z) && IsGrounded()) {
            Jump();
        }

        if (Mathf.Abs(mx) > 0.05f) {
            anim.SetBool("isRunning", true);
        } else {
            anim.SetBool("isRunning", false);
        }

        //Changes which way the Character is facing
        if (mx > 0) {
            transform.localScale = new Vector3(1f, 1f, 1f);
            isFacingRight = true;
        } else if (mx < 0) {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            isFacingRight = false;
        }

        anim.SetBool("isGrounded", IsGrounded());
    }

    //Allows the Character to move
    private void FixedUpdate() {

        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

        rb.velocity = movement;

    }

    void Jump() {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
        rb.velocity = movement;
    }

    //Checks if Character is toucning grass
    public bool IsGrounded() {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

        if (groundCheck != null) {
            return true;
        }

        return false;
    }
}
