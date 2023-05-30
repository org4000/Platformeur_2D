using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFragment : MonoBehaviour
{
    public KeyFrags KF;

    private void OnTriggerEnter2D (Collider2D Collect)
    {
        if (Collect.name == "Player")
        {
            Debug.Log("Tu as récupérer 1 fragment de clé");
            KF.KeyCollected();
            Destroy(gameObject);


        }
    }
}
