using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public bool Z_d, X_d;
    public float Y_r;
    public float char_speed;
    public float rot_speed;
    private GameObject cubo1;
    private GameObject cubo2;
    public float aumento = 1.05F;
    private double choque = 1.5;

    // Start is called before the first frame update
    void Start()
    {
        char_speed=4;
        rot_speed=2;

        cubo1 = GameObject.FindWithTag("Cubo1");
        cubo2 = GameObject.FindWithTag("Cubo2");
    }

    // Update is called once per frame
    void Update()
    {
        X_d = Input.GetButton("Nuevo_eje_x");
        Z_d = Input.GetButton("Nuevo_eje_y");
        Y_r = Input.GetAxis("Nuevo_eje_x");

        if(Z_d) {
            transform.Translate(Vector3.forward * char_speed * Time.deltaTime);
        }
        if(X_d){
            transform.Rotate(0, Y_r * rot_speed, 0);
        } 
    }

    void OnCollisionEnter()
    {
        Debug.Log("La esfera ha colisionado");

        if(Vector3.Distance(transform.position, cubo1.transform.position) < choque){
            Debug.Log("Ha chocado el esfera con cubo atras");
            cubo1.transform.localScale *= aumento;
        }

        if(Vector3.Distance(transform.position, cubo2.transform.position) < choque){
            Debug.Log("Ha chocado el esfera con cubo izquierda");
            cubo2.transform.localScale *= aumento;
        }
    }
}
