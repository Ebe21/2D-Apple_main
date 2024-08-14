using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb1: MonoBehaviour
{
    public float launchForce;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * launchForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Destroyer"))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnMouseDown()
    {
        
        Time.timeScale = 0;
        Destroy(gameObject);
    }
}
