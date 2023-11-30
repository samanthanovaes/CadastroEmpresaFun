using System.Security.Cryptography;

public class Empresa
{
    private string _Cnpj;
    private string _Razaosocial;
    private string _Situacao;
    private string _Regime;
    private DateTime _Datainicio;
    private string _Telefone;
    private double _Capitalsocial;
    private string _Unifederal;
    private string _Cidade;
    private string _Rua;
    private string _Bairro;
    private string _Tipo;
    private string _Porte;
    private string _Natureza;
    private string _Proprietario;
    private string _Cpf;

    public string Cnpj
    {
        get { return _Cnpj; }
        set { _Cnpj = value; }
    }

    public string RazaoSocial
    {
        get { return _Razaosocial; }
            set { _Razaosocial = value; }


    }

    public string Situacao
    {
        get { return _Situacao; }
        set { _Situacao = value; }
    }
    public string Regime
    {
        get { return _Regime; }
        set { _Regime = value; }
    }

    public DateTime Datainicio
    {
        get { return _Datainicio; }
        set { _Datainicio = value; }
    }

    public string Telefone
    {
        get { return _Telefone; }
        set { _Telefone = value; }
    }
    public double Capitalsocial
    {
        get { return _Capitalsocial; }
        set { _Capitalsocial = value; }
    }

    public string Unifederal
    {
        get { return _Unifederal; }
        set { _Unifederal = value; }
    }
    public string Cidade
    {
        get { return _Cidade; }
        set { _Cidade = value; }
    }

    public string Rua
    {
        get { return _Rua; }
        set { _Telefone = value; }
    }

    public string Bairro
    {
        get { return _Bairro; }
        set { _Bairro = value; }
    }

    public string Tipo
    {
        get { return _Tipo; }
        set { _Tipo = value; }
    }

    public string Porte
    {
        get { return _Porte; }
        set { _Porte = value; }
    }

    public string Natureza
    {
        get { return _Natureza; }
        set { _Natureza = value; }
    }

    public string Proprietario
    {
        get { return _Proprietario; }
        set { _Proprietario = value; }
    }

    public string Cpf
    {
        get { return _Cpf; }
        set { _Cpf = value; }
    }


    public Empresa ()
    {

    }

    public Empresa (string cnpj, string razaosocial, string situacao, string regime, DateTime datainicio, string telefone, 
        double capitalsocial, string unifederal, string cidade, string rua, string bairro, string tipo, string porte, string natureza, string proprietario, string cpf)
    {
        
        this.Cpf = cnpj;
        this.RazaoSocial = razaosocial;
        this.Situacao = situacao;
        this.Regime = regime;
        this.Datainicio = datainicio;
        this.Telefone = telefone;
        this.Capitalsocial = capitalsocial;
        this.Unifederal = unifederal;
        this.Cidade = cidade;
        this.Rua = rua;
        this.Bairro = bairro;
        this.Tipo = tipo;
        this.Porte = porte;
        this.Natureza = natureza;
        this.Proprietario = proprietario;
        this.Cpf = cpf;
    }
}