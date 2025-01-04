using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using Unity.VisualScripting;
using UnityEngine;

public class Code : MonoBehaviour
{
    public GameObject redFort;
    public GameObject chandniChowk;
    public GameObject jamaMsjid;
    public GameObject indiaGate;
    public GameObject qutubMinar;
    public GameObject lotusTemple;
    public GameObject humayunsTomb;
    public GameObject akshardham;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }


    public void CheckSelection(GameObject selectedObject)
    {
        // Red Fort logic
        if (selectedObject.CompareTag("RedFort"))
        {
            chandniChowk.SetActive(true);
            jamaMsjid.SetActive(true);
            Debug.Log("Perfect choice! These attractions are within comfortable traveling distance.");
        }
        // Qutub Minar logic
        else if (selectedObject.CompareTag("QutubMinar"))
        {
            lotusTemple.SetActive(true);
            Debug.Log("Perfect choice! These attractions are within comfortable traveling distance.");
        }
        // Lotus Temple logic
        else if (selectedObject.CompareTag("LotusTemple"))
        {
            humayunsTomb.SetActive(true);
            Debug.Log("Perfect choice! These attractions are within comfortable traveling distance.");
        }
        // Humayun's Tomb logic
        else if (selectedObject.CompareTag("HumayunsTomb"))
        {
            akshardham.SetActive(true);
            Debug.Log("Perfect choice! These attractions are within comfortable traveling distance.");
        }
        else
        {
            Debug.Log("Too far! Choose attractions that are closer together to make better use of your customer's time.");
        }
    }
}
