namespace Calculadora._Objetos
{
    public class Calculos
    {
        int resultado;

        public int Somar(int num1, int num2)
        {
            resultado = num1 + num2;
            return resultado;
        }

        public int Subtracao(int valor1, int valor2)
        {
            resultado = valor1 - valor2;
            return resultado;
        }

        public int Multiplicacao(int primeiroNum, int segundoNum)
        {
            resultado = primeiroNum * segundoNum;
            return resultado;
        }

        public int Divisao(int luana, int isadora)
        { 
        resultado = luana / isadora;
        return resultado;
        }
    }
}
