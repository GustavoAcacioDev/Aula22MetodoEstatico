namespace Aula22MetodoEstatico
{
    public static class Conversor
    {
        public static float CotacaoDolarReal = 5.23f;
        public static float CotacaoEuroDolar = 1.13f;

        public static float ConverterRealParaDolar(float valor){
            return valor * CotacaoDolarReal;
        }

        public static float ConverterDolarParReal(float valor){
            return valor / CotacaoDolarReal;
        }

        public static float ConverterDolarParaEuro(float valor){
            return valor / CotacaoEuroDolar;
        }

        public static float ConverterEuroParaDolar(float valor){
            return valor * CotacaoEuroDolar;
        }
        
    }
}