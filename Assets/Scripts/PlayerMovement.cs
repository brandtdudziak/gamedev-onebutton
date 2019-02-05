using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    public Sprite fallenSprite;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveLeft()
    {
        Move(-1);
    }

    public void MoveRight()
    {
        Move(1);
    }

    void Move(int dir)
    {
        transform.position += Vector3.right * 1 * dir;
    }

    public void PlayerLose()
    {
        spriteRenderer.sprite = fallenSprite;
    }
}
