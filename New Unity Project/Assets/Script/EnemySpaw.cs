using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpaw : MonoBehaviour
{
    public List<GameObject> enemysPrefabs;
    public List<Enemy> enemys;

    private void Update()
    {
        
        foreach (Enemy enemy in enemys)
        {
            if (enemy.isSpawned == false && enemy.SpawnTime < Time.time)
            {
                
                GameObject enemyInstance = Instantiate(enemysPrefabs[(int)enemy.enemyType], transform.GetChild(enemy.Spawner).transform);
                transform.GetChild(enemy.Spawner).GetComponent<SpawnPoint>().human.Add(enemyInstance);
                enemy.isSpawned = true;               
            } 
        }
    }
}
