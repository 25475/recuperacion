using System;
class decorador:ordenBase{

protected ordenBase plato;

public decorador(ordenBase plato){
    this.plato=plato;

}

public virtual double calculoPrecio(){
    return plato.calculoPrecio();
}
}