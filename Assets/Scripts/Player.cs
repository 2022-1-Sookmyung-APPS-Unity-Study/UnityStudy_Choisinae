using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private float input;

    Rigidbody2D rb;
    Animator sinae;

    public int health;

    // Start is called before the first frame update
    void Start()
    {   sinae = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();    
    }

    
    // Update is called once per frame
    void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Horizontal");

        if (input != 0)
        {
            sinae.SetBool("isRunning", true);
        }
        else {
            sinae.SetBool("isRunning", false);
        }

        if (input > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (input < 0) {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }

    public void TakeDamage(int damageAmount) {
        health -= damageAmount;

        if(health <= 0) {
            Destroy(gameObject);
        }
    }
}
