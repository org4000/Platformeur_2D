using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private FloatSO scoreSO;

    public int JoyauCollected = 0;

    public Text JoyauOutput;
    private void Update()
    {
        JoyauOutput.text = "Joyaux: " + JoyauCollected;
    }

    public void CollectJoyau()
    {
        JoyauCollected++;
    }

    public void UseJoyau()
    {
        JoyauCollected--;
    }

   




}
