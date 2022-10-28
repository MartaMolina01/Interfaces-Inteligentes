using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    public Jugador notificador;
    public float aumento;

    private Rigidbody rigid;
    private GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        notificador.colisionA += incrementoB;
        notificador.aproxC += rotacionB;
        aumento = 1.1F;

        rigid = GetComponent<Rigidbody>();
        obj = GameObject.FindWithTag("Objeto");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void incrementoB()
    {
        this.transform.localScale *= aumento;
    }

    void rotacionB()
    {
        Vector3 direccion = obj.transform.position - transform.position;
        transform.LookAt(direccion);

        Debug.DrawRay(transform.position, direccion * 30, Color.red, 100);
    }
}
