using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public WebCamTexture webcamTexture;
    public static WebCamTexture memoria;

    public delegate void mensaje();
    public event mensaje pausa;

    private bool captura;

    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        for (int i = 0; i < devices.Length; i++){
            Debug.Log(devices[i].name);
        }

        webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();

        memoria = new WebCamTexture();

        captura = false;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public static WebCamTexture getMem(){
        return memoria;
    }


    void OnGUI()
    {
        if (webcamTexture.isPlaying){
            if (GUILayout.Button("Pause")){
                webcamTexture.Pause();
                Debug.Log("Pausa");
                if(!captura){
                    memoria = webcamTexture;
                    captura = true;
                }
                pausa();
            }

            else if (GUILayout.Button("Play")){
                webcamTexture.Play();
            }
        }
    } 
}
