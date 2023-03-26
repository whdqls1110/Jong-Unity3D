using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float moveSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.z += moveSpeed * Time.deltaTime;
        transform.position = pos;
        if (pos.z > 30)
        {
            Destroy(gameObject);
        }
    }
}
