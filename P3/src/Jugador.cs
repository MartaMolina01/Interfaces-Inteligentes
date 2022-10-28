using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public bool avanzar;
    public float girar;
    public float char_speed;
    public float rot_speed;

    private float aproximacion;
    private GameObject C;

    public delegate void mensajeA();
    public event mensajeA colisionA;

    public delegate void mensajeB();
    public event mensajeB colisionB;

    public delegate void mensajeC();
    public event mensajeC aproxC;

    // Start is called before the first frame update
    void Start()
    {
        char_speed=4;
        rot_speed=2;

        aproximacion = 2F;
        C = GameObject.FindWithTag("C");
    }

    // Update is called once per frame
    void Update()
    {
        avanzar = Input.GetButton("Vertical");
        girar = Input.GetAxis("Horizontal");

        if(avanzar) {
            transform.Translate(Vector3.forward * char_speed * Time.deltaTime);
        }
        transform.Rotate(0, girar * rot_speed, 0);


        if(Vector3.Distance(transform.position, C.transform.position) < aproximacion)
        {
            aproxC();
        }

    }

    void OnCollisionEnter(Collision objeto)
    {
        if(objeto.collider.tag == "A"){
            colisionA();
        }

        if(objeto.collider.tag == "B"){
            colisionB();
        }
    }
}
