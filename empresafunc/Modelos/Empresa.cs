using System.Security.Cryptography;

public class Empresa
{
    private string _Cnpj;
    private string _Razaosocial;
    private string _Situacao;
    private string _Regime;
    private DateTime _Datainicio;
    private string _Telefone;
    private string _Capitalsocial;
    private string _Unifederal;
    private string _Cidade;
    private string _Rua;
    private string _Bairro;
    private string _Tipo;
    private char _Porte;
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


}