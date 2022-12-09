using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cam;

public class Plano_mem : MonoBehaviour
{
    public WebCamTexture webcamTexture;
    public Cam notificador;
    // Start is called before the first frame update
    void Start()
    {
        webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        

        notificador.pausa += mostrar;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void mostrar(){
        GetComponent<Renderer>().material.mainTexture = Cam.getMem();
        
        
    }
}
