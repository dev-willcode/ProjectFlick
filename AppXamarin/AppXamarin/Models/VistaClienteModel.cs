using System;
using System.Collections.Generic;
using System.Text;
using AppFlickCliente.Utils;
using Entity.Entidades;
using Xamarin.Forms;

namespace AppXamarin.Models
{
    public class VistaClienteModel : Cliente
    {
        public VistaClienteModel(Cliente cliente)
            :base()
        {
            id = cliente.id;
            cliente_cedula = cliente.cliente_cedula;
            cliente_apellidos = cliente.cliente_apellidos;
            cliente_nombres = cliente.cliente_nombres;
            cliente_telefono = cliente.cliente_telefono;
            cliente_email = cliente.cliente_email;
            cliente_direccion = cliente.cliente_direccion;
            cliente_usuario = cliente.cliente_usuario;
            cliente_imagen = cliente.cliente_imagen;
            imagen_generada = UtilsProcedimientos.generarImagenBytes(cliente_imagen, GetType());
        }
        public ImageSource imagen_generada { get; set; }
    }
}
