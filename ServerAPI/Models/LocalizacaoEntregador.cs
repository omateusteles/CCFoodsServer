using ServerAPI.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerAPI.Models
{
    public class LocalizacaoEntregador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long? LocalizacaoId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public long? EntityId { get; set; }
        public OperacaoSincronismo OperacaoSincronismo { get; set; }
    }
}
