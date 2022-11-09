using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public bool Z_d, X_d;
    public float Y_r;
    public float char_speed;
    public float rot_speed;
    public int puntuacion;
    private GameObject cilindro;
    private GameObject cilindro1;
    private GameObject cilindro2;
    public float aumento = 1.05F;
    private double choque = 1.5;
    private GameObject cubo1;
    private GameObject cubo2;


    // Start is called before the first frame update
    void Start()
    {
        char_speed=4;
        rot_speed=2;
        puntuacion=0;

        cilindro = GameObject.FindWithTag("Cilindro");
        cilindro1 = GameObject.FindWithTag("Cilindro1");
        cilindro2 = GameObject.FindWithTag("Cilindro2");

        cubo1 = GameObject.FindWithTag("Cubo1");
        cubo2 = GameObject.FindWithTag("Cubo2");
    }

    // Update is called once per frame
    void Update()
    {
        X_d = Input.GetButton("Horizontal");
        Z_d = Input.GetButton("Vertical");
        Y_r = Input.GetAxis("Horizontal");

        if(Z_d) {
            transform.Translate(Vector3.forward * char_speed * Time.deltaTime);
        }
        if(X_d){
            transform.Rotate(0, Y_r * rot_speed, 0);
        } 
        //Debug.Log(Vector3.Distance(transform.position, cilindro.transform.position));
    }

    void OnCollisionEnter()
    {
        if(Vector3.Distance(transform.position, cilindro.transform.position) < choque){
            Debug.Log("Ha chocado el cubo con un cilindro esfera");
            puntuacion++;
            cilindro.transform.localScale *= aumento;
        }

        if(Vector3.Distance(transform.position, cilindro1.transform.position) < choque){
            Debug.Log("Ha chocado el cubo con un cilindro derecha");
            puntuacion++;
            cilindro1.transform.localScale *= aumento;
        }

        if(Vector3.Distance(transform.position, cilindro2.transform.position) < choque){
            Debug.Log("Ha chocado el cubo con un cilindro atras");
            puntuacion++;
            cilindro2.transform.localScale *= aumento;
        }

        if(Vector3.Distance(transform.position, cubo1.transform.position) < choque){
            Debug.Log("Ha chocado el cubo con cubo atras");
            cubo1.transform.localScale /= aumento;
        }

        if(Vector3.Distance(transform.position, cubo2.transform.position) < choque){
            Debug.Log("Ha chocado el cubo con cubo izquierda");
            cubo2.transform.localScale /= aumento;
        }
    }
}
