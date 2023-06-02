using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public BossHealth bH;

    [SerializeField] private GameObject Cryst1;
    [SerializeField] private GameObject Cryst2;
    [SerializeField] private GameObject Cryst3;
    [SerializeField] private GameObject Cryst4;
    // Start is called before the first frame update
    void Start()
    {
        bH.imune = true;
        Cryst1.SetActive(true);
        Cryst2.SetActive(true);
        Cryst3.SetActive(true);
        Cryst4.SetActive(true);


    }


}