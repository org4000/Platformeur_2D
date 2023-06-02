using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButtonScript : MonoBehaviour
{
    public GameObject objectToReset; // R�f�rence � l'objet poussable
    public GameObject objectToReset2; // R�f�rence � l'objet poussable

    public Vector3 resetPosition; // Position de r�initialisation
    public Vector3 resetPosition2; // Position de r�initialisation


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == objectToReset) // V�rifiez si l'objet en collision est celui � r�initialiser
        {
            objectToReset.transform.position = resetPosition; // R�initialisez la position de l'objet
            objectToReset2.transform.position = resetPosition2; // R�initialisez la position de l'objet

        }
    }
}
