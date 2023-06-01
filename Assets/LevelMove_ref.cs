using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMove_ref : MonoBehaviour
{
    public int sceneBuildIndex;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger Entered");
        if(collision.tag == "Player")
        {
            print("Switching Scene To" + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);

        }
    }


}
