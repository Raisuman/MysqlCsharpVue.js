using System;
using System.Collections.Generic;

namespace WebApplication4.Entities;

public partial class Cviky
{
    public int CvikyId { get; set; }

    public string? DruhCviku { get; set; }

    public TimeSpan? CasCviku { get; set; }

    public DateTime? DenCviku { get; set; }
}
