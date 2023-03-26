using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] Enemy = new GameObject[3];
    bool rantime = true;
    float timeset = 0;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rantime)
        {
            timeset = Random.Range(0.5f, 2f);
            rantime = false;
        }
        time += Time.deltaTime;
        if (time >= timeset)
        {
            rantime = true;
            time = 0;
            int genEnemy = Random.Range(0, 3);
            GameObject enemy = GameObject.Instantiate(Enemy[genEnemy]);
            float x = Random.Range(-5f, 5f);
            float y = Random.Range(-5f, 5f);
            Vector3 pos = new Vector3(x, y, 30);
            enemy.transform.position = pos;
        }
    }
}
