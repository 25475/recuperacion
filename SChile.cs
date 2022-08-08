using System;
class SChile:decorador{
    public SChile(ordenBase plato ):base (plato){

    }
    public override double calculoPrecio(){
        return base.calculoPrecio()+1.00;
    }
}