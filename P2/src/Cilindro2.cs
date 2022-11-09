using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilindro2 : MonoBehaviour
{

    private Transform transf;
    public float fuerza = 5F;
    private GameObject cubo;
    private double cerca = 2;
    private Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        transf = GetComponent<Transform>();
        cubo = GameObject.FindWithTag("Cubo");
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transf.position, cubo.transform.position) < cerca){
            Vector3 direction = transf.position - cubo.transform.position;
            rigid.AddForce(direction * fuerza);
        }
    }
}
