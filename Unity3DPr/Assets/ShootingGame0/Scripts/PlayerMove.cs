using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject bullet;
    public float moveSpeed = 0;

    float time = 0;
    bool cooltime = true;
    // Update is called once per frame
    void Update()
    {
        //이동
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 pos = transform.position;
            pos.x -= moveSpeed * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 pos = transform.position;
            pos.x += moveSpeed * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 pos = transform.position;
            pos.z += moveSpeed * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 pos = transform.position;
            pos.z -= moveSpeed * Time.deltaTime;
            transform.position = pos;
        }
        //발사
        time += Time.deltaTime;
        if (time > 1 && cooltime == false)
        {
            cooltime = true;
        }

        if (Input.GetKey(KeyCode.Space) && cooltime)
        {
            GameObject Bullet = GameObject.Instantiate(bullet);
            Bullet.transform.position = transform.position;
            cooltime = false;
            time = 0;
        }
    }

}
