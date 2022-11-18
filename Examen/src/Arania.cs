using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arania : MonoBehaviour
{
    public delegate void mensajeA();
    public event mensajeA cerca_arania;
    private float aproximacion;
    private GameObject M;
    // Start is called before the first frame update
    void Start()
    {
        aproximacion = 5F;
        M = GameObject.FindWithTag("Monstruo");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, M.transform.position) < aproximacion)
        {
            cerca_arania();
        }
    }
}
