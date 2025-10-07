using System.ComponentModel;

namespace API_Tarefas.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        Afazer = 1,
        [Description("Em Andamento")]
        EmAndamento = 2,
        [Description("Concluido")]
        Concluída =3
    }
}
