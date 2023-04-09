using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform m_Target = null;
    public Vector3 m_offeset = Vector3.zero;
    public float m_Lerp = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        m_offeset = transform.position - m_Target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temppos = Vector3.Lerp(transform.position, m_Target.position + m_offeset, m_Lerp * Time.deltaTime);
        transform.position = temppos;
    }
}
