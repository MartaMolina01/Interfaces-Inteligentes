using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notificador_cubo : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje OnMiEvento;
    public int contador;

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        contador = contador + 1;
        if (contador % 1000 == 0) {
            OnMiEvento();
        }
    }
}
