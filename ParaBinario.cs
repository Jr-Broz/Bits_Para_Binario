using System;
using System.Text;
namespace Program;
public class ParaBinario{
public void Int_Para_Binario(){

Console.WriteLine("Insira numero para que ele seja retornado em binario");

int resposta = Convert.ToInt32(Console.ReadLine());

string saida = Convert.ToString(resposta,2).PadLeft(8,'0'); 

Console.WriteLine(saida);
}


  
public void string_Para_Binario(){

Console.WriteLine("Insira uma palavra para que ele seja retornado em binario");

String resposta = Console.ReadLine();

Byte[] bytes =  System.Text.Encoding.ASCII.GetBytes(resposta);

foreach(byte b in bytes){
  
  Console.Write(Convert.ToString(b,2).PadLeft(8,'0'));

}
}
}
