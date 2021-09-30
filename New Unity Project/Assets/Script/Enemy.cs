using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Enemy 
{
    public int SpawnTime;
    public EnemyType enemyType;
    public int Spawner;
    public bool RandomSpawner;
    public bool isSpawned;
}

public enum EnemyType
{
    Enemy_Basic,
    Enemy_One,
    Enymy_Two,
}
