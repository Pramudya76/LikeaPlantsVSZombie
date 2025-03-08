using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] RandomLocation;
    public GameObject EnemyPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        //jikaInvokeRepeating hanya bisa 1 waktu saja tidak bisa beberapa waktu
        //InvokeRepeating(nameof(SpawnedEnemy),0,TimeSpawn);
        StartCoroutine(CDSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnedEnemy() {
        int randomLocation = Random.Range(0,3);
        Instantiate(EnemyPrefabs, RandomLocation[randomLocation].transform.position, Quaternion.identity);

    }

    IEnumerator CDSpawn() {
        while(true) {
            SpawnedEnemy();
            int TimeSpawn = Random.Range(3,15);
            yield return new WaitForSeconds(TimeSpawn);
        }
    }

}
