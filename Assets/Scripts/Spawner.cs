using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Bird birdScript;
    public GameObject woods;
    public float height;
    void Start()
    {
        StartCoroutine(SpawnObject());
    }


    void Update()
    {

    }

    public IEnumerator SpawnObject()
    {
        while (!birdScript.isDead)
        {
            Instantiate(woods, new Vector3(4, Random.Range(-height, height), 0),Quaternion.identity);
            yield return new WaitForSeconds(3);
        }


    }
}
