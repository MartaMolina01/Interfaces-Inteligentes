using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTargetCubo(){
        Debug.Log("En cubo");
        //Spider.SetActive(true);
    }

    public void OffTargetCubo(){
        Debug.Log("Fuera cubo");
        //Spider.SetActive(false);
    }
}
