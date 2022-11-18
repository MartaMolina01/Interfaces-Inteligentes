using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstruo : MonoBehaviour
{
    public bool avanzar;
    public float girar;
    public float char_speed;
    public float rot_speed;

    /* public delegate void mensaje();
    public event mensaje colision_cofre; */

    public int vida;
    
    public Arania notV;
    public Arania notR;

    // Start is called before the first frame update
    void Start()
    {
        char_speed=4;
        rot_speed=2;

        vida = 10000;
        notV.cerca_arania += RestaVida;
        notR.cerca_arania += RestaVida;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("t"))
        {
            transform.position = new Vector3(transform.position.x + 0.05F, 0, 0);
        }

        avanzar = Input.GetButton("Vertical");
        girar = Input.GetAxis("Horizontal");

        if(avanzar) {
            transform.Translate(Vector3.forward * char_speed * Time.deltaTime);
        }
        transform.Rotate(0, girar * rot_speed, 0);

        
    }

    /* void OnCollisionEnter(Collision objeto)
    {
        if(objeto.collider.tag == "Cofre"){
            colision_cofre();
            Debug.Log("Colision con el cofre");
        }
    } */

    void RestaVida()
    {
        vida -= 1;
        Debug.Log("Vida: " + vida);
    }
}
