using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;

public class KeyFrags : MonoBehaviour
{
    public int KeyFragCollected = 0;

    public void KeyCollected()
    {
        KeyFragCollected++;

    }

    public void UsedKey()
    {
        KeyFragCollected--;
    }

    





}
