using System;
using System.Collections.Generic;

namespace entityDataFirst;

public partial class Email
{
    public int Id { get; set; }

    public string Emails { get; set; } = null!;

    public int? FkPessoa { get; set; }

    public virtual Pessoa? FkPessoaNavigation { get; set; }
}
