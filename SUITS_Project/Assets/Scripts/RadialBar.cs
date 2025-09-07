using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RadialBar : MonoBehaviour
{
    public Image radialImage; // Reference to the UI Image with Radial 360 fill
    public TextMeshProUGUI tmp; // Reference to the TextMeshProUGUI
    public string name = "";
    public float maxValue = 100f;
    private float currentValue;
    private float fill;

    void Start()
    {
        currentValue = maxValue; // Initialize current value to max
        fill = radialImage.fillAmount;
        tmp.text = "100/100";
    }

    void Update(){
        //print(name + " fill: " + fill);
        fill = (radialImage.fillAmount)*100;
        tmp.text = fill + "/" + maxValue;
    }
}