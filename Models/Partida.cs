using System;

namespace E_players_AspNetCore.Models
{
    public class Partida
    {
        public int IdPartida { get; set; }

        public int IdJogador1 { get; set; }

        public int IdJogador2 { get; set; }

        public string Name { get; set; }

        public DateTime HorarioInicio {get;set;}

        public DateTime HorarioFinal {get; set;}
        
        
        
        
        
        
    }
}