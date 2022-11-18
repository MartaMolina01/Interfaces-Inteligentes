using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arania_roja : MonoBehaviour
{
    public ObjectController notificador;
    // Start is called before the first frame update
    void Start()
    {
        notificador.arania_roja += rotacion;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void rotacion()
    {
        transform.eulerAngles += new Vector3(80, 0, 0);
    }
}
