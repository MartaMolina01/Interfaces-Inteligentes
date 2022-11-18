using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huevo : MonoBehaviour
{
    public Cubo notificador;
    public float aumento;
    // Start is called before the first frame update
    void Start()
    {
        notificador.colision_cofre += ColisionCofre;
    }

    // Update is called once per frame
    void Update()
    {
        aumento = 1.1F;
    }

    void ColisionCofre()
    {
        transform.localScale *= aumento;
        Debug.Log("Colision con el cofre");
    }
}
