# Práctica 2 Interfaces Inteligentes
## Marta Molina Fernández

<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#ejercicio-1">Ejercicio 1</a></li>
    <li>
      <a href="#ejercicio-2">Ejercicio 2</a>
    </li>
    <li><a href="#ejercicio-3">Ejercicio 3</a></li>
  </ol>
</details>

## Ejercicio 1

## Ejercicio 2

Código: 

``` C#

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public bool Z_d, X_d;
    public float Y_r;
    public float char_speed;
    public float rot_speed;


    // Start is called before the first frame update
    void Start()
    {
        char_speed=4;
        rot_speed=2;
    }

    // Update is called once per frame
    void Update()
    {
        X_d = Input.GetButton("Horizontal");
        Z_d = Input.GetButton("Vertical");
        Y_r = Input.GetAxis("Horizontal");

        if(Z_d) {
            transform.Translate(Vector3.forward * char_speed * Time.deltaTime);
        }
        if(X_d){
            transform.Rotate(0, Y_r * rot_speed, 0);
        } 
    }
}
```
