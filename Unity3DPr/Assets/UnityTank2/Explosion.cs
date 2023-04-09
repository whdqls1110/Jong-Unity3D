using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(ParticleSystem))]
public class Explosion : MonoBehaviour
{
    //public ParticleSystem particleObj;
    // Start is called before the first frame update
    void Start()
    {
        //particleObj.Play();
        GetComponent<ParticleSystem>().Play();
        Destroy(gameObject, 3);
    }
}
