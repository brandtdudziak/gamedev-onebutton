using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMan1 : MonoBehaviour
{

    public float speed = 5;
    public Rigidbody2D rb2d;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movementHorizontal = 0;
        float movementVertical = 0;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementVertical = 1;
            //spriteRenderer.sprite = sUp;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movementHorizontal = -1;
            //spriteRenderer.sprite = sSide;
            spriteRenderer.flipX = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movementVertical = -1;
            //spriteRenderer.sprite = sDown;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementHorizontal = 1;
            //spriteRenderer.sprite = sSide;
            spriteRenderer.flipX = false;
        }

        rb2d.velocity = new Vector2(movementHorizontal, movementVertical) * speed;
    }
}
