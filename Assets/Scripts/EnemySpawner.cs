using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject enemySpawner;
    float[] xpos;
    float[] ypos;
    int randomPos;
    bool[] existingEnemies;
    Vector3 whereSpawning;
    public float minSpawnRate = 4f;
    public float maxSpawnRate = 4f;
    float nextSpawn = 4;

    // Start is called before the first frame update
    void Start()
    {
        existingEnemies = new bool[17];
        for(int i = 0 ; i < 17 ; i++)
        {
            existingEnemies[i] = false;
        }
        xpos = new float[17];
        xpos[0] = 19f;
        xpos[1] = -203f;
        xpos[2] = -544f;
        xpos[3] = -702f;
        xpos[4] = 722f;
        xpos[5] = 562f;
        xpos[6] = 219f;
        xpos[7] = -856f;
        xpos[8] = -667f;
        xpos[9] = -454f;
        xpos[10] = -293f;
        xpos[11] = -78f;
        xpos[12] = 100f;
        xpos[13] = 319f;
        xpos[14] = 481f;
        xpos[15] = 696f;
        xpos[16] = 885f;
        ypos = new float[17];
        ypos[0] = 69.416f;
        ypos[1] = 109f;
        ypos[2] = 87f;
        ypos[3] = 16f;
        ypos[4] = 9f;
        ypos[5] = 88f;
        ypos[6] = 113f;
        ypos[7] = 252f;
        ypos[8] = 269f;
        ypos[9] = 283f;
        ypos[10] = 300f;
        ypos[11] = 300f;
        ypos[12] = 300f;
        ypos[13] = 300f;
        ypos[14] = 288f;
        ypos[15] = 274f;
        ypos[16] = 252f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            randomPos = Random.Range(0,16);
            if (existingEnemies[randomPos] == false)
            {
                nextSpawn = Time.time + Random.Range(minSpawnRate,maxSpawnRate);
                Debug.Log(Time.time);
                whereSpawning = new Vector3(xpos[randomPos], ypos[randomPos], 0);
                var myEnemy = GameObject.Instantiate(enemy);
                myEnemy.transform.SetParent(enemySpawner.transform, false);
                enemy.transform.position = whereSpawning;
                existingEnemies[randomPos] = true;
            } else {
                nextSpawn = Time.time + 1;
            }
            
        }
    }
}
