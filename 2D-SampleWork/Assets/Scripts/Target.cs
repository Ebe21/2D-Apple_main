using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float minSpeed = 10;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 7.5f;
    private float yPos = -4.5f;

    public int pointsValue;

    private GameManager gm;

    private Rigidbody targetRb;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        targetRb.AddForce(RandomForce(),ForceMode.Impulse);
        targetRb.AddTorque(TorqueForce(),TorqueForce(), TorqueForce());
        transform.position = RandomPos();

        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float TorqueForce()
    {
        return Random.Range(maxTorque, -maxTorque);
    }

    Vector3 RandomPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), yPos);
    }


    private void OnMouseDown() // destroya upon mouse click
    {
        if(gm.isGameActive)
        {
            Destroy(gameObject);
            gm.scoreAdd(pointsValue);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Avoid"))
        {
            Debug.Log("Triggered by: " + other.gameObject.name + " | Tag: " + other.gameObject.tag);
            Debug.Log("Collided");
            gm.GameOver();
        }
        //Destroy(other.gameObject);
    }

}
