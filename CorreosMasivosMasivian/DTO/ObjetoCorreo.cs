using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreosMasivosMasivian.DTO
{



    class ObjetoCorreo
    {
        
        public string Subject = "Asunto del Correo";
        public string From = "Contacto<contacto@dominio.com>";
        public Template Template = new Template() { Type = "text/html", Value = "<div>Hola mundo</div>" };
        public string ReplyTo = "soporte@dominio.com";
        public List<Recipients> Recipients = new List<Recipients> {
            new Recipients() { To = "Juan Andrade<cliete1@dominio.com>" },
            new Recipients() { To = "Diana<cliete2@dominio.com" } 
        };           
    }






}
