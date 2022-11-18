using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arania_verde : MonoBehaviour
{
    private Rigidbody rigid;
    public ObjectController notificador;
    // Start is called before the first frame update
    void Start()
    {
        notificador.arania_verde += salto;
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void salto()
    {
        rigid.AddForce(Vector3.up * 2F, ForceMode.Impulse);
    }
}
