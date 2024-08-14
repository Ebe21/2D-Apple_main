using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Apple : MonoBehaviour
{
    public float launchForce;
    public Rigidbody2D rb;
    public TextMeshProUGUI Score;
    public int Scorenum;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.down * launchForce,ForceMode2D.Impulse);
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
        Score.text = "Score" + Scorenum;
        Scorenum++;
        this.gameObject.SetActive(false);
    }
}
