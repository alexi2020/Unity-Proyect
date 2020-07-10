using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRight : MonoBehaviour { 
    public float maxspeed;
    Rigidbody2D caballero;
    Animator anim;
  
   


    // Start is called before the first frame update
    void Start()
    {
        caballero=GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
     
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        caballero.velocity = new Vector2(move * maxspeed, caballero.velocity.y);

        anim.SetFloat("velMoviment", move);



    }
    
 
        
    
}
