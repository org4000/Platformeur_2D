using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject door; // R�f�rence � l'objet de la porte


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Poussable")) // V�rifiez si l'objet en collision est poussable
        {
            Destroy(door); // D�truisez la porte
        }
    }
    //private void OnTriggerEnter2D(Collision2D collision)
    //{
        
    //}
}