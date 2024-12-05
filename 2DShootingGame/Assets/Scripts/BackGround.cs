using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private Vector2 startPos;
    private float width;

    private void Start()
    {
        startPos = transform.position;
        width = GetComponent<BoxCollider2D>().size.x / 2 * transform.localScale.x;
    }

    private void FixedUpdate()
    {
        if (transform.position.x < startPos.x - width)
            transform.position = startPos;
        transform.position = new Vector2(transform.position.x - 2.0f, transform.position.y);
    }
}
