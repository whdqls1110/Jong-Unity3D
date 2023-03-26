using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public GameObject bullet;
    public float playerSpeed = 0;

    float time = 0;
    bool cooltime = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 pos = transform.position;
            pos.x -= playerSpeed * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 pos = transform.position;
            pos.x += playerSpeed * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 pos = transform.position;
            pos.y += playerSpeed * Time.deltaTime * 0.3f;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 pos = transform.position;
            pos.y -= playerSpeed * Time.deltaTime * 0.3f;
            transform.position = pos;
        }
        time += Time.deltaTime;
        if (time > 0.2 && cooltime == false)
        {
            cooltime = true;
        }

        if (Input.GetKey(KeyCode.Space) && cooltime)
        {
            GameObject Bullet = GameObject.Instantiate(bullet);
            Vector3 pos = transform.position;
            pos.z = 0.7f;
            Bullet.transform.position = pos;
            cooltime = false;
            time = 0;
        }
    }
}
