# Abstract-Factory

## ¿Que es Abstract Factory? 

Abstract Factory es un patron de diseño creacional que permite crear familias de objetos relacionados sin especificar sus clases concretas. 
En lugar de instanciar objetos directamente con "new", el cliente trabaja con interfaces de fabricas que producen objetos compatibles entre si.

## ¿Para que sirve? 
Sirve cuando: 
- Tenes familias de objetos relacionadas(Ej: Muebles modernos y victorianos)
- Queres garantizar compatibilidad entre los objetos creados
- Queres desacoplar el codigo cliente de las clases concretas
- Queres poder cambiar toda una familia de objetos sin modificar el cliente

## Idea clave del patron
"El cliente no elije objetos, elige una fabrica" 
Cada fabrica crea objetos que combinan entre si. 

## Ejemplo del proyecto

En este ejemplo se modela una fabrica de muebles:

Familias de productos:
- Moderna
- Victoriana

Productos:
- Silla
- Mesa

Cada estilo tiene su propia implementacion:

- SillaModerna / MesaModerna
- SillaVictoriana / MesaVictoriana

## Estructura del patron en el codigo 
```text
Cliente
   ↓
IFabricaMuebles
   ↓
FabricaModerna     FabricaVictoriana
   ↓                     ↓
SillaModerna        SillaVictoriana
MesaModerna         MesaVictoriana
```
## Como se usa (Paso a paso)
1. El cliente recibe una fabrica concreta
2. La fabrica crea el producto (Silla y mesa )
3. El cliente no  sabe que clases concretas se usan
4. Los objetos creados son compatibles entre si.

Ejemplo: 

```csharp 
ProbarMuebles(new FabricaModerna());
ProbarMuebles(new FabricaVictoriana());
```
### Ventajas 
- Bajo acoplamiento
- Garantiza compatibilidad entre productos
- Facilita agregar nuevas familias
- Codigo mas limpio y mantenible

### Desventajas 
- Mas clases e interfaces
- Puede ser excesivo para sistemas simples

### Cuando usar Abstract Factory? 
Usalo cuando: 
- Un sistema debe funcionar con multiples variantes.
- Queres evitar if / switch para decidir que crear
- Necesitas crear conjuntos completos de objetos

### Relacion con otros patrones 
- Factory method --> Crea un solo producto
- Abstract Factory --> Crea familias de productos
- Builder --> Crea un objeto complejo paso a paso.

## Resumen rapido
Abstract Factory encapsula la creacion de familias de objetos compatibles, permitiendo cambiar toda una variante del sistema sin tocar el codigo cliente. 

