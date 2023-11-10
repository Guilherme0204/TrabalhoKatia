using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoKatia
{
    public class CheckOut : Quarto
    {
        public int Dia { get; set; }
        public double ValorDiaria { get; set; }
        public double ConsumoFrigobar { get; set; }
        public double Atividade { get; set; }
        public double Restaurante { get; set; }
        public override double Calcular()
        {
            double totalDiaria = Dia * ValorDiaria;
            double reserva = totalDiaria + ConsumoFrigobar + Atividade + Restaurante;
            return reserva;
        }
        public string Info()
        {
            return ($"Unidade: {Unidade} \n Número do Quarto: {NumQuarto} \n Quadra {Quadra} \n Tipo do Quarto: {Tipo} \n Diárias: {Dia} \n Valor Diária: R${ValorDiaria} \n Total Frigobar: {ConsumoFrigobar} \n Total Restaurante: R${Restaurante} \n Total Atividades: R${Atividade} \n Total da reserva R${Calcular()} \n Código da Reserva: {CPF}");
        }
    }
}
