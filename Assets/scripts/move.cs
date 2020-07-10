using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 4f;
    Vector2 mov;
    Rigidbody2D rb;
    Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        mov = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"));
        if(mov!= Vector2.zero)
        {
            anim.SetFloat("moveX",mov.x);
            anim.SetFloat("moveY", mov.y);
        }
        
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + mov * speed * Time.deltaTime);
    }
}
