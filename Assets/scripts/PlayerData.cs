using UnityEngine;

public class playerData : MonoBehaviour
{
    public int keysCollected;
    public GameObject Door;
    public Rigidbody2D rb;
    public int playerLayer;
    public TopDownPlayerMovement data;
    public Vector2 playerDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerLayer = 7;
        playerLayer = ~playerLayer;
    }

    // Update is called once per frame
    void FixedUpdateUpdate()
    {
        if(keysCollected >= 5)
        {
            if(Input.GetKey(KeyCode.F))
            {
                RaycastHit2D hit = Physics2D.Raycast(transform.position, playerDirection, 5f, playerLayer);
                if(hit)
                {
                    Destroy(Door);
                    Debug.Log("Guten Job lil bro");
                }
                else
                {
                    Debug.Log("Nada");
                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Key")
        {
           // adds to counter on collection
            keysCollected += 1;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Button")
        {
            Debug.Log("you did the button");
        }
    }
}
