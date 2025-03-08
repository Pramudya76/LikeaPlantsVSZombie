using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShot : MonoBehaviour
{
    public GameObject bulletPrefabs;
    private Transform EnemyPosition;
    private bool isShot = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject[] musuh = GameObject.FindGameObjectsWithTag("Enemy"); 
        float minDistance = Mathf.Infinity;
        Transform closeEnemy = null;
        if(collision.gameObject.tag == "Enemy") {
            foreach(GameObject enemy in musuh) {
                float distance = Vector2.Distance(transform.position,enemy.transform.position);
                if(distance < minDistance) {
                    minDistance = distance;
                    closeEnemy = enemy.transform;
                }
            }

            if(closeEnemy != null && isShot) {
                GameObject bulletShot = Instantiate(bulletPrefabs, transform.position, Quaternion.identity);
                bulletShot.GetComponent<Rigidbody2D>().velocity = Vector2.right * 3f;
                isShot = false;
                StartCoroutine(CDShot());
            }



        }
    }

    IEnumerator CDShot() {
        yield return new WaitForSeconds(2.5f);
        isShot = true;
    }

}
