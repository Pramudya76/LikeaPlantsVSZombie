using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    private EnemyMovement EM;
    // Start is called before the first frame update
    void Start()
    {
        GameObject enemy = GameObject.FindWithTag("Enemy");
        EM = enemy.GetComponent<EnemyMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy") {
            EM.health -= 25f;
            if(EM.health <= 0) {
                Destroy(collision.gameObject);
                Debug.Log("Heath : " + EM.health);
            }
            Destroy(gameObject);
            Debug.Log("Hancur");
        }
    }
}
