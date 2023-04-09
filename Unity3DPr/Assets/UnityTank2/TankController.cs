using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankController : MonoBehaviour
{
    public float movespeed = 10;
    public float rotspeed =500 ;

    public GameObject bullet;
    public GameObject pos;
    public float power = 10;
    float strtime = 0;
    bool isprece = true;
    float mtime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            strtime = Time.time;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            mtime = Time.time - strtime;
            Fire();
        }
    }
    void Move()
    {
        float move = Input.GetAxis("Vertical");
        float rot = Input.GetAxis("Horizontal");
        transform.Translate(0f, 0f, move * movespeed * Time.deltaTime);
        transform.Rotate(0f, rot * rotspeed * Time.deltaTime, 0f);
    }
    void Fire()
    {
        if (isprece)
        {
            GameObject Bullet = Instantiate(bullet);
            Bullet.transform.position = pos.transform.position;
            Bullet.transform.rotation = pos.transform.rotation;
            Rigidbody bulltRig = Bullet.GetComponent<Rigidbody>();
            //bulltRig.AddRelativeForce(0f, 0f, power);

            bulltRig.AddForce(pos.transform.forward * power * mtime, ForceMode.Force);
        }
    }
}
