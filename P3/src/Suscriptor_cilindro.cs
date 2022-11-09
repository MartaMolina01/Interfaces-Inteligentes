using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suscriptor_cilindro : MonoBehaviour
{
    public Notificador_cubo notificador;

    // Start is called before the first frame update
    void Start()
    {
        notificador.OnMiEvento += miRespuesta;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void miRespuesta()
    {
        Debug.Log("Soy el cilindro");
        Debug.Log(notificador.contador);
    }

}
