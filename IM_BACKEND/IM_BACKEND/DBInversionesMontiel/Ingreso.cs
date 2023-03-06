using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IM_BACKEND.DBInversionesMontiel;

[Table("ingreso")]
public partial class Ingreso
{
    [Key]
    [Column("ingreso_id")]
    public int IngresoId { get; set; }

    [Column("tipo_comprobante")]
    [StringLength(30)]
    [Unicode(false)]
    public string? TipoComprobante { get; set; }

    [Column("num_comprobante")]
    [StringLength(30)]
    [Unicode(false)]
    public string? NumComprobante { get; set; }

    [Column("fecha_recepcion", TypeName = "date")]
    public DateTime? FechaRecepcion { get; set; }

    [Column("cantidad")]
    public int? Cantidad { get; set; }

    [Column("num_lote")]
    [StringLength(10)]
    [Unicode(false)]
    public string? NumLote { get; set; }

    [Column("proveedor_id")]
    public int? ProveedorId { get; set; }

    [Column("producto_id")]
    public int? ProductoId { get; set; }

    [Column("usuario_id")]
    public int? UsuarioId { get; set; }

    [Column("comprobante_id")]
    public int? ComprobanteId { get; set; }

    [ForeignKey("ComprobanteId")]
    [InverseProperty("Ingresos")]
    public virtual TipoComprobante? Comprobante { get; set; }

    [ForeignKey("ProductoId")]
    [InverseProperty("Ingresos")]
    public virtual Producto? Producto { get; set; }

    [ForeignKey("ProveedorId")]
    [InverseProperty("Ingresos")]
    public virtual Proveedor? Proveedor { get; set; }

    [ForeignKey("UsuarioId")]
    [InverseProperty("Ingresos")]
    public virtual Usuario? Usuario { get; set; }
}
