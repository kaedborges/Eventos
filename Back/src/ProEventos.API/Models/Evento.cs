namespace ProEventos.API.Models;

public class Evento
{
    public Guid Id { get; set; }
    public String Local { get; set; }
    public DateTime DataEvento { get; set; }
    public String Tema { get; set; }
    public String QtdPessoas { get; set; }
    public String Lote { get; set; }
    public String ImgUrl { get; set; }
}