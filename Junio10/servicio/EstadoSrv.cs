﻿using Junio10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio10.servicio
{
    public class EstadoSrv
    {
        public static List<Estado> ListarTodo()
        {
            var lista=new List<Estado>();
            lista.Add(new Estado(1, "bolt"));
            lista.Add(new Estado(2, "clouds"));
            lista.Add(new Estado(3, "snow"));
            lista.Add(new Estado(4, "stars"));
            return lista;
        }
    }
}