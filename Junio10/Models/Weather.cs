using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio10.Models
{
    public class Weather
    {
        public int WeatherId { set; get;} =0;
        public string Fecha { set; get;} ="";
        public Estado Estado { set; get;} =new Estado();
        //public string Lugar { set; get;}
        public Pais Pais { set; get;} = new Pais();

        // Quick Action = crear constructor vacio
        public Weather()
        {
            Pais=new Pais();
        }
    }
}