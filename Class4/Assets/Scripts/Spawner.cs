using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnemyOne;
    public GameObject EnemyTwo;

    void Spawn()
    {
        //=======
        // if you are using 2 enmeys 
        GameObject spawnObject;
        int choice = Random.Range(0, 2);
        if (choice == 1)
            spawnObject = EnemyOne;
        else
            spawnObject = EnemyTwo;
        //=======

        int newPostion = Random.Range(-1, 2);
        Vector3 vPostion = transform.position;
        vPostion.x = vPostion.x + (5 * newPostion);

        // This 
        GameObject newSpawn = Instantiate(spawnObject);
        newSpawn.transform.position = vPostion;
        // or this
        //GameObject newSpawn = Instantiate(spawnObject, vPostion, Quaternion.identity);
    }


    // Start is called before the first frame update
    void Start()
    {
        // for any ,etjond , how much time 
        InvokeRepeating("Spawn", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}