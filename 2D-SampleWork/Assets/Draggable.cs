using UnityEngine;
using UnityEngine.UI;  // For UI elements like InputField, Text, Button

public class MonumentPlanner : MonoBehaviour
{
    // References to UI elements (set these up in the Unity Inspector)
    public InputField inputField;   // Input field for user input
    public Text outputText;         // Text to display the result
    public Button submitButton;     // Button to trigger input processing

    // Columns array to hold the monuments
    private string[] columns = new string[9];

    void Start()
    {
        // Initialize fixed values in columns
        columns[1] = "Red Fort";    // Column 1 fixed
        columns[4] = "India Gate";  // Column 4 fixed
        columns[8] = "Akshardham";  // Column 8 fixed

        // Add listener to the submit button
        submitButton.onClick.AddListener(OnSubmit);
    }

    // This method will be triggered when the submit button is clicked
    void OnSubmit()
    {
        // Get the input from the input field
        string input = inputField.text;

        // Split the input by commas and trim spaces
        string[] monuments = input.Split(',');

        // Validate the input
        if (monuments.Length == 2)
        {
            string col2 = monuments[0].Trim();
            string col3 = monuments[1].Trim();

            // Check if columns 2 and 3 contain the correct monuments
            if ((col2 == "Jama Masjid" && col3 == "Chandni Chowk") ||
                (col2 == "Chandni Chowk" && col3 == "Jama Masjid"))
            {
                // Assign values to columns 2 to 7
                columns[2] = col2;  // Column 2
                columns[3] = col3;  // Column 3
                columns[5] = "Qutub Minar";   // Column 5
                columns[6] = "Lotus Temple";  // Column 6
                columns[7] = "Humayun's Tomb";  // Column 7

                // Display the success message with column assignments
                outputText.text = "Column assignments successful:\n" + PrintColumns();
            }
            else
            {
                // Error: Invalid monuments in columns 2 and 3
                outputText.text = "Error: Columns 2 and 3 must contain Jama Masjid and Chandni Chowk (or vice versa).";
            }
        }
        else
        {
            // Error: Invalid input (not exactly two monuments)
            outputText.text = "Error: Please provide exactly two monuments for columns 2 and 3.";
        }
    }

    // Method to print the column assignments as a string
    string PrintColumns()
    {
        string columnString = "";
        for (int i = 0; i < columns.Length; i++)
        {
            columnString += "Column " + i + ": " + columns[i] + "\n";
        }
        return columnString;
    }
}


















//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Code1 : MonoBehaviour
//{
//    // Declare game objects
//    public GameObject redFort, chandniChowk, jamaMasjid, indiaGate, qutubMinar, lotusTemple, humayunsTomb, akshardham;

//    // Tracking variables
//    private int currentDay = 1;  // To keep track of which day of the itinerary the user is on
//    private int currentStep = 1; // To track which step the user is on within the day

//    void Start()
//    {
//        // Initialize all attractions as inactive
//        redFort.SetActive(false);
//        chandniChowk.SetActive(false);
//        jamaMasjid.SetActive(false);
//        indiaGate.SetActive(false);
//        qutubMinar.SetActive(false);
//        lotusTemple.SetActive(false);
//        humayunsTomb.SetActive(false);
//        akshardham.SetActive(false);
//    }

//    public void CheckSelection(GameObject selectedObject)
//    {
//        switch (currentDay)
//        {
//            case 1:
//                HandleSelection(selectedObject, new[] { redFort, chandniChowk, jamaMasjid, indiaGate });
//                break;

//            case 2:
//                HandleSelection(selectedObject, new[] { qutubMinar, lotusTemple, humayunsTomb, akshardham });
//                break;

//            default:
//                Debug.Log("Please follow the correct sequence.");
//                break;
//        }
//    }

//    void HandleSelection(GameObject selectedObject, GameObject[] attractions)
//    {
//        if (currentStep == 1 && selectedObject.CompareTag(attractions[0].tag))
//        {
//            SetNextAttraction(attractions[1]);
//        }
//        else if (currentStep == 2 && selectedObject.CompareTag(attractions[1].tag))
//        {
//            SetNextAttraction(attractions[2]);
//        }
//        else if (currentStep == 3 && selectedObject.CompareTag(attractions[2].tag))
//        {
//            SetNextAttraction(attractions[3]);
//        }
//        else if (currentStep == 4 && selectedObject.CompareTag(attractions[3].tag))
//        {
//            Debug.Log($"Day {currentDay} completed!");
//            currentDay++;
//            currentStep = 1; // Reset to first step of the next day
//        }
//        else
//        {
//            Debug.Log("Please follow the correct sequence.");
//        }
//    }

//    void SetNextAttraction(GameObject nextAttraction)
//    {
//        nextAttraction.SetActive(true);
//        currentStep++;
//        Debug.Log($"Now choose {nextAttraction.name}.");
//    }
//}
