using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float health = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.left;
    }

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if(collision.gameObject.tag == "BulletTower") {
    //         health -= 25;
    //         if(health <= 0) {
    //             Destroy(gameObject);
    //         }
    //         Destroy(collision.gameObject);
    //     }
    // }
}
