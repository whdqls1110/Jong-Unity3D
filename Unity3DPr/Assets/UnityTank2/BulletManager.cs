using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public GameObject effect;
    public Rigidbody LinkRigid = null;
    // Start is called before the first frame update
    void Start()
    {
        LinkRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (LinkRigid.velocity.magnitude > 0.001f)
        {
            transform.rotation = Quaternion.LookRotation(LinkRigid.velocity);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject Effect = Instantiate(effect);
        Effect.transform.position = transform.position;
        GameObject.Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enimy"))
        {
            GameObject Effect = Instantiate(effect);
            Effect.transform.position = transform.position;
            Destroy(other.gameObject);
            GameObject.Destroy(gameObject);
        }
    }
}
