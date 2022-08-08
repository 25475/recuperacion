using System;
 class carne:decorador{
    
   public carne (ordenBase plato ):base (plato){

    }
    public override double calculoPrecio(){
        return base.calculoPrecio()+1.75;
}
}
