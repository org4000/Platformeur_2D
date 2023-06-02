using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButtonScript : MonoBehaviour
{
    public GameObject objectToReset; // Référence à l'objet poussable
    public GameObject objectToReset2; // Référence à l'objet poussable

    public Vector3 resetPosition; // Position de réinitialisation
    public Vector3 resetPosition2; // Position de réinitialisation


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == objectToReset) // Vérifiez si l'objet en collision est celui à réinitialiser
        {
            objectToReset.transform.position = resetPosition; // Réinitialisez la position de l'objet
            objectToReset2.transform.position = resetPosition2; // Réinitialisez la position de l'objet

        }
    }
}
