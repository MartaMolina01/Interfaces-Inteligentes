using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Compass : MonoBehaviour
{
    public TMP_Text texto;


    // Start is called before the first frame update
    IEnumerator Start()
    {
        Input.compass.enabled = true;
        
        // Starts the location service.
        Input.location.Start();

        // Waits until the location service initializes
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
                
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, -Input.compass.trueHeading, 0);
        texto.text = "Orientación del dispositivo respecto al Polo Norte: ";
        texto.text += Input.compass.trueHeading.ToString();


        texto.text += "\nPosición relativa en el espacio del dispositivo: ";
        texto.text += Input.acceleration.ToString();

        Vector3 aceleracion_disp = Vector3.zero;
        aceleracion_disp.x = -Input.acceleration.y;
        aceleracion_disp.z = Input.acceleration.x;

        if (aceleracion_disp.sqrMagnitude > 1)
            aceleracion_disp.Normalize();
        
        aceleracion_disp *= Time.deltaTime;

        if(Input.location.status == LocationServiceStatus.Running){
            texto.text += "\nCoordenadas del dispositivo, en latitud: ";
            texto.text += Input.location.lastData.latitude.ToString();
            texto.text += " en longitud: ";
            texto.text += Input.location.lastData.longitude.ToString();
            texto.text += " en altitud: ";
            texto.text += Input.location.lastData.altitude.ToString();

            
            transform.Translate(aceleracion_disp * 2F);
            
        }
    }
    
}
