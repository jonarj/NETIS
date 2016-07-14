﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetisTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGenerarContrasena()
        {
            SWRecuperarContrasena.RecuperarContrasenaClient proxy = new SWRecuperarContrasena.RecuperarContrasenaClient();
            string stRespuesta = proxy.RecuperarContrasenaUsuario("jperez@gmail.com");
            Assert.AreEqual("La Contraseña fue enviada al Correo : jperez@gmail.com", stRespuesta);
        }
    }
}
