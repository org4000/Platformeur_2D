using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class KeyFrags : MonoBehaviour
{
    public int KeyFragCollected = 0;
    public Text KeyOutput;

    private void Update()
    {
        KeyOutput.text = "Key Fragments: " + KeyFragCollected + "/3";

    }

    public void KeyCollected()
    {
        KeyFragCollected++;

    }

    public void UsedKey()
    {
        KeyFragCollected--;
    }

    





}
