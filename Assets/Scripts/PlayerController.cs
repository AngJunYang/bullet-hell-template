using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;

    public float horizontal;
    public float vertical;

    public static PlayerController playerController;

    public float runSpeed = 15.0f;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        playerController = this;
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal, vertical) * runSpeed * Time.fixedDeltaTime;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        BulletController bullet = col.gameObject.GetComponentInParent<BulletController>();
        if (bullet != null)
        {

        }
    }


}