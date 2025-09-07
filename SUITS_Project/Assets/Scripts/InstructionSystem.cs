using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace SUITS_Project
{
    public class InstructionSystem : MonoBehaviour
    {
        public GameObject[] instructionNodes;
        [SerializeField] private int currIndex;
        [SerializeField] private int maxIndex;
        public bool StartInstructions = false;

        public void Start()
        {
            for (int i = 1; i < instructionNodes.Length; i++)
            {
                instructionNodes[i].SetActive(false);
            }
            if (instructionNodes.Length > 0)
            {
                instructionNodes[0].SetActive(true);
                instructionNodes[0].GetComponent<InstructionDetails>().stepText.text = currIndex+1+"/" + instructionNodes.Length;
            }
        }

        public void nextInstruction()
        {
            if (currIndex < instructionNodes.Length - 1)
            {
                instructionNodes[currIndex].SetActive(false);
                currIndex++;
                instructionNodes[currIndex].SetActive(true);
                instructionNodes[currIndex].GetComponent<InstructionDetails>().stepText.text = currIndex+1 + "/" + instructionNodes.Length;
            }
        }

        public void previousInstruction()
        {
            if (currIndex > 0)
            {
                instructionNodes[currIndex].SetActive(false);
                currIndex--;
                instructionNodes[currIndex].SetActive(true);
                instructionNodes[currIndex].GetComponent<InstructionDetails>().stepText.text = currIndex+1 + "/" + instructionNodes.Length;
            }
        }
    }
}
