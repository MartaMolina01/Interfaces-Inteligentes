using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    public Jugador notificador;
    private Rigidbody rigid;
    public float velocidad;
    private GameObject C;

    private float distance_plain;

    // Start is called before the first frame update
    void Start()
    {
        notificador.colisionB += movimiento_a_C;
        notificador.aproxC += color_salto_A; 
        rigid = GetComponent<Rigidbody>();
        C = GameObject.FindWithTag("C");

        velocidad = 10F;  
    }

    // Update is called once per frame
    void Update()
    {
        distance_plain = transform.position.y;
    }

    void movimiento_a_C()
    {
        Vector3 direccion = C.transform.position - transform.position;
        rigid.AddForce(direccion * velocidad);

        Debug.DrawRay(transform.position, direccion * 50, Color.blue, 100);
    }

    void color_salto_A()
    {
        this.GetComponent<Renderer>().material.color = Color.blue;

        if(distance_plain < 0.6F)
        {
            rigid.AddForce(Vector3.up * 2F, ForceMode.Impulse);
        }
    }
}