using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IM_BACKEND.DBInversionesMontiel;

[Table("usuario")]
public partial class Usuario
{
    [Key]
    [Column("usuario_id")]
    public int UsuarioId { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("apellido_paterno")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ApellidoPaterno { get; set; }

    [Column("apellido_materno")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ApellidoMaterno { get; set; }

    [Column("tipo_documento")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TipoDocumento { get; set; }

    [Column("numero_documento")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NumeroDocumento { get; set; }

    [Column("pasword")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Pasword { get; set; }

    [Column("perfil_id")]
    public int? PerfilId { get; set; }

    [InverseProperty("UsuarioNavigation")]
    public virtual ICollection<Egreso> Egresos { get; } = new List<Egreso>();

    [InverseProperty("Usuario")]
    public virtual ICollection<Ingreso> Ingresos { get; } = new List<Ingreso>();

    [ForeignKey("PerfilId")]
    [InverseProperty("Usuarios")]
    public virtual Perfil? Perfil { get; set; }
}
