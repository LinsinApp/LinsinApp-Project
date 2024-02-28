using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSequence : MonoBehaviour
{
    public Button[] buttons; // Array to store the buttons in the Inspector
    public string[] sequence; // Array to store the button sequence in the Inspector
    private int currentIndex = 0; // Index of the current button in the sequence

    void Start()
    {
        // Attach the button click listeners
        for (int i = 0; i < buttons.Length; i++)
        {
            Button btn = buttons[i];
            btn.onClick.AddListener(() => ButtonClick(btn));
        }
    }

    void ButtonClick(Button btn)
    {
        // Check if the clicked button is the expected button in the sequence
        if (btn.name == sequence[currentIndex])
        {
            currentIndex++;

            // Check if the entire sequence has been completed
            if (currentIndex == sequence.Length)
            {
                Debug.Log("Sequence completed!");
                currentIndex = 0;
            }
        }
        else
        {
            Debug.Log("Wrong button clicked!");
            currentIndex = 0;
        }
    }
}
