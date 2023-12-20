using System.ComponentModel;

namespace NoteKeeper.Dominio.ModuloNota
{
  public enum TemaEnum
  {
    [Description("primary")]
    Basica,
    [Description("accent")]
    Realcada,
    [Description("warn")]
    Advertencia
  }
}
