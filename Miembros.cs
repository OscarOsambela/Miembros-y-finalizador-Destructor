using System;
using System.Diagnostics;

class Miembros{
  private string nombrePersona;
  private string tituloTrabajo;
  private int salario;
  private int edad;

  //propiedad
  public string TITULOTRABAJO{
    get => tituloTrabajo;
    set => tituloTrabajo = value;
  }
  //metodo privado
  private void CompartirInfoPrivada(){
    Console.WriteLine("Mi nombre es {0} y mi edad es {1}, mi salario es {2} y soy {3}", nombrePersona, edad, salario, tituloTrabajo);
  }
  //metodo publico
  public void CompartirInfo(bool amigo){
    if(amigo){
      CompartirInfoPrivada();
    }else{
      Console.WriteLine("Mi nombre es {0} y mi edad es {1} y soy {2}", nombrePersona, edad, tituloTrabajo);
    }
  }
  //constructor
  public Miembros(int edad, string nombrePersona, string tituloTrabajo){
    salario = 3500;
    this.edad = edad;
    this.nombrePersona = nombrePersona;
    this.tituloTrabajo = tituloTrabajo;
  }
	//destructor o finalizador usado solo dentro de su propia clase, solo puede existir uno por clase
  ~Miembros(){
    //Limpia declaraciones en sentencia
		Debug.Write("Destrucción de objeto");
  }
}