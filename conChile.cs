using System;
class conChile:decorador{
    public conChile (ordenBase plato ):base (plato){

    }
    public override double calculoPrecio(){
        return base.calculoPrecio()+0.75;
}
}
