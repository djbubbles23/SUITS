using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using SUITS_Project;    

public class InstructionDetails : MonoBehaviour
{
    public TextMeshProUGUI headerText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI stepText;

    void Start()
    {
        if(headerText == null || descriptionText == null || stepText == null)
        {
            headerText.text = "Header";
            descriptionText.text = "Description";
            stepText.text = "Step";
            Debug.LogError("Default text set for InstructionDetails");
        }
    }
}
