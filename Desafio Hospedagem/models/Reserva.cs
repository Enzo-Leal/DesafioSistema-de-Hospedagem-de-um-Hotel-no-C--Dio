using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Hospedagem.models
{
    public class Reserva
    {
        public Reserva()
        {
        }


        


        public List<Pessoa> Hospedes { get; set; }
        
        public Suite Suite { get; set; }


        public int DiasReservados { get; set; }



        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }



        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;
        }


        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }


        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }


        public decimal CalcularValorDiaria()
        {
            return Suite.ValorDiaria * DiasReservados;
        }




    }
}





















