namespace GeekLanches.UI
{
    public static class StringExtensions
    {
        public static string ToString(this bool ativo)
        {
            return ativo ? "Sim" : "Não";
        }
    }
}
