using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{   
    private Rigidbody2D rb2D;
    private float jumpForce;
    private bool jumpState = false;
    float moveVertical;
    public bool isDED;
  
    // Start is called before the first frame update
    void Start()
    {   
        isDED = false;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        jumpForce = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        moveVertical = Input.GetAxisRaw("Vertical");
        if(transform.position[1] < -10 || transform.position[1] > 10 ){
            isDED = true;
            SceneManager.LoadScene(2);
        }

    }
    
    void FixedUpdate()
    {   
        if (moveVertical == 0 && jumpState == true){
            jumpState = false;
        }
        if (moveVertical == 1 && jumpState == false){
                
            rb2D.AddForce(new Vector2(0F, moveVertical * jumpForce), ForceMode2D.Impulse);
            jumpState = true;
        }

        
        
    }

    private void OnCollisionEnter2D(Collision2D collider){

        isDED = true;
        SceneManager.LoadScene(2);

    }
}

