using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemtMove : MonoBehaviour
{
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(5f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.z -= speed * Time.deltaTime;
        transform.position = pos;
        if (transform.position.z < -5)
        {
            Destroy(gameObject);
        }
    }
}
