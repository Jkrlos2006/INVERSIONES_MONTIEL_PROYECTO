using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IM_BACKEND.DBInversionesMontiel;

[Table("cliente")]
public partial class Cliente
{
    [Key]
    [Column("cliente_id")]
    public int ClienteId { get; set; }

    [Column("codigocliente")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Codigocliente { get; set; }

    [Column("razonsocial")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Razonsocial { get; set; }

    [Column("tipodocumento")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Tipodocumento { get; set; }

    [Column("numerodocumento")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Numerodocumento { get; set; }

    [Column("direccion")]
    [StringLength(120)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [Column("telefono")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("documento_id")]
    public int? DocumentoId { get; set; }

    [ForeignKey("DocumentoId")]
    [InverseProperty("Clientes")]
    public virtual TipoDocumento? Documento { get; set; }

    [InverseProperty("ClienteNavigation")]
    public virtual ICollection<Egreso> Egresos { get; } = new List<Egreso>();
}
