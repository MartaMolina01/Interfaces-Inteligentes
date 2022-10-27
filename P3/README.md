# Práctica 3 Interfaces Inteligentes
## Marta Molina Fernández

### Primer ejercicio
Creamos un notificador (cubo azul) y un suscriptor (cilindro rojo). En el inspector del suscriptor debemos indicar que el notificador al que debe escuchar es el cubo:

![img](./img/P3_1Inspector_notificador.png)

Imagen de la escena:

![img](./img/P3_1_escena.png)

Salida por consola:

![img](./img/P3_1.png)


### Segundo ejercicio

Colisión con B:

Para detectar la colisión del jugador con un objeto B que tiene RigidBody:

```C#
void OnCollisionEnter(Collision objeto)
{
    if(objeto.collider.tag == "B"){
        colisionB();
    }
}
```

Al colisionar con B, los objetos A se acercan al C:

![img](
