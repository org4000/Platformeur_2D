using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class CamRoomBelow : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] Camera Cam3;

    [SerializeField] Shooting shoot;
    [SerializeField] BulletScript Bs;
    public float zoomAmount = 5f;

    private float originalOrthographicSize;

    private void Start()
    {
        //originalOrthographicSize = mainCamera.orthographicSize;
        Cam3.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.transform.position.y < transform.position.y)
            {
                mainCamera.enabled = false;
                shoot.mainCam = Cam3;
                Bs.mainCam = Cam3;
                Cam3.tag = "MainCamera";
                mainCamera.tag = "Camera";
                Cam3.enabled = true;
                 

            }
            else
            {
                Cam3.tag = "Camera";
                mainCamera.tag = "MainCamera";
                shoot.mainCam = mainCamera;
                Bs.mainCam = mainCamera;
                mainCamera.enabled = true;
                Cam3.enabled = false;
            }

        }
    }


}