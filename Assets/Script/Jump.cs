using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [Header("참조")]
    public Rigidbody2D rigid;
    [Header("설정")]
    public float jumpPower = 1f;
    public float groundCheckDistance = 1f;
    public LayerMask groundLayer;
    private bool isGrounded;


    void Update()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) { 
            rigid.AddForce(jumpPower * Vector2.up, ForceMode2D.Impulse);
        }
    }
}
