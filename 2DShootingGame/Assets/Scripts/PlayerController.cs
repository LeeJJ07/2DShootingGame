using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigid;

    [SerializeField] private Image imgHPBar;

    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private int playerHP = 100;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

        playerHP = 100;
    }

    void Update()
    {
        SetHPBar(playerHP);
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 pos = rigid.transform.position;
        rigid.MovePosition(pos + new Vector2(x * moveSpeed, y * moveSpeed));
    }

    private void SetHPBar(int hp)
    {
        imgHPBar.fillAmount = (float)hp / 100;
    }
}
