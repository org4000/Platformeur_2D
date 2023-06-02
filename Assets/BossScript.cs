using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public enum Stage
    {
        WaitingToStart,
        Stage_1,
        Stage_2,
        Stage_3,
    }

    //[SerializeField] private ColliderTrigger colliderTrigger;
    [SerializeField] private GameObject Boss;
    public Animator animController;



    [SerializeField] private GameObject pfEnemyShooterSpawn;


    [SerializeField] private GameObject shield_1;
    [SerializeField] private GameObject shield_2;

    [SerializeField] private List<GameObject> enemySpawnList;
    [SerializeField] private List<Transform> spawnPositionList;
    List<Transform> PastspawnPosition;
    [SerializeField] private Stage stage;

    [SerializeField] private GameObject Cryst1;
    [SerializeField] private GameObject Cryst2;
    [SerializeField] private GameObject Cryst3;
    [SerializeField] private GameObject Cryst4;


    private void Awake()
    {
        enemySpawnList = new List<GameObject>();

        foreach (Transform spawnPosition in transform.Find("spawnPositions"))
        {
            //spawnPositionList.Add(spawnPosition.position);
        }

        stage = Stage.WaitingToStart;
    }

    private void Start()
    {
        animController = GetComponent<Animator>();

        StartBattle();
        shield_1.SetActive(false);
        shield_2.SetActive(false);

    }

    private void FixedUpdate()
    {
        foreach (GameObject Enemy in enemySpawnList)
        {
            if (false == Enemy.activeInHierarchy)
            {
                SpawnEnemy();
            }
        }
        BossBattle_OnDamaged();

    }

    private void BossBattle_OnDead()
    {
        // Boss dead! Boss battle over!
        Debug.Log("Boss Battle Over!");

    }

    private void BossBattle_OnDamaged()
    {
        // Boss took damage
        switch (stage)
        {
            case Stage.Stage_1:
                if (Boss.GetComponent<BossHealth>().currentHealth <= 700)
                {
                    // Boss under 70% health

                    StartNextStage();
                }
                break;

            case Stage.Stage_2:

                if (Boss.GetComponent<BossHealth>().currentHealth <= 300)
                {
                    // Boss under 30% health
                    Cryst1.GetComponent<Crystalhealth>().currentHealth = 100;
                    Cryst2.GetComponent<Crystalhealth>().currentHealth = 100;
                    Cryst3.GetComponent<Crystalhealth>().currentHealth = 100;
                    Cryst4.GetComponent<Crystalhealth>().currentHealth = 100;
                    Cryst1.GetComponentInChildren<BarreDeVie>().SetHealth(100);
                    Cryst2.GetComponentInChildren<BarreDeVie>().SetHealth(100);
                    Cryst3.GetComponentInChildren<BarreDeVie>().SetHealth(100);
                    Cryst4.GetComponentInChildren<BarreDeVie>().SetHealth(100);
                    StartNextStage();
                }
                break;
        }
    }


    private void StartBattle()
    {
        Debug.Log("StartBattle");
        StartNextStage();
    }

    private void StartNextStage()
    {
        switch (stage)
        {
            case Stage.WaitingToStart:
                stage = Stage.Stage_1;

                SpawnEnemy();
                SpawnEnemy();

                break;

            case Stage.Stage_1:
                stage = Stage.Stage_2;
                shield_1.SetActive(true);


                break;

            case Stage.Stage_2:
                stage = Stage.Stage_3;
                Debug.Log("WTF");
                shield_2.SetActive(true);
                break;
        }
        Debug.Log("Starting next stage: " + stage);
    }

    private void SpawnEnemy()
    {
        int aliveCount = 0;
        foreach (GameObject Enemy in enemySpawnList)
        {
            // Enemy alive
            aliveCount++;
            if (aliveCount >= 3)
            {
                // Don't spawn more enemies
                return;
            }
        }

        Transform spawnPosition = spawnPositionList[UnityEngine.Random.Range(0, spawnPositionList.Count)];

        foreach (Transform Spawn in PastspawnPosition)
        {
            if (spawnPosition == Spawn)
            {
                spawnPosition = spawnPositionList[UnityEngine.Random.Range(0, spawnPositionList.Count)];
            }
        }


        GameObject enemySpawn = Instantiate(pfEnemyShooterSpawn, spawnPosition.position, Quaternion.identity);
        //enemySpawn.Spawn();
        enemySpawnList.Add(enemySpawn);
    }



   

}