using UnityEngine;

public class objec : MonoBehaviour{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public int counter = 0;
    public Player player;
    System.Random rnd = new System.Random();
    
    
    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

    // Update is called once per frame
    void Update () {
        if (player.isDED == true){
            speed = 0;
            if (counter > PlayerPrefs.GetInt("highscore", 0)){
                PlayerPrefs.SetInt("highscore", counter);
            }
        }
        if(transform.position[0] < -10){
            counter += 1;
            if (counter % 5 == 0){speed += speed * 0.1f;}
            transform.position = new Vector3(10,rnd.Next(-3, 3),0);
            rb.velocity = new Vector2(-speed, 0);

        }
    }
}
