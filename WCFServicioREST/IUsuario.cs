﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFServicioREST.Dominio;

namespace WCFServicioREST
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuario
    {
        //[OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "Usuario", ResponseFormat = WebMessageFormat.Json)]
        //UsuarioDominio Crear(UsuarioDominio UsuarioCrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Usuario/{Correo}", ResponseFormat = WebMessageFormat.Json)]
        UsuarioDominio Obtener(string Correo);


    }
}
