using System;


namespace Entrega_2
{
  [Serializable]
  public class Usuario
  {
    public String rut, nombre, apellido, email, telefono, clave;

    public Usuario(String rut, String nombre, String apellido, String email, String telefono, String clave)
    {
      this.rut = rut;
      this.nombre = nombre;
      this.apellido = apellido;
      this.email = email;
      this.telefono = telefono; ;
      this.clave = clave;
    }

    public String GetMail()
    {
      return email;
    }

    public String GetClave()
    {
      return clave;
    }

    public String GetNombre()
    {
      return nombre;
    }
  }
}
