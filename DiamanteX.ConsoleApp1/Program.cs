namespace DiamanteX.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;

            while (repetir)
            {
                #region Entrada e Validação
                int numero = ObterNumeroImpar();
                #endregion

                #region Geração do Diamante
                DesenharDiamante(numero);
                #endregion
            }
        }
    }
}