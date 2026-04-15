using UnityEngine;

public class TopDownPlayerMovement : MonoBehaviour

{
    public float moveSpeed;
    public SpriteRenderer spr;
    public Sprite lookRightImage;
    public Sprite lookUpImage;
    private float horizontalInput;
    private float verticalInput;
    public Rigidbody2D rb;
    public Vector2 playerDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rb.position += Vector2.right * horizontalInput * moveSpeed * Time.fixedDeltaTime;
        rb.position += Vector2.up * verticalInput * moveSpeed * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.LeftControl))
        {
            rb.position += Vector2.right * horizontalInput * moveSpeed * 2 * Time.fixedDeltaTime;
            rb.position += Vector2.up * verticalInput * moveSpeed * 2 * Time.fixedDeltaTime;
        }
        if (horizontalInput < 0)
        {
            spr.sprite = lookRightImage;
            spr.flipX = true;
            playerDirection = Vector2.right;
        }
        if (horizontalInput > 0)
        {
            spr.sprite = lookRightImage;
            spr.flipX = false;
            playerDirection = Vector2.left;
        }
         if (verticalInput < 0)
        {
            spr.sprite = lookUpImage;
            spr.flipY = true;
            playerDirection = Vector2.up;
        }
        if (verticalInput > 0)
        {
            spr.sprite = lookUpImage;
            spr.flipY = false;
            playerDirection = Vector2.down;
        }
    }
}
