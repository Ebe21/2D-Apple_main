using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerApple : MonoBehaviour
{
    public GameObject spawn;
    public GameObject apple;
    public GameObject bomb;
    float random;
    private float length = 2000;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(4f, 10f);
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
            Instantiate(apple,spawn.transform.position, Quaternion.identity);
        }
    }
}
