using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IM_BACKEND.DBInversionesMontiel;

[Table("tipoComprobante")]
public partial class TipoComprobante
{
    [Key]
    [Column("comprobante_id")]
    public int ComprobanteId { get; set; }

    [Column("codigo_comprobante")]
    [StringLength(10)]
    [Unicode(false)]
    public string CodigoComprobante { get; set; } = null!;

    [Column("nombre_comprobante")]
    [StringLength(50)]
    [Unicode(false)]
    public string NombreComprobante { get; set; } = null!;

    [InverseProperty("Comprobante")]
    public virtual ICollection<Egreso> Egresos { get; } = new List<Egreso>();

    [InverseProperty("Comprobante")]
    public virtual ICollection<Ingreso> Ingresos { get; } = new List<Ingreso>();
}
