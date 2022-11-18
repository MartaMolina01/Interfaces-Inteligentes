using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public bool avanzar;
    public float girar;
    public float char_speed;
    public float rot_speed;

    public delegate void mensaje();
    public event mensaje colision_cofre;
    // Start is called before the first frame update
    void Start()
    {
        char_speed=4;
        rot_speed=2;
    }

    // Update is called once per frame
    void Update()
    {
        avanzar = Input.GetButton("V2");
        girar = Input.GetAxis("H2");

        if(avanzar) {
            transform.Translate(Vector3.forward * char_speed * Time.deltaTime);
        }
        transform.Rotate(0, girar * rot_speed, 0);
    }

    void OnCollisionEnter(Collision objeto)
    {
        if(objeto.collider.tag == "Cofre"){
            colision_cofre();
            Debug.Log("Colision con el cofre");
        }
    }
}
