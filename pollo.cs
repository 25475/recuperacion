using System;
class pollo:decorador{

public pollo (ordenBase plato ):base (plato){

    }
    public override double calculoPrecio(){
        return base.calculoPrecio()+0.75;
}
}