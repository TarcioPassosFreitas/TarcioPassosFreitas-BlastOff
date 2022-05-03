using Orientacao_a_Objetos;
using System;

namespace Orientacao_a_Objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //====================Aula Objetos================================================
            //Objeto: Algo físico do mundo real. Podemos ter objetos abstratos como pagamento
            //Propriedades, métodos e eventos

            //==============Aula Classe e Objeto========================================
            //var customer = new Customer();
            //customer.Name = "teste";
            //Tipo de referência
            // -> Endereço dos dados
            //classe é um molde pra criar novos. Exemplo, classe cliente é um molde para criar novos clientes

            //==================Aula Encapsulamento=======================================

            //====================Aula Herança==========================================
            //var pagamentoBoleto = new PagamentoBoleto();
            //pagamentoBoleto.Pagar();
            //pagamentoBoleto.Vencimento = DateTime.Now;
            //pagamentoBoleto.NumeroBoleto = "1234";

            //var pagamento = new Pagamento();
            //pagamento.Vencimento = DateTime.Now;

            //==========================Aula Polimorfismo=====================================
            //var pagamento = new Pagamento();
            //pagamento.ToString();

            //======================Modificadores de acesso==================================
            //var pagamento = new Pagamento();

            //============================Tipos Complexos=======================================

            //=============================Propriedades========================================
            //var pagamento = new Pagamento();
            //pagamento.NumeroBoleto = "1234";
            //pagamento.DataPagamento = DateTime.Now;
            ////Console.WriteLine(pagamento.DataPagamento);

            //=============================Métodos=============================================
            //var pagamento = new Pagamento(DateTime.Now);
            ////var pagamentoCartao = new PagamentoCartao();
            //pagamento.Pagar("1234");

            //==============================Usign e Dispose=======================================
            //var pagamento = new Pagamento();
            //pagamento.Dispose();
            //using (var pagamento = new Pagamento())
            //{
            //    Console.WriteLine("Processando o Pagamento");
            //}

            //==============================Classes estáticas=======================================
            //var pagamento = new Pagamento();
            //Pagamento.Vencimento = DateTime.Now;


            //==============================Classes Seladas=============================================

            //================================Partial Class===========================================
            //var payment = new Payment();
            //payment.PropriedadeA;
            //payment.PropriedadeB;

            //==================================Interfaces============================================

            //=================================Classes abstratas========================================
            //Não pode ser instaciada, só pode ser herdada
            //var pagamento = new Pagamento();

            //================================Upcast e Downcast========================================
            //upcast tornar a classe filha do tipo da classe pai
            //downcast tornar a classe pai do tipo da classe filha

            //upcast
            //var pessoa = new Pessoa();
            //var pessoaFisica = new PessoaFisica();
            //pessoa = pessoaFisica;
            //pessoa = new PessoaFisica();
            //pessoa = new PessoaJuridica();

            //downcast
            //var pessoa = new Pessoa();
            //var pessoaFisica = new PessoaFisica();
            //var pessoaJuridica = new PessoaJuridica();

            //pessoaFisica = (PessoaFisica)pessoa;
            //pessoaFisica = (pessoaFisica)pessoaJuridica;

            //==================================Comparando Objetos=======================================
            //var pessoaA = new Pessoa(1, "Tarcio Passos");
            //var pessoaB = new Pessoa(1, "Tarcio Passos");
            //Console.WriteLine(pessoaA == pessoaB); //false
            //Console.WriteLine(pessoaA.Id == pessoaB.Id);  //true
            //Console.WriteLine(pessoaA.Equals(pessoaB));

            //===================================Delegates==============================================
            //var pagar = new Pagamento.Pagar(RealizarPagamento);
            //pagar(25);

            //====================================Events================================================
            //var room = new Room(3);
            //room.RoomSoldOutEvent += OnRoomSoldOut;
            //room.ReserveSeat();
            //room.ReserveSeat();
            //room.ReserveSeat();
            //room.ReserveSeat();
            //room.ReserveSeat();
            //room.ReserveSeat();

            //=====================================Generics===============================================
            //var person = new Person();
            //var payment = new Payment();
            //var subscription = new Subscription();
            //var context = new DataContext<IPerson, Payment, Subscription>();
            //context.Save(payment);
            //context.Save(person);
            //context.Save(subscription);

            //=====================================Listas==================================================
            //IList<Payment> payments = new List<Payment>();
            //payments.Add(new Payment(1);
            //payments.Remove(new Payment(1));
            //ICollection<Payment> payments2 = new List<Payment>(); //aqui já converte para o tipo especificado

            //var payments = new List<Payment>(); //se colocar var, o tipo vai ser do tipo de lista
            //payments.Add(new Payment(1));
            //payments.Add(new Payment(2));

            //payments.Add(new Payment(3));
            //payments.Add(new Payment(4));
            //payments.Add(new Payment(5));

            //foreach(var payment3 in payments)
            //{
            //    Console.WriteLine(payment3.Id);
            //}

            //var paidPayments = new List<Payment>();
            //paidPayments.AddRange(payments);

            ////Buscar
            ////espera sempre uma expressão
            ////Tras uma Inuramble ou seja retorna uma lista
            //var payment = payments.Where(x => x.Id == 3);
            ////first só trás 1 número
            //var payment2 = payments.First(x => x.Id == 3);
            //Console.WriteLine(payment2.Id);

            ////Remover itens
            //payments.Remove(payment2);
            ////payments.RemoveRange(); remove uma lista de uma lista

            ////limpar a lista
            //payments.Clear();

            ////foreach
            ////any retorna uma expressão booleana
            //var exists = payments.Any(x => x.Id == 3);
            //Console.WriteLine(exists);
            //foreach (var payment4 in payments) //pode ser um FirstOrDefault, o First, caso não tenha, dar erro, o FirstOrDefault retorna nulo caso tenha um erro
            //{
            //    Console.WriteLine(payment4.Id);
            //}

            ////contar quantos itens tem na lista
            //Console.WriteLine(payments.Count);

            ////pular 1 por exemplo
            //var exists2 = payments.Skip(1);
            //Console.WriteLine(exists2);

            ////pegar quantos itens da lista eu quero
            //foreach (var payment4 in payments.Take(3)) //pegar 3 itens da lista
            //{
            //    Console.WriteLine(payment4.Id);
            //}

            ////pular os 2 primeiros e pegar os 3 últimos
            //foreach (var payment4 in payments.Skip(2).Take(3)) //passando do intervalo a list já trata isso
            //{
            //    Console.WriteLine(payment4.Id);
            //}

            //convertendo listas
            IEnumerable<Payment> payments = new List<Payment>();
            payments.ToList(); //converte pra lista
            payments.AsEnumerable(); //converte para enumerable
            payments.ToArray(); //converte para array



        }
        //====================================Events================================================
        //static void OnRoomSoldOut(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Sala Lotada!");
        //}



        //===================================Delegates==============================================
        //static void RealizarPagamento(double valor)
        //{
        //    Console.WriteLine($"Pago o valor de {valor}");
        //}

    }

    //=====================================Listas==================================================
    public class Payment
    {
        public int Id { get; set; }
        public Payment(int id)
        {
            Id = id;
        }
    }


    //=====================================Generics===============================================
    //public class Person : IPerson { }
    //public class Payment { }
    //public class Subscription { }

    //public interface IPerson { }
    //public class DataContext<P, PA, S>
    //    where P : IPerson
    //    where PA : Payment
    //    where S : Subscription
    //{
    //    public void Save(P entity)
    //    {

    //    }

    //    public void Save(PA entity)
    //    {

    //    }

    //    public void Save(S entity)
    //    {

    //    }
    //}

    //====================================Events================================================
    //public class Room
    //{
    //    public Room(int seats)
    //    {
    //        Seats = seats;
    //        seatsInUse = 0;
    //    }
    //    private int seatsInUse = 0;
    //    public int Seats { get; set; }

    //    public void ReserveSeat()
    //    {
    //        seatsInUse++;
    //        if(seatsInUse > Seats)
    //        {
    //            OnRoomSoldOut(EventArgs.Empty);//evento fechado
    //        }
    //        else
    //        {
    //            Console.WriteLine("Assento Reservado");
    //        }
    //    }

    //    public event EventHandler RoomSoldOutEvent;
    //    //Geralmente se usa o On antes do nome
    //    protected virtual void OnRoomSoldOut(EventArgs e)
    //    {
    //        EventHandler handler = RoomSoldOutEvent;
    //        //? pois pode vir nulo esse evento
    //        handler?.Invoke(this, e); //this -> sempre refere ao objeto que é o objeto nulo
    //    }

    //}


    //===================================Delegates==============================================
    //Delegar para que alguém faça
    //anonymous Method

    //public class Pagamento
    //{
    //    public delegate void Pagar(double valor);
    //    //{
    //    //    //tira o código
    //    //}
    //}

    //==================================Comparando Objetos=======================================
    //public class Pessoa : IEquatable<Pessoa>
    //{
    //    public int Id { get; set; }
    //    public string nome { get; set; }
    //    public Pessoa(int id, string nome)
    //    {
    //        nome = nome;
    //    }

    //    public bool Equals(Pessoa? other)
    //    {
    //        return Id == other.Id && nome == other.nome;
    //    }
    //}

    //================================Upcast e Downcast========================================
    //public class Pessoa
    //{
    //    public string Nome { get; set; }
    //}

    //public class PessoaFisica : Pessoa
    //{
    //    public string CPF { get; set; }
    //}

    //public class PessoaJuridica : Pessoa
    //{
    //    public string CNPJ { get; set; }
    //}

    //==================================Interfaces============================================
    //Contrato, como uma classe deve ser

    //public class PagamentoApplePay : Pagamento
    //{
    //    public override void Pagar(double valor)
    //    {
    //        base.Pagar(valor);
    //    }
    //}
    //public class PagamentoBoleto : Pagamento
    //{
    //    public override void Pagar(double valor)
    //    {
    //        base.Pagar(valor);
    //    }
    //}
    //public class PagamentoCartaoCredito : Pagamento
    //{
    //    public override void Pagar(double valor)
    //    {
    //        base.Pagar(valor);
    //    }
    //}
    //public class PagamentoCartaoCredito : IPagamento
    //{
    //    public DateTime Vencimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public void Pagar(double valor)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //public abstract class Pagamento : IPagamento
    //{
    //    public DateTime Vencimento { get; set; } 
    //    public virtual void Pagar(double valor)
    //    {

    //    }
    //}
    //public interface IPagamento
    //{
    //    //Não tem implementação na interface
    //    //diz só o que precisa ser feito
    //    DateTime Vencimento { get; set; }
    //    void Pagar(double valor);
    //}

    //==============================Classes Seladas=============================================
    //Inibir a possibilidade de alguém extender da minha classe
    //public class Pagamento
    //{
    //    public DateTime Vencimento { get; set; }
    //}

    //Flunt -> Biblioteca do Balta para notificações
    //Notification

    //public class PagamentoCartao : Pagamento //não consegue, pois a classe está selada. sealed
    //{

    //}

    //==============================Classes estáticas=======================================
    //public static class Pagamento //static não pode ser instanciada. Pois ela já vai estar disponível na aplicação
    //{
    //    //public Pagamento()
    //    //{
    //    //    Console.WriteLine("Iniciando o Pagamento");
    //    //}
    //    public static DateTime Vencimento{ get; set; }


    //}

    //public static class Settings
    //{
    //    public static string API_URL { get; set; }
    //}

    //==============================Usign e Dispose=======================================
    //public class Pagamento : IDisposable
    //{
    //    public Pagamento()
    //    {
    //        Console.WriteLine("Iniciando o Pagamento");
    //    }

    //    public void Dispose()
    //    {
    //        Console.WriteLine("Finalizando o Pagamento");
    //    }
    //}

    //=============================Métodos=============================================
    //public class Pagamento
    //{
    //    public DateTime DataPagamento { get; set; }

    //    public Pagamento() { } //*1
    //    public Pagamento(DateTime Vencimento)
    //    {
    //        Console.WriteLine("Iniciando o Pagamento");
    //        DataPagamento = DateTime.Now;
    //    }

    //    public virtual void Pagar(string numero)
    //    {
    //        Console.WriteLine("Pagar");
    //    }
    //}

    //public class PagamentoCartao : Pagamento
    //{
    //    public PagamentoCartao(DateTime Vencimento) //2 formas de resolver *1 e *2
    //    : base(Vencimento) //*2
    //    {

    //    }
    //    public override void Pagar(string numero)
    //    {
    //        base.Pagar(numero);
    //        Console.WriteLine("Pagar o Cartão");
    //    }
    //}


    //=============================Propriedades========================================
    //public class Pagamento
    //{
    //    public string NumeroBoleto;
    //    public DateTime teste { get; private set; } //propg + tab
    //    public DateTime Vencimento { get; set; } //prop + tab
    //    private DateTime _dataPagamento; //propfull + tab

    //    public DateTime DataPagamento
    //    {
    //        get 
    //        {
    //            Console.WriteLine("Lendo o valor");
    //            return _dataPagamento.AddDays(1); 
    //        }
    //        set 
    //        {
    //            Console.WriteLine("Atribuindo o valor");
    //            _dataPagamento = value;
    //        }
    //    }

    //    //public DateTime Vencimento;

    //    void Pagar()
    //    {

    //    }
    //}

    //public class Adress
    //{
    //    string CodeZip;
    //}

    //============================Tipos Complexos=======================================
    //public class Pagamento
    //{
    //    DateTime Vencimento;
    //    //string ZipCodeAdress Não usar assim
    //    Adress BillingAdress; //Usar assim

    //    void Pagar()
    //    {

    //    }
    //}

    //public class Adress
    //{
    //    string ZipCode;
    //}

    //======================Modificadores de acesso==================================
    //private, protected, internal, public
    //class Pagamento //Não deixa nada, é a mesma coisa de ser private class Pagamento.
    //{
    //    //Propriedades
    //    private DateTime Vencimento { get; set; }
    //    //Métodos
    //    private void Pagar() //permite que esse método seja sobrescrito
    //    {

    //    }
    //}

    //class Pagamento //Não deixa nada, é a mesma coisa de ser internal class Pagamento.
    //{
    //    //Propriedades
    //    protected DateTime Vencimento { get; set; }
    //    //Métodos
    //    private void Pagar() //permite que esse método seja sobrescrito
    //    {

    //    }
    //}

    //class PagamentoBoleto : Pagamento
    //{
    //    void test()
    //    {
    //        base.Vencimento = DateTime.Now;
    //    }
    //}
    //==========================Aula Polimorfismo=====================================
    //Objeto com n formas dentro da classe
    //class Pagamento
    //{
    //    //Propriedades
    //    public DateTime Vencimento { get; set; }
    //    //Métodos
    //    public virtual void Pagar() //permite que esse método seja sobrescrito
    //    {

    //    }

    //    //todo método no c# herda de system
    //    public override string ToString()
    //    {
    //        return Vencimento.ToString("dd/mm/yyyy");
    //    }
    //}

    //class PagamentoBoleto : Pagamento //herda de Pagamento
    //{
    //    //DateTime vencimento;

    //    public override void Pagar()
    //    {
    //        //Regra do boleto 
    //    }
    //    public string NumeroBoleto;
    //}

    //class PagamentoCartaoCredito : Pagamento
    //{
    //    public string Numero;

    //    public override void Pagar()
    //    {
    //        //Regra do cartão de crédito
    //    }
    //}

    //====================Aula Herança==========================================
    //Capacidade que um objeto tem de herdar caracteristica de um outro objeto
    //class Pagamento
    //{
    //    //Propriedades
    //    public DateTime Vencimento { get; set; }
    //    //Métodos
    //    public void Pagar()
    //    {

    //    }
    //}

    //class PagamentoBoleto : Pagamento //herda de Pagamento
    //{
    //    //DateTime vencimento;

    //    //public void Pagar()
    //    //{

    //    //}
    //    public string NumeroBoleto;
    //}

    //class PagamentoCartaoCredito : Pagamento
    //{
    //    public string Numero;
    //}

    //======================Aula Abstração========================================
    //Esconder os detalhes, esconder aquilo que não precisamos
    //class Pagamento
    //{
    //    //Propriedades
    //    DateTime vencimento;
    //    //Métodos
    //    void Pagar()
    //    {
    //        ConsultarSaldoCartao("15132132");
    //    }
    //    private void ConsultarSaldoCartao(string numero) //privar que classes de fora consigam ter acesso
    //    {

    //    }
    //public void ConsultarSaldoCartao(string numero) //privar que classes de fora consigam ter acesso
    //{

    //}


    //==================Aula Encapsulamento=======================================
    //class Pagamento
    //{
    //    //Propriedades
    //    DateTime vencimento;
    //    //Métodos
    //    void Pagar()
    //    {

    //    }
    //}


    //==============Aula Classe e Objeto========================================
    //struct Customer
    //{
    //    public string Name;
    //}

    //class Customer
    //{
    //    public string Name;
    //}
}
