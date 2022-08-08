using System;
class program{
 public static void Main(string[]Args){
  var pedido1=new burritos();
Console.WriteLine("el precio de burritos es de: $ {pedido1.calculoPrecio()}");
  var dec1=new conChile(pedido1);
  Console.WriteLine("el precio de burritos con chile es de: $ ");
  
 }
}
