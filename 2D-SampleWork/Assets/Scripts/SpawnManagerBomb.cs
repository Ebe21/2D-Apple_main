using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerBomb : MonoBehaviour
{
    public GameObject spawn;
    public GameObject bomb;
    int random;
    private float length = 2000;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(9, 20);
        StartCoroutine(SpawnCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnCoroutine()
    {
        for (int i = 0; i < length; i++)
        {
            yield return new WaitForSeconds(random);
            Instantiate(bomb,spawn.transform.position, Quaternion.identity);
        }
    }
}
