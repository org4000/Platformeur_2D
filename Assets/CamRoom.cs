using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class CamRoom : MonoBehaviour
{
    [SerializeField] Shooting shoot;
    [SerializeField] BulletScript Bs;
    [SerializeField] Camera mainCamera;
    [SerializeField] Camera Cam2;
    public float zoomAmount = 5f;

    private float originalOrthographicSize;

    private void Start()
    {
        //originalOrthographicSize = mainCamera.orthographicSize;
        Cam2.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.transform.position.y > transform.position.y)
            {
                shoot.mainCam = Cam2;
                Bs.mainCam = Cam2;
                Cam2.tag = "MainCamera";
                mainCamera.tag = "Camera";
                mainCamera.enabled = false;
                Cam2.enabled = true;
                
            }
            else
            {
                Cam2.tag = "Camera";
                mainCamera.tag = "MainCamera";
                shoot.mainCam = mainCamera;
                Bs.mainCam = mainCamera;
                mainCamera.enabled = true;
                Cam2.enabled = false;
            }

        }
    }


}