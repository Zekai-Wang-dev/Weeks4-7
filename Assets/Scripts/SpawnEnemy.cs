using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public GameObject enemyClone;
    public GameObject winningScreen; 

    public List<GameObject> spawnedEnemies;
    public List<clickOnEnemy> enemyScript;


    private void Awake()
    {

        
    }

    // Start is called before the first frame update
    void Start()
    {

        spawnedEnemies = new List<GameObject>();
        for (int i = 0; i < 5; i++)
        {

            spawnedEnemies.Add(Instantiate(enemyClone, new Vector2(Random.Range(-10f, 10f), Random.Range(-5f, 5f)), Quaternion.identity));
            enemyScript.Add(spawnedEnemies[i].GetComponent<clickOnEnemy>()); 

        }
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = spawnedEnemies.Count - 1; i >= 0; i--)
        {

            if (enemyScript[i].health == 0)
            {

                spawnedEnemies.Remove(spawnedEnemies[i]);
                enemyScript.Remove(enemyScript[i]);

            }

        }

        if (spawnedEnemies.Count == 0)
        {

            winningScreen.SetActive(true);

        }

    }
}
