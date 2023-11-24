using System.Text.RegularExpressions;

public class Funcionario
{
    private string _Id;
    private string _Nome;
    private string _Cpf;
    private string _Rg;
    private string _Telefone;
    private string _Email;
    private string _Rua;
    private string _Bairro;
    private string _Numero;
    private DateTime _DataNasc;
    private string _EstadoCivil;
    private string _Funcao;
    private double _Salario;

    public string Id
    {
        get { return _Id; }
    }

    public string Nome
    {
        get { return _Nome; }
        set { _Nome = value; }
    }
    public string Rg
    {
        get { return _Rg; }
        set { _Rg = value; }
    }

    public string Cpf
    {
        get { return _Cpf; }
        set { _Cpf = value; }
    }
    public string Telefone
    {
        get { return _Telefone; }
        set { _Telefone = value; }
    }

    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }

    public string Rua
    {
        get { return _Rua; }
        set { _Rua = value; }
    }
    public string Bairro
    {
        get { return _Bairro; }
        set { _Bairro = value; }
    }
    public string Numero
    {
        get { return _Numero; }
        set { _Numero = value; }
    }
    public DateTime DataNasc
    {
        get { return _DataNasc; }
        set { _DataNasc = value; }
    }
    public string EstadoCivil
    {
        get { return _EstadoCivil; }
        set { _EstadoCivil = value; }
    }
    public string Funcao
    {
        get { return _Funcao; }
        set { _Funcao = value; }
    }
    public double Salario
    {
        get { return _Salario; }
        set { _Salario = value; }
    }


    public Funcionario()
    {
        GerarId();
    }

    public Funcionario(string id, string nome, string cpf, string rg, string telefone, string email, string rua,
        string bairro, string numero, DateTime datanasc, string estadociv, string funcao, double salario)
    {

        GerarId();

        this.Nome = nome;
        this.Cpf = cpf;
        this.Rg = rg;
        this.Telefone = telefone;
        this.Email = email;
        this.Rua = rua;
        this.Bairro = bairro;
        this.Numero = numero;
        this.DataNasc = datanasc;
        this.EstadoCivil = estadociv;
        this.Funcao = funcao;
        this.Salario = salario;

    }

    private void GerarId()
    {
        this._Id = Guid.NewGuid().ToString();
    }



}