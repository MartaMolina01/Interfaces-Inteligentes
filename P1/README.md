# Práctica 1: Introducción a Unity

Para realizar ésta práctica he descargado dos assets de terreno y uno de naves espaciales. En la escena encontramos un cubo y una esfera como figuras 3D básicas, un prefab Third Person que se mueve por la escena hasta caer por un hueco en el terreno. También hay plantas sobre el terreno parecidas a la hierba, una pequeña montaña y una nave espacial azul de otro paquete de la Asset Store.

Para cada objeto de la escena hay un script en el que imprime por consola los que se hayan utilizado. En concreto el código es:

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.tag);
    }
}
```
A continuación un gif de la ejecución de la escena:
<div align="center">
<img src=./Practica1_II.gif alt= "gif">

Assets actualmente descargados:

![assets](./assets.png)
