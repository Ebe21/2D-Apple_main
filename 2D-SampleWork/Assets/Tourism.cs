using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code1 : MonoBehaviour
{
    // Declare game objects
    public GameObject redFort;
    public GameObject chandniChowk;
    public GameObject jamaMasjid;
    public GameObject indiaGate;
    public GameObject qutubMinar;
    public GameObject lotusTemple;
    public GameObject humayunsTomb;
    public GameObject akshardham;

    // Tracking variables
    private int currentDay = 1;  // To keep track of which day of the itinerary the user is on
    private int currentStep = 1; // To track which step the user is on within the day
    private bool jamaMasjidSelected = false;
    private bool chandniChowkSelected = false;

    void Start()
    {
        // Initialize all attractions as inactive
        chandniChowk.SetActive(false);
        jamaMasjid.SetActive(false);
        indiaGate.SetActive(false);
        lotusTemple.SetActive(false);
        humayunsTomb.SetActive(false);
        akshardham.SetActive(false);
    }

    public void CheckSelection(GameObject selectedObject)
    {
        if (currentDay == 1)
        {
            // Day 1: RedFort → JamaMasjid → ChandniChowk → IndiaGate
            if (currentStep == 1 && selectedObject.CompareTag("RedFort"))
            {
                // Red Fort selected, now activate Jama Masjid and Chandni Chowk
                chandniChowk.SetActive(true);
                jamaMasjid.SetActive(true);
                currentStep++;
                Debug.Log("Red Fort selected. Now choose Jama Masjid or Chandni Chowk.");
            }
            else if (currentStep == 2 && selectedObject.CompareTag("JamaMasjid"))
            {
                // Jama Masjid selected, activate the next step (Chandni Chowk if not already selected)
                if (!chandniChowkSelected)
                {
                    chandniChowk.SetActive(true);
                    chandniChowkSelected = true;
                }
                currentStep++;
                Debug.Log("Jama Masjid selected. Now choose Chandni Chowk.");
            }
            else if (currentStep == 2 && selectedObject.CompareTag("ChandniChowk"))
            {
                // Chandni Chowk selected, activate the next step (Jama Masjid if not already selected)
                if (!jamaMasjidSelected)
                {
                    jamaMasjid.SetActive(true);
                    jamaMasjidSelected = true;
                }
                currentStep++;
                Debug.Log("Chandni Chowk selected. Now choose Jama Masjid.");
            }
            else if (currentStep == 3 && (selectedObject.CompareTag("JamaMasjid") || selectedObject.CompareTag("ChandniChowk")))
            {
                // After choosing either Jama Masjid or Chandni Chowk, now select India Gate
                indiaGate.SetActive(true);
                currentStep++;
                Debug.Log("Jama Masjid or Chandni Chowk selected. Now choose India Gate.");
            }
            else if (currentStep == 4 && selectedObject.CompareTag("IndiaGate"))
            {
                Debug.Log("Day 1 completed!");
                currentDay++;
                currentStep = 1; // Reset to first step of Day 2
                Debug.Log("Start Day 2. Choose Qutub Minar.");
            }
            else
            {
                Debug.Log("Please follow the correct sequence for Day 1.");
            }
        }
        else if (currentDay == 2)
        {
            // Day 2: QutubMinar → LotusTemple → HumayunsTomb → Akshardham

            if (currentStep == 1 && selectedObject.CompareTag("QutubMinar"))
            {
                lotusTemple.SetActive(true);
                currentStep++;
                Debug.Log("Qutub Minar selected. Now choose Lotus Temple.");
            }
            else if (currentStep == 2 && selectedObject.CompareTag("LotusTemple"))
            {
                humayunsTomb.SetActive(true);
                currentStep++;
                Debug.Log("Lotus Temple selected. Now choose Humayun's Tomb.");
            }
            else if (currentStep == 3 && selectedObject.CompareTag("HumayunsTomb"))
            {
                akshardham.SetActive(true);
                currentStep++;
                Debug.Log("Humayun's Tomb selected. Now choose Akshardham.");
            }
            else if (currentStep == 4 && selectedObject.CompareTag("Akshardham"))
            {
                Debug.Log("Day 2 completed! All attractions selected.");
            }
            else if (currentStep == 2 && !(selectedObject.CompareTag("LotusTemple")))
            {
                // If any selection is made apart from Lotus Temple after Qutub Minar
                Debug.Log("Error: After Qutub Minar, only Lotus Temple can be selected.");
            }
            else if (currentStep == 3 && !(selectedObject.CompareTag("HumayunsTomb")))
            {
                // If Humayun's Tomb or Akshardham is selected out of order
                Debug.Log("Error: After Lotus Temple, only Humayun's Tomb can be selected.");
            }
            else
            {
                Debug.Log("Please follow the correct sequence for Day 2.");
            }
        }
    }
}
