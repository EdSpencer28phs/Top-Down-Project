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
        if (horizontalInput < 0)
        {
            spr.sprite = lookRightImage;
            spr.flipX = true;
        }
        if (horizontalInput > 0)
        {
            spr.sprite = lookRightImage;
            spr.flipX = false;
        }
         if (verticalInput < 0)
        {
            spr.sprite = lookUpImage;
            spr.flipY = true;
        }
        if (verticalInput > 0)
        {
            spr.sprite = lookUpImage;
            spr.flipY = false;
        }
    }
}
