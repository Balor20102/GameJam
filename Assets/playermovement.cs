using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed;
    private float Move;

    public Animator animator; 

    public float jump;

    public bool isJumping;


    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D> ();

    }

    // Update is called once per frame
    void Update()
    {
        
        Move = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(speed * Move));

        bool flipped = speed < 0;
        this.transform.rotation = Quaternion.Euler(new Vector3(0f, flipped ? 180f : 0f, 0f));

        rb.velocity = new Vector2 (speed * Move, rb.velocity.y);

        if(Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        animator.SetBool("jumping", false);
        if(other.gameObject.CompareTag("Ground")){
            isJumping = false; 
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        animator.SetBool("jumping", true);
        if (other.gameObject.CompareTag("Ground")){
                    isJumping = true; 
         }
    }
}
